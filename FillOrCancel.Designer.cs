namespace WinFormADONET
{
    partial class FillOrCancel
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
            label1 = new Label();
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            label2 = new Label();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 0;
            label1.Text = "Identificador de pedido:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(284, 52);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(277, 27);
            txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(589, 50);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(148, 29);
            btnFindByOrderID.TabIndex = 2;
            btnFindByOrderID.Text = "Buscar pedido";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 123);
            label2.Name = "label2";
            label2.Size = new Size(524, 28);
            label2.TabIndex = 3;
            label2.Text = "Si esta rellenando un pedido, especifique la fecha rellenada";
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(589, 123);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(148, 27);
            dtpFillDate.TabIndex = 4;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(33, 194);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.Size = new Size(704, 188);
            dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(33, 409);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(154, 58);
            btnCancelOrder.TabIndex = 6;
            btnCancelOrder.Text = "Cancelar Pedido";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(299, 409);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(170, 58);
            btnFillOrder.TabIndex = 7;
            btnFillOrder.Text = "Rellenar Pedido";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(563, 409);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(174, 58);
            btnFinishUpdates.TabIndex = 8;
            btnFinishUpdates.Text = "Finalizar";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            btnFinishUpdates.Click += btnFinishUpdates_Click;
            // 
            // FillOrCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(label2);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label1);
            Name = "FillOrCancel";
            Text = "FillOrCancel";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Label label2;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
    }
}