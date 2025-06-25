using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using MySqlX.XDevAPI.Relational;
using Mysqlx.Crud;
using WinFormADONET.data;
using System.Diagnostics;

namespace WinFormADONET
{
    public partial class FillOrCancel : Form
    {
        private int parsedOrderID;
        /// <summary>
        /// Verifies that an order ID is present and contains valid characters.
        /// </summary>
        private bool IsOrderIDValid()
        {
            // Check for input in the Order ID text box.
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Please specify the Order ID.");
                return false;
            }
            // Check for characters other than integers.
            else if (Regex.IsMatch(txtOrderID.Text, @"^\D*$"))
            {
                // Show message and clear input.
                MessageBox.Show("Customer ID must contain only numbers.");
                txtOrderID.Clear();
                return false;
            }
            else
            {
                // Convert the text in the text box to an integer to send to the database.
                parsedOrderID = Int32.Parse(txtOrderID.Text);
                return true;
            }
        }

        public FillOrCancel()
        {
            InitializeComponent();
        }

        private void btnFindByOrderID_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                try
                {
                    const string sql = "SELECT * FROM Orders WHERE OrderID = @orderID";

                    var parametros = new Dictionary<string, object>
                    {
                        { "@orderID", parsedOrderID }
                    };

                    using (var connection = new AccesoDatosMySql("localhost", "Sales", "root", "toor", 3306))
                    {
                        DataTable dataTable = connection.queryTable(sql, parametros);
                        this.dgvCustomerOrders.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The requested order could not be loaded into the form.\n" + ex.Message);
                }
            }

        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                try
                {
                    const string procedureCall = "CALL uspCancelOrder(@orderID);";
                    var parametros = new Dictionary<string, object>
                    {
                        { "@orderID", parsedOrderID }
                    };

                    using (var connection = new AccesoDatosMySql("localhost", "Sales", "root", "toor", 3306))
                    {
                        connection.ejecutarSentencia(procedureCall, parametros);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The cancel operation was not completed.\n" + ex.Message);
                }
            }
            else
            {
                Debug.WriteLine("No es valido");
            }

        }

        private void btnFillOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                try
                {
                    const string procedureCall = "CALL uspFillOrder(@orderID, @FilledDate);";

                    var parametros = new Dictionary<string, object>
                    {
                        { "@orderID", parsedOrderID },
                        { "@FilledDate", dtpFillDate.Value }
                    };

                    using (var connection = new AccesoDatosMySql("localhost", "Sales", "root", "toor", 3306))
                    {
                        connection.ejecutarSentencia(procedureCall, parametros);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The fill operation was not completed.\n" + ex.Message);
                }
            }
            else
            {
                Debug.WriteLine("No es valido");
            }

        }

        private void btnFinishUpdates_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
