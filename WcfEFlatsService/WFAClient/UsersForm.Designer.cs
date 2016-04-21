namespace WFAClient
{
    partial class UsersForm
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.cbMaintain = new System.Windows.Forms.ComboBox();
            this.gbAcc = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbConfirmed = new System.Windows.Forms.CheckBox();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblDateOfCreation = new System.Windows.Forms.Label();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.tbDateOfCreation = new System.Windows.Forms.TextBox();
            this.tbSalt = new System.Windows.Forms.TextBox();
            this.tbIdentyfier = new System.Windows.Forms.TextBox();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurnameContactPerson = new System.Windows.Forms.Label();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSurnameContactPerson = new System.Windows.Forms.TextBox();
            this.tbNameCompanyName = new System.Windows.Forms.TextBox();
            this.gbQueueBased = new System.Windows.Forms.GroupBox();
            this.cbDisabled = new System.Windows.Forms.CheckBox();
            this.cbPet = new System.Windows.Forms.CheckBox();
            this.cbStudent = new System.Windows.Forms.CheckBox();
            this.tbNumberOfCohabitors = new System.Windows.Forms.TextBox();
            this.lblDisAbled = new System.Windows.Forms.Label();
            this.lblNumberOfCohabutors = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblNumberOfChildren = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.tbNumberOfChildren = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.gbAcc.SuspendLayout();
            this.gbPersonal.SuspendLayout();
            this.gbQueueBased.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(812, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Students",
            "Landlords",
            "Admins"});
            this.cbType.Location = new System.Drawing.Point(172, 28);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(21, 30);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(60, 15);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "User type";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(314, 55);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(658, 347);
            this.dataGridViewUser.TabIndex = 4;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(658, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMaintain
            // 
            this.lblMaintain.AutoSize = true;
            this.lblMaintain.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintain.Location = new System.Drawing.Point(21, 57);
            this.lblMaintain.Name = "lblMaintain";
            this.lblMaintain.Size = new System.Drawing.Size(55, 15);
            this.lblMaintain.TabIndex = 13;
            this.lblMaintain.Text = "Maintain";
            // 
            // cbMaintain
            // 
            this.cbMaintain.FormattingEnabled = true;
            this.cbMaintain.Items.AddRange(new object[] {
            "Account",
            "Personal",
            "Queue based"});
            this.cbMaintain.Location = new System.Drawing.Point(172, 55);
            this.cbMaintain.Name = "cbMaintain";
            this.cbMaintain.Size = new System.Drawing.Size(121, 21);
            this.cbMaintain.TabIndex = 12;
            this.cbMaintain.SelectedIndexChanged += new System.EventHandler(this.cbMaintain_SelectedIndexChanged);
            // 
            // gbAcc
            // 
            this.gbAcc.Controls.Add(this.tbPassword);
            this.gbAcc.Controls.Add(this.lblPassword);
            this.gbAcc.Controls.Add(this.cbConfirmed);
            this.gbAcc.Controls.Add(this.lblConfirmed);
            this.gbAcc.Controls.Add(this.lblDateOfCreation);
            this.gbAcc.Controls.Add(this.lblSalt);
            this.gbAcc.Controls.Add(this.lblIdentifier);
            this.gbAcc.Controls.Add(this.tbDateOfCreation);
            this.gbAcc.Controls.Add(this.tbSalt);
            this.gbAcc.Controls.Add(this.tbIdentyfier);
            this.gbAcc.Location = new System.Drawing.Point(15, 100);
            this.gbAcc.Name = "gbAcc";
            this.gbAcc.Size = new System.Drawing.Size(284, 200);
            this.gbAcc.TabIndex = 14;
            this.gbAcc.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(157, 44);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(121, 20);
            this.tbPassword.TabIndex = 42;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(6, 42);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(145, 23);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbConfirmed
            // 
            this.cbConfirmed.AutoSize = true;
            this.cbConfirmed.Location = new System.Drawing.Point(205, 115);
            this.cbConfirmed.Name = "cbConfirmed";
            this.cbConfirmed.Size = new System.Drawing.Size(15, 14);
            this.cbConfirmed.TabIndex = 40;
            this.cbConfirmed.UseVisualStyleBackColor = true;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfirmed.Location = new System.Drawing.Point(6, 110);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(145, 23);
            this.lblConfirmed.TabIndex = 33;
            this.lblConfirmed.Text = "Account Confrimed";
            this.lblConfirmed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOfCreation
            // 
            this.lblDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateOfCreation.Location = new System.Drawing.Point(6, 87);
            this.lblDateOfCreation.Name = "lblDateOfCreation";
            this.lblDateOfCreation.Size = new System.Drawing.Size(145, 23);
            this.lblDateOfCreation.TabIndex = 32;
            this.lblDateOfCreation.Text = "Date of creation";
            this.lblDateOfCreation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalt
            // 
            this.lblSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSalt.Location = new System.Drawing.Point(6, 64);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(145, 23);
            this.lblSalt.TabIndex = 31;
            this.lblSalt.Text = "Salt";
            this.lblSalt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdentifier.Location = new System.Drawing.Point(6, 19);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(145, 23);
            this.lblIdentifier.TabIndex = 30;
            this.lblIdentifier.Text = "Email / Username";
            this.lblIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDateOfCreation
            // 
            this.tbDateOfCreation.Enabled = false;
            this.tbDateOfCreation.Location = new System.Drawing.Point(157, 89);
            this.tbDateOfCreation.Name = "tbDateOfCreation";
            this.tbDateOfCreation.Size = new System.Drawing.Size(121, 20);
            this.tbDateOfCreation.TabIndex = 17;
            // 
            // tbSalt
            // 
            this.tbSalt.Enabled = false;
            this.tbSalt.Location = new System.Drawing.Point(157, 67);
            this.tbSalt.Name = "tbSalt";
            this.tbSalt.Size = new System.Drawing.Size(121, 20);
            this.tbSalt.TabIndex = 16;
            // 
            // tbIdentyfier
            // 
            this.tbIdentyfier.Location = new System.Drawing.Point(157, 21);
            this.tbIdentyfier.Name = "tbIdentyfier";
            this.tbIdentyfier.Size = new System.Drawing.Size(121, 20);
            this.tbIdentyfier.TabIndex = 15;
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.tbPhone);
            this.gbPersonal.Controls.Add(this.tbCountry);
            this.gbPersonal.Controls.Add(this.tbCity);
            this.gbPersonal.Controls.Add(this.lblPhone);
            this.gbPersonal.Controls.Add(this.lblCountry);
            this.gbPersonal.Controls.Add(this.lblCity);
            this.gbPersonal.Controls.Add(this.tbPostCode);
            this.gbPersonal.Controls.Add(this.lblPostCode);
            this.gbPersonal.Controls.Add(this.lblAddress);
            this.gbPersonal.Controls.Add(this.lblSurnameContactPerson);
            this.gbPersonal.Controls.Add(this.lblNameCompany);
            this.gbPersonal.Controls.Add(this.tbAddress);
            this.gbPersonal.Controls.Add(this.tbSurnameContactPerson);
            this.gbPersonal.Controls.Add(this.tbNameCompanyName);
            this.gbPersonal.Location = new System.Drawing.Point(15, 100);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(284, 187);
            this.gbPersonal.TabIndex = 15;
            this.gbPersonal.TabStop = false;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(157, 158);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(121, 20);
            this.tbPhone.TabIndex = 40;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(157, 135);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(121, 20);
            this.tbCountry.TabIndex = 39;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(157, 112);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(121, 20);
            this.tbCity.TabIndex = 38;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.Location = new System.Drawing.Point(6, 155);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(145, 23);
            this.lblPhone.TabIndex = 37;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry.Location = new System.Drawing.Point(6, 133);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(145, 23);
            this.lblCountry.TabIndex = 36;
            this.lblCountry.Text = "Country";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(6, 110);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(145, 23);
            this.lblCity.TabIndex = 35;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Location = new System.Drawing.Point(157, 90);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(121, 20);
            this.tbPostCode.TabIndex = 34;
            // 
            // lblPostCode
            // 
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostCode.Location = new System.Drawing.Point(6, 87);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(145, 23);
            this.lblPostCode.TabIndex = 33;
            this.lblPostCode.Text = "Post code";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(6, 64);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(145, 23);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSurnameContactPerson
            // 
            this.lblSurnameContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurnameContactPerson.Location = new System.Drawing.Point(6, 42);
            this.lblSurnameContactPerson.Name = "lblSurnameContactPerson";
            this.lblSurnameContactPerson.Size = new System.Drawing.Size(145, 23);
            this.lblSurnameContactPerson.TabIndex = 31;
            this.lblSurnameContactPerson.Text = "Surname / Contact Person";
            this.lblSurnameContactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameCompany.Location = new System.Drawing.Point(6, 19);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(145, 23);
            this.lblNameCompany.TabIndex = 30;
            this.lblNameCompany.Text = "Name / Company name";
            this.lblNameCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(157, 67);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(121, 20);
            this.tbAddress.TabIndex = 17;
            // 
            // tbSurnameContactPerson
            // 
            this.tbSurnameContactPerson.Location = new System.Drawing.Point(157, 44);
            this.tbSurnameContactPerson.Name = "tbSurnameContactPerson";
            this.tbSurnameContactPerson.Size = new System.Drawing.Size(121, 20);
            this.tbSurnameContactPerson.TabIndex = 16;
            // 
            // tbNameCompanyName
            // 
            this.tbNameCompanyName.Location = new System.Drawing.Point(157, 21);
            this.tbNameCompanyName.Name = "tbNameCompanyName";
            this.tbNameCompanyName.Size = new System.Drawing.Size(121, 20);
            this.tbNameCompanyName.TabIndex = 15;
            // 
            // gbQueueBased
            // 
            this.gbQueueBased.Controls.Add(this.cbDisabled);
            this.gbQueueBased.Controls.Add(this.cbPet);
            this.gbQueueBased.Controls.Add(this.cbStudent);
            this.gbQueueBased.Controls.Add(this.tbNumberOfCohabitors);
            this.gbQueueBased.Controls.Add(this.lblDisAbled);
            this.gbQueueBased.Controls.Add(this.lblNumberOfCohabutors);
            this.gbQueueBased.Controls.Add(this.lblPet);
            this.gbQueueBased.Controls.Add(this.lblNumberOfChildren);
            this.gbQueueBased.Controls.Add(this.lblScore);
            this.gbQueueBased.Controls.Add(this.lblStudent);
            this.gbQueueBased.Controls.Add(this.tbNumberOfChildren);
            this.gbQueueBased.Controls.Add(this.tbScore);
            this.gbQueueBased.Location = new System.Drawing.Point(15, 100);
            this.gbQueueBased.Name = "gbQueueBased";
            this.gbQueueBased.Size = new System.Drawing.Size(284, 174);
            this.gbQueueBased.TabIndex = 41;
            this.gbQueueBased.TabStop = false;
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Location = new System.Drawing.Point(210, 138);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(15, 14);
            this.cbDisabled.TabIndex = 41;
            this.cbDisabled.UseVisualStyleBackColor = true;
            // 
            // cbPet
            // 
            this.cbPet.AutoSize = true;
            this.cbPet.Location = new System.Drawing.Point(210, 92);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(15, 14);
            this.cbPet.TabIndex = 40;
            this.cbPet.UseVisualStyleBackColor = true;
            // 
            // cbStudent
            // 
            this.cbStudent.AutoSize = true;
            this.cbStudent.Location = new System.Drawing.Point(210, 24);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(15, 14);
            this.cbStudent.TabIndex = 39;
            this.cbStudent.UseVisualStyleBackColor = true;
            // 
            // tbNumberOfCohabitors
            // 
            this.tbNumberOfCohabitors.Location = new System.Drawing.Point(157, 112);
            this.tbNumberOfCohabitors.Name = "tbNumberOfCohabitors";
            this.tbNumberOfCohabitors.Size = new System.Drawing.Size(121, 20);
            this.tbNumberOfCohabitors.TabIndex = 38;
            // 
            // lblDisAbled
            // 
            this.lblDisAbled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDisAbled.Location = new System.Drawing.Point(6, 133);
            this.lblDisAbled.Name = "lblDisAbled";
            this.lblDisAbled.Size = new System.Drawing.Size(145, 23);
            this.lblDisAbled.TabIndex = 36;
            this.lblDisAbled.Text = "Disabled";
            this.lblDisAbled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfCohabutors
            // 
            this.lblNumberOfCohabutors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumberOfCohabutors.Location = new System.Drawing.Point(6, 110);
            this.lblNumberOfCohabutors.Name = "lblNumberOfCohabutors";
            this.lblNumberOfCohabutors.Size = new System.Drawing.Size(145, 23);
            this.lblNumberOfCohabutors.TabIndex = 35;
            this.lblNumberOfCohabutors.Text = "Number of cohabitors";
            this.lblNumberOfCohabutors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPet
            // 
            this.lblPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPet.Location = new System.Drawing.Point(6, 87);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(145, 23);
            this.lblPet.TabIndex = 33;
            this.lblPet.Text = "Pet";
            this.lblPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfChildren
            // 
            this.lblNumberOfChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumberOfChildren.Location = new System.Drawing.Point(6, 64);
            this.lblNumberOfChildren.Name = "lblNumberOfChildren";
            this.lblNumberOfChildren.Size = new System.Drawing.Size(145, 23);
            this.lblNumberOfChildren.TabIndex = 32;
            this.lblNumberOfChildren.Text = "Number of children";
            this.lblNumberOfChildren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(6, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(145, 23);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudent
            // 
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudent.Location = new System.Drawing.Point(6, 19);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(145, 23);
            this.lblStudent.TabIndex = 30;
            this.lblStudent.Text = "Student";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNumberOfChildren
            // 
            this.tbNumberOfChildren.Location = new System.Drawing.Point(157, 67);
            this.tbNumberOfChildren.Name = "tbNumberOfChildren";
            this.tbNumberOfChildren.Size = new System.Drawing.Size(121, 20);
            this.tbNumberOfChildren.TabIndex = 17;
            // 
            // tbScore
            // 
            this.tbScore.Enabled = false;
            this.tbScore.Location = new System.Drawing.Point(157, 44);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(121, 20);
            this.tbScore.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(38, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(241, 22);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(164, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(38, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 23);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Commit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(38, 290);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(241, 26);
            this.lblOutput.TabIndex = 46;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.gbQueueBased);
            this.Controls.Add(this.gbPersonal);
            this.Controls.Add(this.gbAcc);
            this.Controls.Add(this.lblMaintain);
            this.Controls.Add(this.cbMaintain);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnBack);
            this.Name = "UsersForm";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.gbAcc.ResumeLayout(false);
            this.gbAcc.PerformLayout();
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            this.gbQueueBased.ResumeLayout(false);
            this.gbQueueBased.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMaintain;
        private System.Windows.Forms.ComboBox cbMaintain;
        private System.Windows.Forms.GroupBox gbAcc;
        private System.Windows.Forms.TextBox tbIdentyfier;
        private System.Windows.Forms.TextBox tbDateOfCreation;
        private System.Windows.Forms.TextBox tbSalt;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblDateOfCreation;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblIdentifier;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurnameContactPerson;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSurnameContactPerson;
        private System.Windows.Forms.TextBox tbNameCompanyName;
        private System.Windows.Forms.GroupBox gbQueueBased;
        private System.Windows.Forms.TextBox tbNumberOfCohabitors;
        private System.Windows.Forms.Label lblDisAbled;
        private System.Windows.Forms.Label lblNumberOfCohabutors;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblNumberOfChildren;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox tbNumberOfChildren;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.CheckBox cbDisabled;
        private System.Windows.Forms.CheckBox cbPet;
        private System.Windows.Forms.CheckBox cbStudent;
        private System.Windows.Forms.CheckBox cbConfirmed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}