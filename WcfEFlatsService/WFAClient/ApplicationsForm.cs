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
    public partial class ApplicationsForm : Form
    {
        EFlatsServiceReference.WcfEFlatsServiceClient client = new EFlatsServiceReference.WcfEFlatsServiceClient("WSHttpBinding_IWcfEFlatsService");
        EFlatsServiceReference.WcfEFlatsServiceAdminClient clientAdmin = new EFlatsServiceReference.WcfEFlatsServiceAdminClient("NetTcpBinding_IWcfEFlatsServiceAdmin");
        private DataSet ds;

        public ApplicationsForm()
        {
            InitializeComponent();
            GetDataSetToGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Changes will be discarded\nDo you wish to proceed?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Changes will be discarded\nDo you wish to proceed?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            RefreshTable();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblOutput.Text = "";

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
            tbId.Text = row.Cells["Id"].Value.ToString().Trim();
            tbStudentEmail.Text = row.Cells["StudentEmail"].Value.ToString().Trim();
            tbFlatId.Text = row.Cells["FlatId"].Value.ToString().Trim();
            tbDateOfCreation.Text = row.Cells["DateOfCreation"].Value.ToString().Trim();
            tbScore.Text = row.Cells["Score"].Value.ToString().Trim();
            tbQueueNumber.Text = row.Cells["QueueNumber"].Value.ToString().Trim();   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            if (MessageBox.Show("Adding row to the database discards changes\nDo you wish to proceed?", 
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                //refresh connection to client
                client = new EFlatsServiceReference.WcfEFlatsServiceClient("WSHttpBinding_IWcfEFlatsService");
                int profileScore = client.GetStudentData(tbStudentEmail.Text.Trim()).Score;
                bool output = client.AddToWishlist(tbStudentEmail.Text.Trim(), 
                    Convert.ToInt32(tbFlatId.Text.Trim()), profileScore);

                if (output)
                    lblOutput.Text = "Application was successfully added";
                else
                    lblOutput.Text = "An Error has accured - Unable to add application";
                RefreshTable();
            }
            catch(Exception e2)
            {
                lblOutput.Text = "Unable to connect to the Database";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            if (DeleteRow())
                lblOutput.Text = "Row was successfully deleted";
            else
                lblOutput.Text = "An Error has accured - Unable to delete row";
        }

        private void RefreshTable()
        {
            lblOutput.Text = "";
            try
            {
                GetDataSetToGrid();
            }
            catch
            {
                lblOutput.Text = "Unable to connect to the Database";
            }
        }

        private bool DeleteRow()
        {
            try
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if(row.RowState != DataRowState.Deleted)
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
            catch(Exception e)
            {
                return false;
            }
        }

        private void ApplicationsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbStudentEmail.Text = "";
            tbFlatId.Text = "";
            tbDateOfCreation.Text = "";
            tbScore.Text = "";
            tbQueueNumber.Text = "";
        }

        private void GetDataSetToGrid()
        {
            //load table 
            try
            {
                ds = new DataSet();
                ds = clientAdmin.AdminGetTableData("Applications");
                BindingSource bSource = new BindingSource();
                bSource.DataSource = ds.Tables[0];
                dataGridView.DataSource = bSource;

                ds.Tables[0].Columns["Id"].ReadOnly = true;
                ds.Tables[0].Columns["DateOfCreation"].ReadOnly = true;
                ds.Tables[0].Columns["Score"].ReadOnly = true;
                ds.Tables[0].Columns["QueueNumber"].ReadOnly = true;
            }
            catch
            {
                lblOutput.Text = "Unable to connect to the Database";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = clientAdmin.AdminUpdateApplications(ds);
                if (result)
                {
                    RefreshTable();
                    lblOutput.Text = "Update successful";
                    GetDataSetToGrid();
                }
                else
                {
                    lblOutput.Text = "Unable to update Database\nYour Modified Table might contain duplicate values";
                }
            }
            catch(Exception e2)
            {
                lblOutput.Text = "Error acured";
            }
        }
    }
}
