namespace WFAClient
{
    partial class ApplicationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblFlatId = new System.Windows.Forms.Label();
            this.lblDateOfCreation = new System.Windows.Forms.Label();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.tbFlatId = new System.Windows.Forms.TextBox();
            this.tbDateOfCreation = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQueueNumber = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbQueueNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(824, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(267, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(705, 337);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(12, 361);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(241, 13);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(670, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblId.Location = new System.Drawing.Point(10, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(112, 23);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 14;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudentEmail.Location = new System.Drawing.Point(10, 91);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(112, 23);
            this.lblStudentEmail.TabIndex = 13;
            this.lblStudentEmail.Text = "Student email";
            this.lblStudentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFlatId
            // 
            this.lblFlatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFlatId.Location = new System.Drawing.Point(12, 114);
            this.lblFlatId.Name = "lblFlatId";
            this.lblFlatId.Size = new System.Drawing.Size(112, 23);
            this.lblFlatId.TabIndex = 15;
            this.lblFlatId.Text = "Flat ID";
            this.lblFlatId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOfCreation
            // 
            this.lblDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateOfCreation.Location = new System.Drawing.Point(10, 137);
            this.lblDateOfCreation.Name = "lblDateOfCreation";
            this.lblDateOfCreation.Size = new System.Drawing.Size(112, 23);
            this.lblDateOfCreation.TabIndex = 16;
            this.lblDateOfCreation.Text = "Date of creation";
            this.lblDateOfCreation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Location = new System.Drawing.Point(119, 93);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(134, 20);
            this.tbStudentEmail.TabIndex = 17;
            // 
            // tbFlatId
            // 
            this.tbFlatId.Location = new System.Drawing.Point(119, 116);
            this.tbFlatId.Name = "tbFlatId";
            this.tbFlatId.Size = new System.Drawing.Size(134, 20);
            this.tbFlatId.TabIndex = 18;
            // 
            // tbDateOfCreation
            // 
            this.tbDateOfCreation.Enabled = false;
            this.tbDateOfCreation.Location = new System.Drawing.Point(119, 139);
            this.tbDateOfCreation.Name = "tbDateOfCreation";
            this.tbDateOfCreation.Size = new System.Drawing.Size(134, 20);
            this.tbDateOfCreation.TabIndex = 19;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(10, 160);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(112, 23);
            this.lblScore.TabIndex = 20;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQueueNumber
            // 
            this.lblQueueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQueueNumber.Location = new System.Drawing.Point(10, 183);
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(112, 23);
            this.lblQueueNumber.TabIndex = 21;
            this.lblQueueNumber.Text = "Queue number";
            this.lblQueueNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbScore
            // 
            this.tbScore.Enabled = false;
            this.tbScore.Location = new System.Drawing.Point(119, 162);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(134, 20);
            this.tbScore.TabIndex = 22;
            // 
            // tbQueueNumber
            // 
            this.tbQueueNumber.Enabled = false;
            this.tbQueueNumber.Location = new System.Drawing.Point(119, 185);
            this.tbQueueNumber.Name = "tbQueueNumber";
            this.tbQueueNumber.Size = new System.Drawing.Size(134, 20);
            this.tbQueueNumber.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(119, 70);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(134, 20);
            this.tbId.TabIndex = 27;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(241, 22);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbQueueNumber);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.lblQueueNumber);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.tbDateOfCreation);
            this.Controls.Add(this.tbFlatId);
            this.Controls.Add(this.tbStudentEmail);
            this.Controls.Add(this.lblDateOfCreation);
            this.Controls.Add(this.lblFlatId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView);
            this.Name = "ApplicationsForm";
            this.Text = "ApplicationsForm";
            this.Load += new System.EventHandler(this.ApplicationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblFlatId;
        private System.Windows.Forms.Label lblDateOfCreation;
        private System.Windows.Forms.TextBox tbStudentEmail;
        private System.Windows.Forms.TextBox tbFlatId;
        private System.Windows.Forms.TextBox tbDateOfCreation;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQueueNumber;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbQueueNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnReset;
    }
}