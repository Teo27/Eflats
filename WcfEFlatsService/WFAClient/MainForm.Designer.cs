namespace WFAClient
{
    partial class MainForm
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFlats = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(31, 23);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(169, 51);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnFlats
            // 
            this.btnFlats.Location = new System.Drawing.Point(31, 80);
            this.btnFlats.Name = "btnFlats";
            this.btnFlats.Size = new System.Drawing.Size(169, 51);
            this.btnFlats.TabIndex = 1;
            this.btnFlats.Text = "Flats";
            this.btnFlats.UseVisualStyleBackColor = true;
            this.btnFlats.Click += new System.EventHandler(this.btnFlats_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.Location = new System.Drawing.Point(31, 137);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(169, 51);
            this.btnApplications.TabIndex = 2;
            this.btnApplications.Text = "Applications";
            this.btnApplications.UseVisualStyleBackColor = true;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(31, 194);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 51);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 370);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnApplications);
            this.Controls.Add(this.btnFlats);
            this.Controls.Add(this.btnUsers);
            this.Name = "MainForm";
            this.Text = "EFlats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnFlats;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Button btnLogout;
    }
}