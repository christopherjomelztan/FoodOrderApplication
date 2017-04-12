using System.Data.SqlServerCe;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace FoodOrderApplicationv1._0.Classes
{
    class FunctionRepository
    {
        //Global variables
        public static string mode = "";
        public static string orderID = "";

        //When all partial payments are complete, change all unpaid orders to paid and change all partial pay to complete
        public static void CompletePayment()
        {
            string command = "Update FoodOrderTable set PaidStatus = 1";
            FunctionRepository.Command(command).ExecuteNonQuery();
            command = "Update FoodOrderTable set OrderType = 4 where OrderType = 3";
            FunctionRepository.Command(command).ExecuteNonQuery();
            MessageBox.Show("Completely paid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //To make sure amount to pay accepts numbers only
        public static void NumberKeyPress(object sender, KeyPressEventArgs e, TextBox txtBox)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(txtBox.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //Execute SQL commands
        public static SqlCeCommand Command(string query)
        {
            SqlCeConnection connection = new SqlCeConnection();
            connection.ConnectionString = @"Data Source=D:\Christopher\My Files\Personal Database\CTanPersonalDatabase.sdf; Persist Security Info=False;";
            connection.Open();
            SqlCeCommand command = new SqlCeCommand(query);
            command.Connection = connection;
            command.CommandTimeout = 0;
            return command;
        }

        //For displaying all fields from selected record
        public static SqlCeDataReader DisplayDetails(string orderId)
        {
            string command = "select top (1) * from FoodOrderTable where FoodOrderID = " + orderId;
            SqlCeDataReader drMain = FunctionRepository.Command(command).ExecuteReader();
            return drMain;
        }

        public static void DeleteOrder(string orderID)
        {
            string command = "Delete from FoodOrderTable where FoodOrderID = " + orderID;

            try
            {
                FunctionRepository.Command(command).ExecuteNonQuery();
                MessageBox.Show("Order has been deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "SQL Query Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void EditOrder(string orderID, string foodDescription, string moneyAmount, string orderType, string dateOrdered)
        {
            orderType = (Convert.ToInt32(orderType) + 1).ToString();
            string command = "Update FoodOrderTable set FoodDescription = '" + foodDescription + "', MoneyAmount = " + moneyAmount + ", OrderType = " + orderType + ", DateOrdered = '" + dateOrdered + "'" +
                " where FoodOrderID = " + orderID;
            
            try
            {
                FunctionRepository.Command(command).ExecuteNonQuery();
                MessageBox.Show("Order has been edited successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "SQL Query Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
        }

        //Record insertion
        public static void InsertOrder(string foodDescription, string moneyAmount, string orderType, string dateOrdered, string paidStatus)
        {  
            string command = "Select top (1) FoodOrderID + 1 as NewID from FoodOrderTable order by FoodOrderID desc";
            string newID = "0";
            SqlCeDataReader drID = FunctionRepository.Command(command).ExecuteReader();
            while (drID.Read())
            {
                newID = drID["NewID"].ToString();
            }
            orderType = (Convert.ToInt32(orderType) + 1).ToString();

            string command2 = "Insert into FoodOrderTable (FoodOrderID, FoodDescription, MoneyAmount, DateOrdered, PaidStatus, OrderedBy,OrderType)";
            command2 = command2 + " Values(" + newID + ", '" + foodDescription + "', " + moneyAmount + 
                ", '" + dateOrdered + "', '" + paidStatus + "', '" + Environment.UserName + "', '" + orderType + "')";

            try
            {
                FunctionRepository.Command(command2).ExecuteNonQuery();
                MessageBox.Show("Order has been added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(),"SQL Query Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }  
        }

        //Convert PaidStatus int to value
        public static string PaidStatus(string paidStatus)
        {
            if (paidStatus == "True")
                return "Paid";
            else if (paidStatus == "False")
                return "Unpaid";
            else
                return "Invalid Status";
        }

        //Convert OrderType int to value
        public static string OrderType(string orderType)
        {
            if (orderType == "1")
                return "Breakfast";
            else if (orderType == "2")
                return "Lunch";
            else if (orderType == "3")
                return "Partial Pay";
            else if (orderType == "4")
                return "Completed Pay";
            else
                return "Invalid Status";
        }

        //For locking tab columns
        public static void LockColumnWidth(ColumnWidthChangingEventArgs e, int _lockColumnIndex, int columnWidth)
        {
            if (e.ColumnIndex == _lockColumnIndex)
            {
                //Keep the width not changed.
                e.NewWidth = columnWidth;
                //Cancel the event.
                e.Cancel = true;
            }
        }

        //For refreshing listview contents
        public static void refreshList(frmMain sender)
        {
            sender.lvwMain.Items.Clear();
            string command = "select * from FoodOrderTable order by FoodOrderID";
            frmMain frmMain = new frmMain();

            try
            {
                SqlCeDataReader drMain = FunctionRepository.Command(command).ExecuteReader();

                while (drMain.Read())
                {
                    ListViewItem listitem = new ListViewItem(drMain["FoodOrderID"].ToString());
                    listitem.SubItems.Add(drMain["FoodDescription"].ToString());
                    decimal moneyAmount = 0;
                    decimal.TryParse(drMain["MoneyAmount"].ToString(), out moneyAmount);
                    listitem.SubItems.Add(moneyAmount.ToString("0.00"));
                    listitem.SubItems.Add(drMain["DateOrdered"].ToString());
                    listitem.SubItems.Add(FunctionRepository.PaidStatus(drMain["PaidStatus"].ToString()));
                    listitem.SubItems.Add(drMain["OrderedBy"].ToString());
                    listitem.SubItems.Add(FunctionRepository.OrderType(drMain["OrderType"].ToString()));
                    sender.lvwMain.Items.Add(listitem);
                    sender.Refresh();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "SQL Query Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        //For refreshing listview contents w/ filter
        public static void refreshList(frmMain sender,int paid, int unpaid)
        {
            string command = "";
            sender.lvwMain.Items.Clear();
            if (paid == 1 && unpaid == 0)
            {
                command = "select * from FoodOrderTable where PaidStatus = 1 order by FoodOrderID";
            }
            else if (paid == 0 && unpaid == 1)
            {
                command = "select * from FoodOrderTable where PaidStatus = 0 order by FoodOrderID";
            }
            else
            {
                command = "select * from FoodOrderTable order by FoodOrderID";
            }
            frmMain frmMain = new frmMain();

            try
            {
                SqlCeDataReader drMain = FunctionRepository.Command(command).ExecuteReader();

                while (drMain.Read())
                {
                    ListViewItem listitem = new ListViewItem(drMain["FoodOrderID"].ToString());
                    listitem.SubItems.Add(drMain["FoodDescription"].ToString());
                    decimal moneyAmount = 0;
                    decimal.TryParse(drMain["MoneyAmount"].ToString(), out moneyAmount);
                    listitem.SubItems.Add(moneyAmount.ToString("0.00"));
                    listitem.SubItems.Add(drMain["DateOrdered"].ToString());
                    listitem.SubItems.Add(FunctionRepository.PaidStatus(drMain["PaidStatus"].ToString()));
                    listitem.SubItems.Add(drMain["OrderedBy"].ToString());
                    listitem.SubItems.Add(FunctionRepository.OrderType(drMain["OrderType"].ToString()));
                    sender.lvwMain.Items.Add(listitem);
                    sender.Refresh();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "SQL Query Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //Compute total amount to pay
        public static decimal totalAmount()
        {
            string command = "select sum(MoneyAmount) as totalAmount from FoodOrderTable where PaidStatus = 0";
            string commandManualPayment = "select sum(MoneyAmount) as totalAmount from FoodOrderTable where OrderType = 3";
            decimal totalAmount = 0;
            decimal totalManualAdjustment = 0;
            frmMain frmMain = new frmMain();

            SqlCeDataReader drMain = FunctionRepository.Command(command).ExecuteReader();
            while (drMain.Read())
            {
                decimal.TryParse(drMain["totalAmount"].ToString(), out totalAmount);
            }
         

            SqlCeDataReader drManualPayment = FunctionRepository.Command(commandManualPayment).ExecuteReader();
            while (drManualPayment.Read())
            {
                decimal.TryParse(drManualPayment["totalAmount"].ToString(), out totalManualAdjustment);
            }

            if (totalAmount + totalManualAdjustment < 0)
                totalAmount = 0;
            else
                totalAmount = totalAmount + totalManualAdjustment;

            return totalAmount;
            
        }
    }
}
