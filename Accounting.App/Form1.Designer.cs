namespace Accounting.App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnReceiveReport = new System.Windows.Forms.ToolStripButton();
            this.btnPaymentReport = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUserAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.customValidator1 = new ValidationComponents.CustomValidator(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.btnNewAccounting,
            this.btnReceiveReport,
            this.btnPaymentReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 70);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 70);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources._3d_fluency_accounting;
            this.pictureBox1.Location = new System.Drawing.Point(12, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::Accounting.App.Properties.Resources.icons8_users_48;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(71, 67);
            this.btnCustomer.Text = "طرف حساب";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources.icons8_transaction_48;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(72, 67);
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnReceiveReport
            // 
            this.btnReceiveReport.Image = global::Accounting.App.Properties.Resources.icons8_cash_receipt_48;
            this.btnReceiveReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReceiveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceiveReport.Name = "btnReceiveReport";
            this.btnReceiveReport.Size = new System.Drawing.Size(98, 67);
            this.btnReceiveReport.Text = "گزارش دریافتی ها";
            this.btnReceiveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReceiveReport.Click += new System.EventHandler(this.btnReceiveReport_Click);
            // 
            // btnPaymentReport
            // 
            this.btnPaymentReport.Image = global::Accounting.App.Properties.Resources.icons8_graph_report_48;
            this.btnPaymentReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPaymentReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaymentReport.Name = "btnPaymentReport";
            this.btnPaymentReport.Size = new System.Drawing.Size(97, 67);
            this.btnPaymentReport.Text = "گزارش پرداختی ها";
            this.btnPaymentReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaymentReport.Click += new System.EventHandler(this.btnPaymentReport_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUserAccount});
            this.btnSetting.Image = global::Accounting.App.Properties.Resources.icons8_setting_48;
            this.btnSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(63, 67);
            this.btnSetting.Text = "تنظیمات";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAccount.Image = global::Accounting.App.Properties.Resources.icons8_account_48;
            this.btnUserAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(212, 54);
            this.btnUserAccount.Text = "حساب کاربری";
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // customValidator1
            // 
            this.customValidator1.CancelFocusChangeWhenInvalid = false;
            this.customValidator1.ControlToValidate = null;
            this.customValidator1.ErrorMessage = null;
            this.customValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("customValidator1.Icon")));
            this.customValidator1.IsValidated = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "حسابداری شخصی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton btnSetting;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private ValidationComponents.CustomValidator customValidator1;
        private System.Windows.Forms.ToolStripButton btnPaymentReport;
        private System.Windows.Forms.ToolStripButton btnReceiveReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnUserAccount;
    }
}

