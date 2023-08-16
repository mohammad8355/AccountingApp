namespace Accounting.App
{
    partial class frmUserView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUserP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting_DBDataSet2 = new Accounting.App.Accounting_DBDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.checkEditPassword = new System.Windows.Forms.CheckBox();
            this.HideUserName = new System.Windows.Forms.CheckBox();
            this.checkEditUsername = new System.Windows.Forms.CheckBox();
            this.userAccountTableAdapter = new Accounting.App.Accounting_DBDataSet2TableAdapters.UserAccountTableAdapter();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.txtUserP);
            this.groupBox1.Controls.Add(this.txtUserN);
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnEditUser);
            this.groupBox1.Controls.Add(this.showPassword);
            this.groupBox1.Controls.Add(this.checkEditPassword);
            this.groupBox1.Controls.Add(this.HideUserName);
            this.groupBox1.Controls.Add(this.checkEditUsername);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات حساب کاربری";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Jadid", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(489, 106);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 19);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "رمز عبور";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Jadid", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(489, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "نام کاربری";
            // 
            // txtUserP
            // 
            this.txtUserP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserP.ForeColor = System.Drawing.Color.White;
            this.txtUserP.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserP.HintText = "";
            this.txtUserP.isPassword = true;
            this.txtUserP.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtUserP.LineIdleColor = System.Drawing.Color.White;
            this.txtUserP.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtUserP.LineThickness = 3;
            this.txtUserP.Location = new System.Drawing.Point(244, 129);
            this.txtUserP.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserP.MaxLength = 32767;
            this.txtUserP.Name = "txtUserP";
            this.txtUserP.Size = new System.Drawing.Size(297, 33);
            this.txtUserP.TabIndex = 12;
            this.txtUserP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserN
            // 
            this.txtUserN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserN.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserN.ForeColor = System.Drawing.Color.White;
            this.txtUserN.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserN.HintText = "";
            this.txtUserN.isPassword = false;
            this.txtUserN.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtUserN.LineIdleColor = System.Drawing.Color.White;
            this.txtUserN.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtUserN.LineThickness = 3;
            this.txtUserN.Location = new System.Drawing.Point(244, 60);
            this.txtUserN.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserN.MaxLength = 32767;
            this.txtUserN.Name = "txtUserN";
            this.txtUserN.Size = new System.Drawing.Size(297, 33);
            this.txtUserN.TabIndex = 11;
            this.txtUserN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.usernameDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.userAccountBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(6, 120);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.Size = new System.Drawing.Size(129, 193);
            this.dgvUsers.TabIndex = 10;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataMember = "UserAccount";
            this.userAccountBindingSource.DataSource = this.accounting_DBDataSet2;
            // 
            // accounting_DBDataSet2
            // 
            this.accounting_DBDataSet2.DataSetName = "Accounting_DBDataSet2";
            this.accounting_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(305, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "حدف حساب کاربری";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.ForeColor = System.Drawing.Color.Crimson;
            this.btnEditUser.Location = new System.Drawing.Point(456, 278);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(93, 35);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.Text = "ویرایش";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Visible = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Jadid", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.showPassword.Location = new System.Drawing.Point(18, 82);
            this.showPassword.Name = "showPassword";
            this.showPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showPassword.Size = new System.Drawing.Size(59, 23);
            this.showPassword.TabIndex = 7;
            this.showPassword.Text = "نمایش";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // checkEditPassword
            // 
            this.checkEditPassword.AutoSize = true;
            this.checkEditPassword.Font = new System.Drawing.Font("Jadid", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkEditPassword.Location = new System.Drawing.Point(88, 83);
            this.checkEditPassword.Name = "checkEditPassword";
            this.checkEditPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkEditPassword.Size = new System.Drawing.Size(116, 23);
            this.checkEditPassword.TabIndex = 6;
            this.checkEditPassword.Text = "ویرایش رمز عبور";
            this.checkEditPassword.UseVisualStyleBackColor = true;
            this.checkEditPassword.CheckedChanged += new System.EventHandler(this.checkEditPassword_CheckedChanged);
            // 
            // HideUserName
            // 
            this.HideUserName.AutoSize = true;
            this.HideUserName.Font = new System.Drawing.Font("Jadid", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HideUserName.Location = new System.Drawing.Point(18, 37);
            this.HideUserName.Name = "HideUserName";
            this.HideUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HideUserName.Size = new System.Drawing.Size(56, 23);
            this.HideUserName.TabIndex = 3;
            this.HideUserName.Text = "پنهان";
            this.HideUserName.UseVisualStyleBackColor = true;
            this.HideUserName.CheckedChanged += new System.EventHandler(this.HideUserName_CheckedChanged);
            // 
            // checkEditUsername
            // 
            this.checkEditUsername.AutoSize = true;
            this.checkEditUsername.Font = new System.Drawing.Font("Jadid", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkEditUsername.Location = new System.Drawing.Point(88, 38);
            this.checkEditUsername.Name = "checkEditUsername";
            this.checkEditUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkEditUsername.Size = new System.Drawing.Size(125, 23);
            this.checkEditUsername.TabIndex = 2;
            this.checkEditUsername.Text = "ویرایش نام کاربری";
            this.checkEditUsername.UseVisualStyleBackColor = true;
            this.checkEditUsername.CheckedChanged += new System.EventHandler(this.checkEditUsername_CheckedChanged);
            // 
            // userAccountTableAdapter
            // 
            this.userAccountTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.txtUserN;
            // 
            // frmUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(584, 343);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUserView";
            this.Load += new System.EventHandler(this.frmUserView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting_DBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.CheckBox checkEditPassword;
        private System.Windows.Forms.CheckBox HideUserName;
        private System.Windows.Forms.CheckBox checkEditUsername;
        private System.Windows.Forms.DataGridView dgvUsers;
        private Accounting_DBDataSet2 accounting_DBDataSet2;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private Accounting_DBDataSet2TableAdapters.UserAccountTableAdapter userAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserN;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}