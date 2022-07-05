namespace College_Practise
{
    partial class Form2
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRetypePass = new System.Windows.Forms.Label();
            this.lvlUsertype = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxRetypePass = new System.Windows.Forms.TextBox();
            this.cmbboxUsertype = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearchByUSername = new System.Windows.Forms.Label();
            this.txtboxSearchByUsername = new System.Windows.Forms.TextBox();
            this.grdUsername = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(84, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(84, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblRetypePass
            // 
            this.lblRetypePass.AutoSize = true;
            this.lblRetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePass.Location = new System.Drawing.Point(84, 127);
            this.lblRetypePass.Name = "lblRetypePass";
            this.lblRetypePass.Size = new System.Drawing.Size(114, 16);
            this.lblRetypePass.TabIndex = 2;
            this.lblRetypePass.Text = "Retype Password";
            // 
            // lvlUsertype
            // 
            this.lvlUsertype.AutoSize = true;
            this.lvlUsertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUsertype.Location = new System.Drawing.Point(84, 176);
            this.lvlUsertype.Name = "lvlUsertype";
            this.lvlUsertype.Size = new System.Drawing.Size(62, 16);
            this.lvlUsertype.TabIndex = 3;
            this.lvlUsertype.Text = "Usertype";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(204, 26);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(316, 22);
            this.txtboxUsername.TabIndex = 4;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(204, 75);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(316, 22);
            this.txtboxPassword.TabIndex = 5;
            // 
            // txtboxRetypePass
            // 
            this.txtboxRetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRetypePass.Location = new System.Drawing.Point(204, 121);
            this.txtboxRetypePass.Name = "txtboxRetypePass";
            this.txtboxRetypePass.PasswordChar = '*';
            this.txtboxRetypePass.Size = new System.Drawing.Size(316, 22);
            this.txtboxRetypePass.TabIndex = 6;
            // 
            // cmbboxUsertype
            // 
            this.cmbboxUsertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxUsertype.FormattingEnabled = true;
            this.cmbboxUsertype.Items.AddRange(new object[] {
            "Choose Roles",
            "Admin",
            "User"});
            this.cmbboxUsertype.Location = new System.Drawing.Point(204, 168);
            this.cmbboxUsertype.Name = "cmbboxUsertype";
            this.cmbboxUsertype.Size = new System.Drawing.Size(316, 24);
            this.cmbboxUsertype.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(49, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(150, 245);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(93, 31);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(262, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(356, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 31);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearchByUSername
            // 
            this.lblSearchByUSername.AutoSize = true;
            this.lblSearchByUSername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByUSername.Location = new System.Drawing.Point(63, 311);
            this.lblSearchByUSername.Name = "lblSearchByUSername";
            this.lblSearchByUSername.Size = new System.Drawing.Size(135, 16);
            this.lblSearchByUSername.TabIndex = 12;
            this.lblSearchByUSername.Text = "Search By Username";
            // txtboxSearchByUsername
            // 
            this.txtboxSearchByUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearchByUsername.Location = new System.Drawing.Point(204, 308);
            this.txtboxSearchByUsername.Name = "txtboxSearchByUsername";
            this.txtboxSearchByUsername.Size = new System.Drawing.Size(316, 22);
            this.txtboxSearchByUsername.TabIndex = 13;
            this.txtboxSearchByUsername.TextChanged += new System.EventHandler(this.txtboxSearchByUsername_TextChanged);
            // 
            // grdUsername
            // 
            this.grdUsername.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsername.Location = new System.Drawing.Point(49, 365);
            this.grdUsername.Name = "grdUsername";
            this.grdUsername.Size = new System.Drawing.Size(453, 248);
            this.grdUsername.TabIndex = 14;
            this.grdUsername.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsername_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(547, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdUsername);
            this.Controls.Add(this.txtboxSearchByUsername);
            this.Controls.Add(this.lblSearchByUSername);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbboxUsertype);
            this.Controls.Add(this.txtboxRetypePass);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lvlUsertype);
            this.Controls.Add(this.lblRetypePass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRetypePass;
        private System.Windows.Forms.Label lvlUsertype;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxRetypePass;
        private System.Windows.Forms.ComboBox cmbboxUsertype;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearchByUSername;
        private System.Windows.Forms.TextBox txtboxSearchByUsername;
        private System.Windows.Forms.DataGridView grdUsername;
        private System.Windows.Forms.Label label1;
    }
}