namespace WinFormADONET
{
    partial class NewCustomer
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
            groupBox1 = new GroupBox();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCreateAccount = new Button();
            btnPlaceOrder = new Button();
            groupBox2 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            numOrderAmount = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnAddFinish = new Button();
            btnAddAnotherAccount = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar cuenta";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(203, 59);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(256, 27);
            txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(203, 23);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(256, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 66);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 1;
            label2.Text = "Identificador del Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(574, 110);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(187, 48);
            btnCreateAccount.TabIndex = 4;
            btnCreateAccount.Text = "Crear Cuenta";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(574, 245);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(187, 48);
            btnPlaceOrder.TabIndex = 6;
            btnPlaceOrder.Text = "Realizar pedido";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(31, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(482, 135);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear pedido";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(203, 61);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(256, 27);
            dtpOrderDate.TabIndex = 5;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(203, 21);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(256, 27);
            numOrderAmount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 66);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 1;
            label3.Text = "Fecha del pedido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 23);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 0;
            label4.Text = "Cantidad de pedido:";
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(22, 356);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(187, 48);
            btnAddFinish.TabIndex = 7;
            btnAddFinish.Text = "Finalizar";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(326, 356);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(187, 48);
            btnAddAnotherAccount.TabIndex = 8;
            btnAddAnotherAccount.Text = "Agregar otra cuenta";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnAddFinish);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox1);
            Name = "NewCustomer";
            Text = "Navegacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Button btnCreateAccount;
        private Button btnPlaceOrder;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button btnAddFinish;
        private Button btnAddAnotherAccount;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
    }
}