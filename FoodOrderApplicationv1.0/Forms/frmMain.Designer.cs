namespace FoodOrderApplicationv1._0
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.grpPayFilter = new System.Windows.Forms.GroupBox();
            this.chkUnpaid = new System.Windows.Forms.CheckBox();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.colFoodOrderID = new System.Windows.Forms.ColumnHeader();
            this.colFoodDescription = new System.Windows.Forms.ColumnHeader();
            this.colMoneyAmount = new System.Windows.Forms.ColumnHeader();
            this.colDateOrdered = new System.Windows.Forms.ColumnHeader();
            this.colPaidStatus = new System.Windows.Forms.ColumnHeader();
            this.colOrderedBy = new System.Windows.Forms.ColumnHeader();
            this.colOrderType = new System.Windows.Forms.ColumnHeader();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblOrderedBy = new System.Windows.Forms.Label();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDateOrdered = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.lblDateOrdered = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.grpPayFilter.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.grpOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabOverview);
            this.tabMain.Controls.Add(this.tabDetails);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(580, 323);
            this.tabMain.TabIndex = 2;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.grpPayFilter);
            this.tabOverview.Controls.Add(this.lblTotal);
            this.tabOverview.Controls.Add(this.btnAddOrder);
            this.tabOverview.Controls.Add(this.btnEditOrder);
            this.tabOverview.Controls.Add(this.btnDelete);
            this.tabOverview.Controls.Add(this.lvwMain);
            this.tabOverview.Location = new System.Drawing.Point(4, 22);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(572, 297);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // grpPayFilter
            // 
            this.grpPayFilter.Controls.Add(this.chkUnpaid);
            this.grpPayFilter.Controls.Add(this.chkPaid);
            this.grpPayFilter.Location = new System.Drawing.Point(6, 227);
            this.grpPayFilter.Name = "grpPayFilter";
            this.grpPayFilter.Size = new System.Drawing.Size(142, 64);
            this.grpPayFilter.TabIndex = 8;
            this.grpPayFilter.TabStop = false;
            this.grpPayFilter.Text = "Pay Filter";
            // 
            // chkUnpaid
            // 
            this.chkUnpaid.AutoSize = true;
            this.chkUnpaid.Location = new System.Drawing.Point(76, 19);
            this.chkUnpaid.Name = "chkUnpaid";
            this.chkUnpaid.Size = new System.Drawing.Size(60, 17);
            this.chkUnpaid.TabIndex = 6;
            this.chkUnpaid.Text = "Unpaid";
            this.chkUnpaid.UseVisualStyleBackColor = true;
            this.chkUnpaid.CheckedChanged += new System.EventHandler(this.chkUnpaid_CheckedChanged);
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Location = new System.Drawing.Point(6, 19);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(47, 17);
            this.chkPaid.TabIndex = 7;
            this.chkPaid.Text = "Paid";
            this.chkPaid.UseVisualStyleBackColor = true;
            this.chkPaid.CheckedChanged += new System.EventHandler(this.chkPaid_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(329, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(170, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Amount to Pay: Php 0.00";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(329, 268);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(410, 268);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrder.TabIndex = 3;
            this.btnEditOrder.Text = "Edit";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(491, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvwMain
            // 
            this.lvwMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFoodOrderID,
            this.colFoodDescription,
            this.colMoneyAmount,
            this.colDateOrdered,
            this.colPaidStatus,
            this.colOrderedBy,
            this.colOrderType});
            this.lvwMain.FullRowSelect = true;
            this.lvwMain.GridLines = true;
            this.lvwMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMain.HideSelection = false;
            this.lvwMain.Location = new System.Drawing.Point(6, 6);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(560, 215);
            this.lvwMain.TabIndex = 1;
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.View = System.Windows.Forms.View.Details;
            this.lvwMain.SelectedIndexChanged += new System.EventHandler(this.lvwMain_SelectedIndexChanged);
            this.lvwMain.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwMain_ColumnWidthChanging);
            // 
            // colFoodOrderID
            // 
            this.colFoodOrderID.Text = "Order ID";
            this.colFoodOrderID.Width = 53;
            // 
            // colFoodDescription
            // 
            this.colFoodDescription.Text = "Description";
            this.colFoodDescription.Width = 178;
            // 
            // colMoneyAmount
            // 
            this.colMoneyAmount.Text = "Amount to Pay";
            this.colMoneyAmount.Width = 128;
            // 
            // colDateOrdered
            // 
            this.colDateOrdered.Text = "Date Ordered";
            this.colDateOrdered.Width = 100;
            // 
            // colPaidStatus
            // 
            this.colPaidStatus.Text = "Status";
            this.colPaidStatus.Width = 48;
            // 
            // colOrderedBy
            // 
            this.colOrderedBy.Text = "Ordered by";
            this.colOrderedBy.Width = 81;
            // 
            // colOrderType
            // 
            this.colOrderType.Text = "Type";
            this.colOrderType.Width = 80;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.grpOrders);
            this.tabDetails.Controls.Add(this.btnCancel);
            this.tabDetails.Controls.Add(this.btnSave);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(572, 297);
            this.tabDetails.TabIndex = 1;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.cboStatus);
            this.grpOrders.Controls.Add(this.txtAmountToPay);
            this.grpOrders.Controls.Add(this.lblType);
            this.grpOrders.Controls.Add(this.lblOrderedBy);
            this.grpOrders.Controls.Add(this.txtOrderedBy);
            this.grpOrders.Controls.Add(this.lblStatus);
            this.grpOrders.Controls.Add(this.lblDescription);
            this.grpOrders.Controls.Add(this.dtpDateOrdered);
            this.grpOrders.Controls.Add(this.txtDescription);
            this.grpOrders.Controls.Add(this.lblAmountToPay);
            this.grpOrders.Controls.Add(this.lblDateOrdered);
            this.grpOrders.Controls.Add(this.cboType);
            this.grpOrders.Location = new System.Drawing.Point(8, 6);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(556, 254);
            this.grpOrders.TabIndex = 9;
            this.grpOrders.TabStop = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Enabled = false;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Unpaid",
            "Paid"});
            this.cboStatus.Location = new System.Drawing.Point(106, 117);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(164, 21);
            this.cboStatus.TabIndex = 4;
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(106, 65);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.ReadOnly = true;
            this.txtAmountToPay.Size = new System.Drawing.Size(164, 20);
            this.txtAmountToPay.TabIndex = 2;
            this.txtAmountToPay.TextChanged += new System.EventHandler(this.txtAmountToPay_TextChanged);
            this.txtAmountToPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountToPay_KeyPress);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(361, 39);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lblOrderedBy
            // 
            this.lblOrderedBy.AutoSize = true;
            this.lblOrderedBy.Location = new System.Drawing.Point(6, 147);
            this.lblOrderedBy.Name = "lblOrderedBy";
            this.lblOrderedBy.Size = new System.Drawing.Size(60, 13);
            this.lblOrderedBy.TabIndex = 11;
            this.lblOrderedBy.Text = "Ordered By";
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.Location = new System.Drawing.Point(106, 144);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.ReadOnly = true;
            this.txtOrderedBy.Size = new System.Drawing.Size(164, 20);
            this.txtOrderedBy.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 42);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // dtpDateOrdered
            // 
            this.dtpDateOrdered.Enabled = false;
            this.dtpDateOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOrdered.Location = new System.Drawing.Point(106, 91);
            this.dtpDateOrdered.Name = "dtpDateOrdered";
            this.dtpDateOrdered.Size = new System.Drawing.Size(164, 20);
            this.dtpDateOrdered.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 39);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(164, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(6, 68);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(76, 13);
            this.lblAmountToPay.TabIndex = 2;
            this.lblAmountToPay.Text = "Amount to Pay";
            // 
            // lblDateOrdered
            // 
            this.lblDateOrdered.AutoSize = true;
            this.lblDateOrdered.Location = new System.Drawing.Point(6, 97);
            this.lblDateOrdered.Name = "lblDateOrdered";
            this.lblDateOrdered.Size = new System.Drawing.Size(68, 13);
            this.lblDateOrdered.TabIndex = 5;
            this.lblDateOrdered.Text = "DateOrdered";
            // 
            // cboType
            // 
            this.cboType.Enabled = false;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Partial Pay"});
            this.cboType.Location = new System.Drawing.Point(364, 68);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(164, 56);
            this.cboType.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(489, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(408, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 323);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Food Order App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            this.grpPayFilter.ResumeLayout(false);
            this.grpPayFilter.PerformLayout();
            this.tabDetails.ResumeLayout(false);
            this.grpOrders.ResumeLayout(false);
            this.grpOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.ColumnHeader colFoodOrderID;
        private System.Windows.Forms.ColumnHeader colFoodDescription;
        private System.Windows.Forms.ColumnHeader colMoneyAmount;
        private System.Windows.Forms.ColumnHeader colDateOrdered;
        private System.Windows.Forms.ColumnHeader colPaidStatus;
        private System.Windows.Forms.ColumnHeader colOrderedBy;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkUnpaid;
        private System.Windows.Forms.GroupBox grpPayFilter;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.ColumnHeader colOrderType;
        public System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.ListBox cboType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDateOrdered;
        private System.Windows.Forms.DateTimePicker dtpDateOrdered;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblOrderedBy;
        private System.Windows.Forms.TextBox txtOrderedBy;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}

