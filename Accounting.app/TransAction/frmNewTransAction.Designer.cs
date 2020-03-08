namespace Accounting.app.Accounting
{
    partial class frmNewTransAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTransAction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTransAction = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.rbPayment = new System.Windows.Forms.RadioButton();
            this.rbRecieve = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.AmpountValidation = new ValidationComponents.RangeValidator(this.components);
            this.NameValidation = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransAction);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Location = new System.Drawing.Point(75, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // dgvTransAction
            // 
            this.dgvTransAction.AllowUserToAddRows = false;
            this.dgvTransAction.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransAction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransAction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTransAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransAction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.CustomerID});
            this.dgvTransAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransAction.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvTransAction.Location = new System.Drawing.Point(3, 50);
            this.dgvTransAction.Name = "dgvTransAction";
            this.dgvTransAction.ReadOnly = true;
            this.dgvTransAction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransAction.Size = new System.Drawing.Size(518, 248);
            this.dgvTransAction.TabIndex = 1;
            this.dgvTransAction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransAction_CellClick);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام شخص";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(324, 20);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(194, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(605, 26);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(67, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "طرف حساب:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(420, 23);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(179, 21);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(380, 26);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(31, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "مبلغ:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(208, 23);
            this.txtAmount.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(168, 21);
            this.txtAmount.TabIndex = 3;
            // 
            // rbPayment
            // 
            this.rbPayment.AutoSize = true;
            this.rbPayment.Location = new System.Drawing.Point(138, 26);
            this.rbPayment.Name = "rbPayment";
            this.rbPayment.Size = new System.Drawing.Size(58, 17);
            this.rbPayment.TabIndex = 4;
            this.rbPayment.TabStop = true;
            this.rbPayment.Text = "پرداخت";
            this.rbPayment.UseVisualStyleBackColor = true;
            // 
            // rbRecieve
            // 
            this.rbRecieve.AutoSize = true;
            this.rbRecieve.Location = new System.Drawing.Point(78, 27);
            this.rbRecieve.Name = "rbRecieve";
            this.rbRecieve.Size = new System.Drawing.Size(55, 17);
            this.rbRecieve.TabIndex = 4;
            this.rbRecieve.TabStop = true;
            this.rbRecieve.Text = "دریافت";
            this.rbRecieve.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "شرح:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(524, 103);
            this.txtDescription.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AmpountValidation
            // 
            this.AmpountValidation.CancelFocusChangeWhenInvalid = false;
            this.AmpountValidation.ControlToValidate = this.txtAmount;
            this.AmpountValidation.ErrorMessage = "لطفا مبلغ را وارد نمایید";
            this.AmpountValidation.Icon = ((System.Drawing.Icon)(resources.GetObject("AmpountValidation.Icon")));
            this.AmpountValidation.MaximumValue = "9999999999999";
            this.AmpountValidation.MinimumValue = "1";
            this.AmpountValidation.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // NameValidation
            // 
            this.NameValidation.CancelFocusChangeWhenInvalid = false;
            this.NameValidation.ControlToValidate = this.txtCustomerName;
            this.NameValidation.ErrorMessage = "نام طرف حساب را از لیست انتخاب نمایید";
            this.NameValidation.Icon = ((System.Drawing.Icon)(resources.GetObject("NameValidation.Icon")));
            // 
            // frmNewTransAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRecieve);
            this.Controls.Add(this.rbPayment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewTransAction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frmNewTransAction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTransAction;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.RadioButton rbPayment;
        private System.Windows.Forms.RadioButton rbRecieve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RangeValidator AmpountValidation;
        private ValidationComponents.RequiredFieldValidator NameValidation;
    }
}