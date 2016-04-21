using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAClient
{
    public partial class UsersForm : Form
    {
        static EFlatsServiceReference.WcfEFlatsServiceAdminClient clientAdmin;
        static EFlatsServiceReference.WcfEFlatsServiceClient client;
        private DataSet ds;

        public UsersForm()
        {
            InitializeComponent();
            //loads table on selected index changed
            cbType.SelectedIndex = 0;
            cbMaintain.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        //type changed
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            //change cb manage values
            ChangeComboBox();
            //change menu visibility
            GroupingVisibility();
            //change menu labels text
            ChangeLables();
        }

        //manage changed
        private void cbMaintain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change menu visibility
            GroupingVisibility();
        }


        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData(e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adding row to the database discards changes\nDo you wish to proceed?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            ResetFields();
            GetDataSetToGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddUser())
                lblOutput.Text = "row was successfully added";
            else
                lblOutput.Text = "Unable to add row to the database";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteRow())
                lblOutput.Text = "Row was successfully deleted";
            else
                lblOutput.Text = "An Error has accured - Unable to delete row";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateTable())
            {
                GetDataSetToGrid();
                lblOutput.Text = "Table was successfully updated";
            }
            else
                lblOutput.Text = "Unable to save Table to the database";
        }

        //------------------------------------------------------------------------------------
        //private methods

        private void GetDataSetToGrid()
        {
            try
            {
                clientAdmin = new EFlatsServiceReference.WcfEFlatsServiceAdminClient("NetTcpBinding_IWcfEFlatsServiceAdmin");
                //load table 
                ds = new DataSet();
                ds = clientAdmin.AdminGetTableData(cbType.SelectedItem.ToString().Trim());
                BindingSource bSource = new BindingSource();
                bSource.DataSource = ds.Tables[0];
                dataGridViewUser.DataSource = bSource;

                SetColumnsReadOnly();
            }
            catch
            {
                lblOutput.Text = "Unable to connect to the Database";
            }
        }

        private void SetColumnsReadOnly()
        {
            ds.Tables[0].Columns["Password"].ReadOnly = true;
            ds.Tables[0].Columns["Salt"].ReadOnly = true;

            if (cbType.SelectedItem.ToString().Trim().Equals("Students"))
            {
                ds.Tables[0].Columns["DateOfCreation"].ReadOnly = true;
                ds.Tables[0].Columns["Score"].ReadOnly = true;
                ds.Tables[0].Columns["ConfirmationCode"].ReadOnly = true;
            }
            else if (cbType.SelectedItem.ToString().Trim().Equals("Landlords"))
            {
                ds.Tables[0].Columns["DateOfCreation"].ReadOnly = true;
            }
        }

        private bool AddUser()
        {
            if (cbType.SelectedItem.ToString().Trim().Equals("Students"))
                return AddStudent();
            else if (cbType.SelectedItem.ToString().Trim().Equals("Landlords"))
                return AddLandlord();
            else if (cbType.SelectedItem.ToString().Trim().Equals("Admins"))
                return AddAdmin();

            return false;
        }

        private bool UpdateTable()
        {
            try
            {
                if (cbType.SelectedItem.ToString().Trim().Equals("Students"))
                    return clientAdmin.AdminUpdateStudents(ds);
                else if (cbType.SelectedItem.ToString().Trim().Equals("Landlords"))
                    return clientAdmin.AdminUpdateLandlords(ds);
                else if (cbType.SelectedItem.ToString().Trim().Equals("Admins"))
                    return clientAdmin.AdminUpdateAdmins(ds);

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool AddStudent()
        {
            try
            {
                DataRow row = ds.Tables[0].NewRow();
                row["Email"] = tbIdentyfier.Text;
                row["Password"] = tbPassword.Text;
                row["Salt"] = "None";
                row["ConfirmationCode"] = "None";

                if (cbConfirmed.Checked)
                    row["Confirmed"] = true;
                else
                    row["Confirmed"] = false;

                if (cbStudent.Checked)
                    row["Student"] = true;
                else
                    row["Student"] = false;

                if (!String.IsNullOrEmpty(tbScore.Text))
                    row["Score"] = Convert.ToInt32(tbScore.Text);
                else
                    row["Score"] = 0;

                if (!String.IsNullOrEmpty(tbNumberOfChildren.Text))
                    row["NumberOfChildren"] = Convert.ToInt32(tbNumberOfChildren.Text);
                else
                    row["NumberOfChildren"] = 0;

                if (cbPet.Checked)
                    row["Pet"] = true;
                else
                    row["Pet"] = false;

                if (!String.IsNullOrEmpty(tbNumberOfCohabitors.Text))
                    row["NumberOfCohabitors"] = Convert.ToInt32(tbNumberOfCohabitors.Text);
                else
                    row["NumberOfCohabitors"] = 0;

                if (cbDisabled.Checked)
                    row["Disabled"] = true;
                else
                    row["Disabled"] = false;

                row["DateOfCreation"] = DateTime.Now;
                row["Name"] = tbNameCompanyName.Text;
                row["Surname"] = tbSurnameContactPerson.Text;
                row["Address"] = tbAddress.Text;
                row["PostCode"] = tbPostCode.Text;
                row["City"] = tbCity.Text;
                row["Country"] = tbCountry.Text;
                row["Phone"] = tbPhone.Text;

                ds.Tables[0].Rows.Add(row);

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private bool AddLandlord()
        {
            try
            {
                DataRow row = ds.Tables[0].NewRow();
                row["Email"] = tbIdentyfier.Text;
                row["Password"] = tbPassword.Text;
                row["Salt"] = "None";

                if (cbConfirmed.Checked)
                    row["Confirmed"] = true;
                else
                    row["Confirmed"] = false;

                row["DateOfCreation"] = DateTime.Now;
                row["Name"] = tbNameCompanyName.Text;
                row["ContactPerson"] = tbSurnameContactPerson.Text;
                row["Address"] = tbAddress.Text;
                row["PostCode"] = tbPostCode.Text;
                row["City"] = tbCity.Text;
                row["Country"] = tbCountry.Text;
                row["Phone"] = tbPhone.Text;

                ds.Tables[0].Rows.Add(row);           
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private bool AddAdmin()
        {

            try
            {
                DataRow row = ds.Tables[0].NewRow();
                row["Username"] = tbIdentyfier.Text;
                row["Password"] = tbPassword.Text;
                row["Salt"] = "None";

                ds.Tables[0].Rows.Add(row);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool DeleteRow()
        {
            try
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //check if row wasnt already deleted
                    if (row.RowState != DataRowState.Deleted)
                    {
                        //check if table is landlord or student
                        if(cbType.SelectedItem.ToString().Trim().Equals("Students")
                        || cbType.SelectedItem.ToString().Trim().Equals("Landlords"))
                        {
                            string Email = (row["Email"]).ToString().Trim();
                            //check if row is correct
                            if (Email.Equals(tbIdentyfier.Text))
                            {
                                row.Delete();
                                return true;
                            }
                        }

                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void ChangeComboBox()
        {
            lblOutput.Text = "";
            ComboboxItem item = new ComboboxItem();
            ComboboxItem item1 = new ComboboxItem();
            ComboboxItem item2 = new ComboboxItem();

            item.Text = "Account";
            item1.Text = "Personal";
            item2.Text = "QueueBased";

            if (cbType.Text.Trim().Equals("Students"))
            {
                cbMaintain.Items.Clear();
                cbMaintain.Items.Add(item);
                cbMaintain.Items.Add(item1);
                cbMaintain.Items.Add(item2);
                cbMaintain.SelectedIndex = 0;
            }
            else if (cbType.Text.Trim().Equals("Landlords"))
            {
                cbMaintain.Items.Clear();
                cbMaintain.Items.Add(item);
                cbMaintain.Items.Add(item1);
                cbMaintain.SelectedIndex = 0;
            }
            else if (cbType.Text.Trim().Equals("Admins"))
            {
                cbMaintain.Items.Clear();
                cbMaintain.Items.Add(item);
                cbMaintain.SelectedIndex = 0;
            }

            GetDataSetToGrid();
        }

        private void GroupingVisibility()
        {
            if (cbMaintain.SelectedItem.ToString().Trim().Equals("Account"))
            {
                gbAcc.Show();
                gbPersonal.Hide();
                gbQueueBased.Hide();
            }
            else if (cbMaintain.SelectedItem.ToString().Trim().Equals("Personal"))
            {
                gbPersonal.Show();
                gbAcc.Hide();
                gbQueueBased.Hide();
            }
            else if (cbMaintain.SelectedItem.ToString().Trim().Equals("QueueBased"))
            {
                gbQueueBased.Show();
                gbPersonal.Hide();
                gbAcc.Hide();
            }
        }

        private void ChangeLables()
        {
            if (cbType.SelectedItem.ToString().Trim().Equals("Students"))
            {
                AccountInfoStudent();
            }
            else if (cbType.SelectedItem.ToString().Trim().Equals("Landlords"))
            {
                AccountInfoLandlord();
            }
            else if (cbType.SelectedItem.ToString().Trim().Equals("Admins"))
            {
                AccountInfoAdmin();
            }
        }

        private void LoadData(DataGridViewCellEventArgs e)
        {
            lblOutput.Text = "";

            if (e.RowIndex < 0)
                return;

            if (cbType.SelectedItem.ToString().Trim().Equals("Students"))
            {
                LoadStudent(e);
            }
            else if (cbType.SelectedItem.ToString().Trim().Equals("Landlords"))
            {
                LoadLandlord(e);
            }
            else if (cbType.SelectedItem.ToString().Trim().Equals("Admins"))
            {
                LoadAdmin(e);
            }
        }

        private void LoadStudent(DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridViewUser.Rows[e.RowIndex];
                tbIdentyfier.Text = row.Cells["Email"].Value.ToString().Trim();
                tbPassword.Text = row.Cells["Password"].Value.ToString().Trim();
                tbSalt.Text = row.Cells["Salt"].Value.ToString().Trim();

                if (Convert.ToBoolean(row.Cells["Confirmed"].Value))
                    cbConfirmed.Checked = true;
                else
                    cbConfirmed.Checked = false;

                if (Convert.ToBoolean(row.Cells["Student"].Value))
                    cbStudent.Checked = true;
                else
                    cbStudent.Checked = false;

                tbScore.Text = row.Cells["Score"].Value.ToString().Trim();
                tbNumberOfChildren.Text = row.Cells["NumberOfChildren"].Value.ToString().Trim();

                if (Convert.ToBoolean(row.Cells["Pet"].Value))
                    cbPet.Checked = true;
                else
                    cbPet.Checked = false;

                tbNumberOfCohabitors.Text = row.Cells["NumberOfCohabitors"].Value.ToString().Trim();

                if (Convert.ToBoolean(row.Cells["Disabled"].Value))
                    cbDisabled.Checked = true;
                else
                    cbDisabled.Checked = false;

                tbDateOfCreation.Text = row.Cells["DateOfCreation"].Value.ToString().Trim();
                tbNameCompanyName.Text = row.Cells["Name"].Value.ToString().Trim();
                tbSurnameContactPerson.Text = row.Cells["Surname"].Value.ToString().Trim();
                tbAddress.Text = row.Cells["Address"].Value.ToString().Trim();
                tbPostCode.Text = row.Cells["PostCode"].Value.ToString().Trim();
                tbCity.Text = row.Cells["City"].Value.ToString().Trim();
                tbCountry.Text = row.Cells["Country"].Value.ToString().Trim();
                tbPhone.Text = row.Cells["Phone"].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void LoadLandlord(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUser.Rows[e.RowIndex];
            tbIdentyfier.Text = row.Cells["Email"].Value.ToString().Trim();
            tbPassword.Text = row.Cells["Password"].Value.ToString().Trim();
            tbSalt.Text = row.Cells["Salt"].Value.ToString().Trim();

            if (Convert.ToBoolean(row.Cells["Confirmed"].Value))
                cbConfirmed.Checked = true;
            else
                cbConfirmed.Checked = false;
            tbDateOfCreation.Text = row.Cells["DateOfCreation"].Value.ToString().Trim();
            tbNameCompanyName.Text = row.Cells["Name"].Value.ToString().Trim();
            tbAddress.Text = row.Cells["Address"].Value.ToString().Trim();
            tbPostCode.Text = row.Cells["PostCode"].Value.ToString().Trim();
            tbCity.Text = row.Cells["City"].Value.ToString().Trim();
            tbCountry.Text = row.Cells["Country"].Value.ToString().Trim();
            tbSurnameContactPerson.Text = row.Cells["ContactPerson"].Value.ToString().Trim();
            tbPhone.Text = row.Cells["Phone"].Value.ToString().Trim();
        }

        private void LoadAdmin(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUser.Rows[e.RowIndex];
            tbIdentyfier.Text = row.Cells["Username"].Value.ToString().Trim();
            tbPassword.Text = row.Cells["Password"].Value.ToString().Trim();
            tbSalt.Text = row.Cells["Salt"].Value.ToString().Trim();
        }

        private void AccountInfoAdmin()
        {
            lblIdentifier.Text = "Username";

            //hide / show lbls, tbs and btns
            lblDateOfCreation.Hide();
            lblConfirmed.Hide();
            tbDateOfCreation.Hide();
            cbConfirmed.Hide();
            //btnDelete.Hide();
            btnAdd.Show();
        }

        private void AccountInfoStudent()
        {
            lblNameCompany.Text = "Name";
            lblSurnameContactPerson.Text = "Surname";
            lblIdentifier.Text = "Email";

            lblDateOfCreation.Show();
            lblConfirmed.Show();
            tbDateOfCreation.Show();
            cbConfirmed.Show();
            btnDelete.Show();
            btnAdd.Show();
        }

        private void AccountInfoLandlord()
        {
            lblNameCompany.Text = "Company";
            lblSurnameContactPerson.Text = "Contact Person";
            lblIdentifier.Text = "Email";

            lblDateOfCreation.Show();
            lblConfirmed.Show();
            tbDateOfCreation.Show();
            cbConfirmed.Show();
            //btnAdd.Hide();
            btnDelete.Show();
        }

        private void ResetFields()
        {
            tbIdentyfier.Text = "";
            tbPassword.Text = "";
            tbSalt.Text = "";
            tbDateOfCreation.Text = "";
            cbConfirmed.Checked = false;

            cbStudent.Checked = false;
            tbScore.Text = "";
            tbNumberOfChildren.Text = "";
            cbPet.Checked = false;
            tbNumberOfCohabitors.Text = ""; ;
            cbDisabled.Checked = false;

            tbNameCompanyName.Text = "";
            tbSurnameContactPerson.Text = "";
            tbAddress.Text = "";
            tbPostCode.Text = "";
            tbCity.Text = "";
            tbCountry.Text = "";
            tbPhone.Text = "";
        }

        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

    }
}
