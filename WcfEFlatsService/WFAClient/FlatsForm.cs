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
    public partial class FlatsForm : Form
    {
        EFlatsServiceReference.WcfEFlatsServiceClient client = new EFlatsServiceReference.WcfEFlatsServiceClient("WSHttpBinding_IWcfEFlatsService");
        EFlatsServiceReference.WcfEFlatsServiceAdminClient clientAdmin = new EFlatsServiceReference.WcfEFlatsServiceAdminClient("NetTcpBinding_IWcfEFlatsServiceAdmin");
        private DataSet ds;

        public FlatsForm()
        {
            InitializeComponent();
            GetDataSetToGrid();
        }


        //btns event handlers
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adding row to the database discards changes\nDo you wish to proceed?",
             "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adding row to the database discards changes\nDo you wish to proceed?",
             "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            GetDataSetToGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adding row to the database discards changes\nDo you wish to proceed?",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (AddFlat())
                lblOutput.Text = "Flat was successfully added";
            else
                lblOutput.Text = "Unable to add Flat to the database";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(UpdateFlat())
            {
                GetDataSetToGrid();
                lblOutput.Text = "Flat was successfully updated";
            }
            else
                lblOutput.Text = "Unable to update Flat to the database\nMake sure that all Applications belonging to this flat are deleted";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DeleteRow())
                lblOutput.Text = "Row was successfully deleted";
            else
                lblOutput.Text = "An Error has accured - Unable to delete row";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        //grid view event handlers
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblOutput.Text = "";
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
            LoadTextFields(row);
        }

        //private methods
        private void GetDataSetToGrid()
        {
            try
            {
                //refresh connection to client
                clientAdmin = new EFlatsServiceReference.WcfEFlatsServiceAdminClient("NetTcpBinding_IWcfEFlatsServiceAdmin");
                //load table 
                ds = clientAdmin.AdminGetTableData("Flats");
                BindingSource bSource = new BindingSource();
                bSource.DataSource = ds.Tables[0];
                dataGridView.DataSource = bSource;

                ds.Tables[0].Columns["Id"].ReadOnly = true;                
            }
            catch
            {
                lblOutput.Text = "Unable to connect to the Database";
            }
        }

        private bool AddFlat()
        {
            try
            {
                //refresh connection to wcf
                client = new EFlatsServiceReference.WcfEFlatsServiceClient("WSHttpBinding_IWcfEFlatsService");
                string result = client.AddFlat(tbLandlordEmail.Text, tbType.Text, tbAddress.Text, tbPostCode.Text, tbCity.Text, Convert.ToDouble(tbRent.Text),
                    Convert.ToDouble(tbDeposit.Text), tbAvailableFrom.Text, tbDescription.Text);

                if (!result.Trim().Equals("Successfully added."))
                    return false;

                GetDataSetToGrid();
                return true;
            }
            catch(Exception e)
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
                    if (row.RowState != DataRowState.Deleted)
                    {
                        int id = Convert.ToInt32(row["Id"]);
                        if (id == Convert.ToInt32(tbId.Text))
                        {
                            row.Delete();
                            return true;
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

        private bool UpdateFlat()
        {
            try
            {
                return clientAdmin.AdminUpdateFlats(ds);
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private void LoadTextFields(DataGridViewRow row)
        {
            tbId.Text = row.Cells["Id"].Value.ToString().Trim();
            tbLandlordEmail.Text = row.Cells["LandlordEmail"].Value.ToString().Trim();
            tbType.Text = row.Cells["Type"].Value.ToString().Trim();
            tbAddress.Text = row.Cells["Address"].Value.ToString().Trim();
            tbPostCode.Text = row.Cells["PostCode"].Value.ToString().Trim();
            tbCity.Text = row.Cells["City"].Value.ToString().Trim();
            tbRent.Text = row.Cells["Rent"].Value.ToString().Trim();
            tbDeposit.Text = row.Cells["Deposit"].Value.ToString().Trim();
            tbAvailableFrom.Text = row.Cells["AvailableFrom"].Value.ToString().Trim();
            tbDateOfCreation.Text = row.Cells["DateOfCreation"].Value.ToString().Trim();
            tbDescription.Text = row.Cells["Description"].Value.ToString().Trim();
            tbStatus.Text = row.Cells["Status"].Value.ToString().Trim();
            tbDateOfOffer.Text = row.Cells["DateOfOffer"].Value.ToString().Trim();
        }

        private void ResetFields()
        {
            tbId.Text = "";
            tbLandlordEmail.Text = "";
            tbType.Text = "";
            tbAddress.Text = ""; ;
            tbPostCode.Text = ""; ;
            tbCity.Text = "";
            tbRent.Text = "";
            tbDeposit.Text = "";
            tbAvailableFrom.Text = "";
            tbDateOfCreation.Text = "";
            tbDescription.Text = "";
            tbStatus.Text = "";
            tbDateOfOffer.Text = "";
            lblOutput.Text = "";
        }
    }
}
