namespace WFAClient
{
    partial class FlatsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbLandlordEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLandlordEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDateOfCreation = new System.Windows.Forms.Label();
            this.lblAvailableFrom = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblDateOfOffer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbRent = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDateOfCreation = new System.Windows.Forms.TextBox();
            this.tbAvailableFrom = new System.Windows.Forms.TextBox();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.tbDateOfOffer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(267, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(705, 395);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(824, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(14, 365);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(241, 35);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(670, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(241, 22);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(121, 65);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(134, 20);
            this.tbId.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(121, 180);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(134, 20);
            this.tbCity.TabIndex = 40;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Location = new System.Drawing.Point(121, 157);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(134, 20);
            this.tbPostCode.TabIndex = 39;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(12, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(112, 23);
            this.lblCity.TabIndex = 38;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPostCode
            // 
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostCode.Location = new System.Drawing.Point(12, 155);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(112, 23);
            this.lblPostCode.TabIndex = 37;
            this.lblPostCode.Text = "Post Code";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(121, 134);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(134, 20);
            this.tbAddress.TabIndex = 36;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(121, 111);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(134, 20);
            this.tbType.TabIndex = 35;
            // 
            // tbLandlordEmail
            // 
            this.tbLandlordEmail.Location = new System.Drawing.Point(121, 88);
            this.tbLandlordEmail.Name = "tbLandlordEmail";
            this.tbLandlordEmail.Size = new System.Drawing.Size(134, 20);
            this.tbLandlordEmail.TabIndex = 34;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(12, 132);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 23);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblType.Location = new System.Drawing.Point(14, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(112, 23);
            this.lblType.TabIndex = 32;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 31;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLandlordEmail
            // 
            this.lblLandlordEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLandlordEmail.Location = new System.Drawing.Point(12, 86);
            this.lblLandlordEmail.Name = "lblLandlordEmail";
            this.lblLandlordEmail.Size = new System.Drawing.Size(112, 23);
            this.lblLandlordEmail.TabIndex = 30;
            this.lblLandlordEmail.Text = "Landlord email";
            this.lblLandlordEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblId.Location = new System.Drawing.Point(12, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(112, 23);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(12, 293);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 23);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOfCreation
            // 
            this.lblDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateOfCreation.Location = new System.Drawing.Point(12, 270);
            this.lblDateOfCreation.Name = "lblDateOfCreation";
            this.lblDateOfCreation.Size = new System.Drawing.Size(112, 23);
            this.lblDateOfCreation.TabIndex = 49;
            this.lblDateOfCreation.Text = "Date of creation";
            this.lblDateOfCreation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvailableFrom
            // 
            this.lblAvailableFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAvailableFrom.Location = new System.Drawing.Point(12, 247);
            this.lblAvailableFrom.Name = "lblAvailableFrom";
            this.lblAvailableFrom.Size = new System.Drawing.Size(112, 23);
            this.lblAvailableFrom.TabIndex = 48;
            this.lblAvailableFrom.Text = "Available from";
            this.lblAvailableFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeposit
            // 
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeposit.Location = new System.Drawing.Point(12, 224);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(112, 23);
            this.lblDeposit.TabIndex = 47;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRent
            // 
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRent.Location = new System.Drawing.Point(14, 201);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(112, 23);
            this.lblRent.TabIndex = 46;
            this.lblRent.Text = "Rent";
            this.lblRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOfOffer
            // 
            this.lblDateOfOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateOfOffer.Location = new System.Drawing.Point(12, 339);
            this.lblDateOfOffer.Name = "lblDateOfOffer";
            this.lblDateOfOffer.Size = new System.Drawing.Size(112, 23);
            this.lblDateOfOffer.TabIndex = 52;
            this.lblDateOfOffer.Text = "Date of offer";
            this.lblDateOfOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(12, 316);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 23);
            this.lblStatus.TabIndex = 51;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRent
            // 
            this.tbRent.Location = new System.Drawing.Point(121, 203);
            this.tbRent.Name = "tbRent";
            this.tbRent.Size = new System.Drawing.Size(134, 20);
            this.tbRent.TabIndex = 58;
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(121, 318);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(134, 20);
            this.tbStatus.TabIndex = 57;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(121, 295);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(134, 20);
            this.tbDescription.TabIndex = 56;
            // 
            // tbDateOfCreation
            // 
            this.tbDateOfCreation.Location = new System.Drawing.Point(121, 272);
            this.tbDateOfCreation.Name = "tbDateOfCreation";
            this.tbDateOfCreation.Size = new System.Drawing.Size(134, 20);
            this.tbDateOfCreation.TabIndex = 55;
            // 
            // tbAvailableFrom
            // 
            this.tbAvailableFrom.Location = new System.Drawing.Point(121, 249);
            this.tbAvailableFrom.Name = "tbAvailableFrom";
            this.tbAvailableFrom.Size = new System.Drawing.Size(134, 20);
            this.tbAvailableFrom.TabIndex = 54;
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(121, 226);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(134, 20);
            this.tbDeposit.TabIndex = 53;
            // 
            // tbDateOfOffer
            // 
            this.tbDateOfOffer.Enabled = false;
            this.tbDateOfOffer.Location = new System.Drawing.Point(121, 342);
            this.tbDateOfOffer.Name = "tbDateOfOffer";
            this.tbDateOfOffer.Size = new System.Drawing.Size(134, 20);
            this.tbDateOfOffer.TabIndex = 59;
            // 
            // FlatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 470);
            this.Controls.Add(this.tbDateOfOffer);
            this.Controls.Add(this.tbRent);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbDateOfCreation);
            this.Controls.Add(this.tbAvailableFrom);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.lblDateOfOffer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateOfCreation);
            this.Controls.Add(this.lblAvailableFrom);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbLandlordEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLandlordEmail);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView);
            this.Name = "FlatsForm";
            this.Text = "Flats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbLandlordEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLandlordEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateOfCreation;
        private System.Windows.Forms.Label lblAvailableFrom;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblDateOfOffer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbRent;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbDateOfCreation;
        private System.Windows.Forms.TextBox tbAvailableFrom;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.TextBox tbDateOfOffer;
    }
}