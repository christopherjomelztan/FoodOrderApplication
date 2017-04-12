// =============================================
// Author:		Christopher Jomel Z. Tan
// Create date: March 29, 2016
// Description: Food order organizer. Side project only
// =============================================

using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using FoodOrderApplicationv1._0.Classes;

namespace FoodOrderApplicationv1._0
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Display details of selected list view item
        private void DisplayDetails(string orderId, SqlCeDataReader drMain)
        {
            while (drMain.Read())
            {
                grpOrders.Text = "Order ID: " + orderId;
                txtDescription.Text = drMain["FoodDescription"].ToString();
                decimal moneyAmount = 0;
                decimal.TryParse(drMain["MoneyAmount"].ToString(), out moneyAmount);
                txtAmountToPay.Text = moneyAmount.ToString("0.00");
                dtpDateOrdered.Value = Convert.ToDateTime(drMain["DateOrdered"].ToString());
                if (drMain["PaidStatus"].ToString() == "True")
                    cboStatus.SelectedIndex = 1;
                else if (drMain["PaidStatus"].ToString() == "False")
                    cboStatus.SelectedIndex = 0;

                txtOrderedBy.Text = drMain["OrderedBy"].ToString();

                if (drMain["OrderType"].ToString() == "1")
                    cboType.SelectedIndex = 0;
                else if (drMain["OrderType"].ToString() == "2")
                    cboType.SelectedIndex = 1;
                else if (drMain["OrderType"].ToString() == "3")
                    cboType.SelectedIndex = 2;
            }
        }

        private void EditOrderClear()
        {
            txtDescription.ReadOnly = false;
            txtAmountToPay.ReadOnly = false;
            dtpDateOrdered.Enabled = true;
            cboType.Enabled = true;
            grpOrders.Text = "Edit order";
            cboType.Enabled = true;
            tabMain.SelectedIndex = 1;
            txtDescription.Focus();
        }

        //Ready fields for adding new order
        private void AddOrderClear()
        {
            txtDescription.Clear();
            txtDescription.ReadOnly = false;
            txtAmountToPay.Clear();
            txtAmountToPay.ReadOnly = false;
            dtpDateOrdered.Value = DateTime.Now;
            dtpDateOrdered.Enabled = true;
            cboType.Enabled = true;
            cboType.ClearSelected();
            grpOrders.Text = "New order entry";
            cboStatus.Enabled = true;
            cboStatus.SelectedIndex = 0;
            txtOrderedBy.Text = Environment.UserName;
            cboType.Enabled = true;
            tabMain.SelectedIndex = 1;
            txtDescription.Focus();
            chkPaid.Checked = false;
            chkUnpaid.Checked = false;
        }

        //Disable fields after saving new order
        private void OrderSaved()
        {
            grpOrders.Text = "";
            txtDescription.Clear();
            txtDescription.ReadOnly = true;
            txtAmountToPay.Clear();
            txtAmountToPay.ReadOnly = true;
            dtpDateOrdered.Value = DateTime.Now;
            dtpDateOrdered.Enabled = false;
            cboType.Enabled = false;
            cboStatus.Text = "";
            txtOrderedBy.Clear();
            cboType.Enabled = false;
            tabMain.SelectedIndex = 0;
        }

        private void totalAmount()
        {
            lblTotal.Text = "Total Amount to Pay: Php " + FunctionRepository.totalAmount().ToString("0.00");
        }

        private void lvwMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderId = "";
            if (lvwMain.SelectedItems.Count > 0)
            {
                orderId = lvwMain.SelectedItems[0].Text;
                SqlCeDataReader drMain = FunctionRepository.DisplayDetails(orderId);
                DisplayDetails(orderId, drMain);
            }
        }

        private void lvwMain_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FunctionRepository.mode = "A";
            AddOrderClear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FunctionRepository.refreshList(this);
            totalAmount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FunctionRepository.mode == "A")
            {
                if (cboType.SelectedItems.Count > 0)
                {
                    if (txtAmountToPay.Text == string.Empty)
                    {
                        MessageBox.Show("Please input amount first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FunctionRepository.InsertOrder(txtDescription.Text, txtAmountToPay.Text, cboType.SelectedIndex.ToString(), dtpDateOrdered.Value.ToString(), cboStatus.SelectedIndex.ToString());
                    OrderSaved();
                    FunctionRepository.refreshList(this);
                    totalAmount();
                    if (FunctionRepository.totalAmount() == 0)
                    {
                        FunctionRepository.CompletePayment();
                        FunctionRepository.refreshList(this);
                    }

                }
                else
                    MessageBox.Show("No order type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (FunctionRepository.mode == "E")
            {
                if (cboType.SelectedItems.Count > 0)
                {
                    string orderID = "";

                    if (lvwMain.SelectedItems.Count > 0)
                        orderID = lvwMain.SelectedItems[0].Text; 

                    FunctionRepository.EditOrder(orderID,txtDescription.Text, txtAmountToPay.Text, cboType.SelectedIndex.ToString(), dtpDateOrdered.Value.ToString());
                    OrderSaved();
                    FunctionRepository.refreshList(this);
                    totalAmount();
                    if (FunctionRepository.totalAmount() == 0)
                    {
                        FunctionRepository.CompletePayment();
                        FunctionRepository.refreshList(this);
                    }

                }
                else
                    MessageBox.Show("No order type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No mode error");
            }
            
        }

        private void txtAmountToPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = new TextBox();
            txtBox = txtAmountToPay;
            FunctionRepository.NumberKeyPress(sender, e, txtBox);
        }

        private void chkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaid.Checked == true && chkUnpaid.Checked == true)
            {
                FunctionRepository.refreshList(this);
            }
            else if (chkPaid.Checked == true && chkUnpaid.Checked == false) 
            {
                FunctionRepository.refreshList(this,1,0);
            }
            else if (chkPaid.Checked == false && chkUnpaid.Checked == true)
            {
                FunctionRepository.refreshList(this, 0, 1);
            }
            else
            {
                FunctionRepository.refreshList(this);
            }
        }

        private void chkUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaid.Checked == true && chkUnpaid.Checked == true)
            {
                FunctionRepository.refreshList(this);
            }
            else if (chkPaid.Checked == false && chkUnpaid.Checked == true)
            {
                FunctionRepository.refreshList(this, 0, 1);
            }
            else if (chkPaid.Checked == true && chkUnpaid.Checked == false)
            {
                FunctionRepository.refreshList(this, 1, 0);
            }
            else
            {
                FunctionRepository.refreshList(this);
            }
        }

        private void txtAmountToPay_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (lvwMain.SelectedItems.Count > 0)
            {
                FunctionRepository.mode = "E";
                EditOrderClear();
            }
            else
            {
                MessageBox.Show("Select item to edit first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string orderID = "";
                if (lvwMain.SelectedItems.Count > 0)
                    orderID = lvwMain.SelectedItems[0].Text;
                FunctionRepository.DeleteOrder(orderID);
                FunctionRepository.refreshList(this);
                totalAmount();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Delete cancelled.");
            }
            

        }
    }
}
