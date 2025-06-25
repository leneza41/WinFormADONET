namespace WinFormADONET
{
    partial class Navigation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGoToAdd = new Button();
            btnGoToFillOrCancel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(151, 65);
            label1.Name = "label1";
            label1.Size = new Size(273, 41);
            label1.TabIndex = 0;
            label1.Text = "¿Qué desea hacer?";
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(46, 157);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(241, 48);
            btnGoToAdd.TabIndex = 1;
            btnGoToAdd.Text = "Agregar una cuenta";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += button1_Click;
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(343, 157);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(244, 48);
            btnGoToFillOrCancel.TabIndex = 2;
            btnGoToFillOrCancel.Text = "Rellenar o cancelar un pedido";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(467, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 44);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Navigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnGoToFillOrCancel);
            Controls.Add(btnGoToAdd);
            Controls.Add(label1);
            Name = "Navigation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGoToAdd;
        private Button btnGoToFillOrCancel;
        private Button btnExit;
    }
}
