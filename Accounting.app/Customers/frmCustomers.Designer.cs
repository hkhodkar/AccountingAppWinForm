namespace Accounting.app
{
    partial class frmCustomers
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddCustomer = new System.Windows.Forms.ToolStripButton();
            this.EditCustomer = new System.Windows.Forms.ToolStripButton();
            this.DeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.RefreshGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نام = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomer,
            this.EditCustomer,
            this.DeleteCustomer,
            this.RefreshGrid,
            this.toolStripLabel1,
            this.TxtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddCustomer
            // 
            this.AddCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.Image = global::Accounting.app.Properties.Resources._1371475930_filenew;
            this.AddCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(74, 59);
            this.AddCustomer.Text = "شخص جدید";
            this.AddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // EditCustomer
            // 
            this.EditCustomer.Image = global::Accounting.app.Properties.Resources._1371475973_document_edit;
            this.EditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCustomer.Name = "EditCustomer";
            this.EditCustomer.Size = new System.Drawing.Size(83, 59);
            this.EditCustomer.Text = "ویرایش شخص";
            this.EditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditCustomer.Click += new System.EventHandler(this.EditCustomer_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Image = global::Accounting.app.Properties.Resources._1371476007_Close_Box_Red;
            this.DeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(72, 59);
            this.DeleteCustomer.Text = "حذف شخص";
            this.DeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // RefreshGrid
            // 
            this.RefreshGrid.Image = global::Accounting.app.Properties.Resources._1371476368_Synchronize;
            this.RefreshGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshGrid.Name = "RefreshGrid";
            this.RefreshGrid.Size = new System.Drawing.Size(60, 59);
            this.RefreshGrid.Text = "بروزرسانی";
            this.RefreshGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshGrid.Click += new System.EventHandler(this.RefreshGrid_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 59);
            this.toolStripLabel1.Text = "جستجو:";
            // 
            // TxtFilter
            // 
            this.TxtFilter.BackColor = System.Drawing.SystemColors.Window;
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(100, 62);
            this.TxtFilter.TextChanged += new System.EventHandler(this.FilterCustomer_TextChanged);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.نام,
            this.Email,
            this.Mobile});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 62);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(584, 299);
            this.dgvCustomer.TabIndex = 1;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerID";
            this.CustomerId.HeaderText = "Column1";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // نام
            // 
            this.نام.DataPropertyName = "FullName";
            this.نام.HeaderText = "نام";
            this.نام.Name = "نام";
            this.نام.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست اشخاص";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddCustomer;
        private System.Windows.Forms.ToolStripButton EditCustomer;
        private System.Windows.Forms.ToolStripButton DeleteCustomer;
        private System.Windows.Forms.ToolStripButton RefreshGrid;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TxtFilter;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
    }
}