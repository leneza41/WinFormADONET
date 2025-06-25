using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinFormADONET.data;

namespace WinFormADONET
{
    public partial class NewCustomer : Form
    {
        private int parsedCustomerID;
        private int orderID;

        private bool IsCustomerNameValid()
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsOrderDataValid()
        {
            // Verify that CustomerID is present.
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please create customer account before placing or‐der.");
                return false;
            }
            else if ((numOrderAmount.Value < 1))
            {
                MessageBox.Show("Please specify an order amount.");
                return false;
            }
            else
            {
                // Order can be submitted.
                return true;
            }
        }
        /// <summary>
        /// Clears the form data.
        /// </summary>
        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtCustomerID.Clear();
            dtpOrderDate.Value = DateTime.Now;
            numOrderAmount.Value = 0;
            this.parsedCustomerID = 0;
        }
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsCustomerNameValid())
            {
                string procedureCall = "CALL uspNewCustomer(@CustomerName, @ignoredOutputParam);";
                
                using (AccesoDatosMySql connection = new AccesoDatosMySql("localhost", "Sales",
                    "root", "toor", 3306))
                {
                    var parametros = new Dictionary<string, object>
                    {
                        { "@CustomerName", txtCustomerName.Text },
                        { "@ignoredOutputParam", DBNull.Value }
                    };

                    try
                    {
                        using (var reader = connection.ejecutarQuery(procedureCall, parametros))
                        {
                            if (reader.Read())
                            {
                                this.parsedCustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID"));
                                this.txtCustomerID.Text = parsedCustomerID.ToString();
                                MessageBox.Show("Customer created successfully! Customer ID: " + parsedCustomerID);
                            }
                            else
                            {
                                MessageBox.Show("Customer ID was not returned. Account could not be created.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderDataValid())
            {
                string procedureCall = "CALL uspPlaceNewOrder(@CustomerID, @Amount, @OrderDate, @Status);";

                using (AccesoDatosMySql connection = new AccesoDatosMySql("localhost", "Sales",
                "root", "toor", 3306))
                {
                    var parametros = new Dictionary<string, object>
                    {
                        { "@CustomerID", this.parsedCustomerID },
                        { "@OrderDate", dtpOrderDate.Value },
                        { "@Amount", Convert.ToInt32(numOrderAmount.Value) },
                        { "@Status", "O" }
                    };

                    try
                    {
                        using (var reader = connection.ejecutarQuery(procedureCall, parametros))
                        {
                            if (reader.Read())
                            {
                                this.orderID = reader.GetInt32(0);
                                MessageBox.Show("Order number " + this.orderID + " has been submitted.");
                            }
                            else
                            {
                                MessageBox.Show("Order ID was not returned. Order could not be placed.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Order could not be placed.\n" + ex.Message);
                    }
                }
            }
        }

        private void btnAddAnotherAccount_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
