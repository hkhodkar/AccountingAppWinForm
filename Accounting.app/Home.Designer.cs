namespace Accounting.app
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ShowCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnAddAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnPayReport = new System.Windows.Forms.ToolStripButton();
            this.btnRecieveReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoginSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Recieves = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Pays = new System.Windows.Forms.Label();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblRecieve = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowCustomers,
            this.btnAddAccounting,
            this.btnPayReport,
            this.btnRecieveReport});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // ShowCustomers
            // 
            this.ShowCustomers.Image = global::Accounting.app.Properties.Resources._1371476468_preferences_contact_list;
            resources.ApplyResources(this.ShowCustomers, "ShowCustomers");
            this.ShowCustomers.Name = "ShowCustomers";
            this.ShowCustomers.Click += new System.EventHandler(this.ShowCustomers_Click);
            // 
            // btnAddAccounting
            // 
            this.btnAddAccounting.Image = global::Accounting.app.Properties.Resources._1371476499_todo_list;
            resources.ApplyResources(this.btnAddAccounting, "btnAddAccounting");
            this.btnAddAccounting.Name = "btnAddAccounting";
            this.btnAddAccounting.Click += new System.EventHandler(this.btnAddAccounting_Click);
            // 
            // btnPayReport
            // 
            this.btnPayReport.Image = global::Accounting.app.Properties.Resources.servicesCosts;
            resources.ApplyResources(this.btnPayReport, "btnPayReport");
            this.btnPayReport.Name = "btnPayReport";
            this.btnPayReport.Click += new System.EventHandler(this.btnPayReport_Click);
            // 
            // btnRecieveReport
            // 
            this.btnRecieveReport.Image = global::Accounting.app.Properties.Resources._1370791030_credit_card;
            resources.ApplyResources(this.btnRecieveReport, "btnRecieveReport");
            this.btnRecieveReport.Name = "btnRecieveReport";
            this.btnRecieveReport.Click += new System.EventHandler(this.btnRecieveReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            resources.ApplyResources(this.lblDate, "lblDate");
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            resources.ApplyResources(this.lblTime, "lblTime");
            // 
            // lblTimer
            // 
            this.lblTimer.Enabled = true;
            this.lblTimer.Interval = 1000;
            this.lblTimer.Tick += new System.EventHandler(this.lblTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.app.Properties.Resources.Untitled_1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings});
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Name = "toolStrip2";
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoginSetting});
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            // 
            // btnLoginSetting
            // 
            this.btnLoginSetting.Name = "btnLoginSetting";
            resources.ApplyResources(this.btnLoginSetting, "btnLoginSetting");
            this.btnLoginSetting.Click += new System.EventHandler(this.btnLoginSetting_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Recieves
            // 
            resources.ApplyResources(this.Recieves, "Recieves");
            this.Recieves.Name = "Recieves";
            // 
            // lbl3
            // 
            resources.ApplyResources(this.lbl3, "lbl3");
            this.lbl3.Name = "lbl3";
            // 
            // Pays
            // 
            resources.ApplyResources(this.Pays, "Pays");
            this.Pays.Name = "Pays";
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.lblRecieve);
            this.gbReport.Controls.Add(this.lblAccountBalance);
            this.gbReport.Controls.Add(this.lblPays);
            this.gbReport.Controls.Add(this.Pays);
            this.gbReport.Controls.Add(this.lbl3);
            this.gbReport.Controls.Add(this.Recieves);
            resources.ApplyResources(this.gbReport, "gbReport");
            this.gbReport.Name = "gbReport";
            this.gbReport.TabStop = false;
            // 
            // lblPays
            // 
            resources.ApplyResources(this.lblPays, "lblPays");
            this.lblPays.Name = "lblPays";
            // 
            // lblRecieve
            // 
            resources.ApplyResources(this.lblRecieve, "lblRecieve");
            this.lblRecieve.Name = "lblRecieve";
            // 
            // lblAccountBalance
            // 
            resources.ApplyResources(this.lblAccountBalance, "lblAccountBalance");
            this.lblAccountBalance.Name = "lblAccountBalance";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ShowCustomers;
        private System.Windows.Forms.ToolStripButton btnRecieveReport;
        private System.Windows.Forms.ToolStripButton btnAddAccounting;
        private System.Windows.Forms.ToolStripButton btnPayReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer lblTimer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton btnSettings;
        private System.Windows.Forms.ToolStripMenuItem btnLoginSetting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Recieves;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label Pays;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label lblRecieve;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblAccountBalance;
    }
}

