namespace MMABooks.EF
{
    partial class Form1
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
            txtCustID = new TextBox();
            outputCity = new TextBox();
            btnGetCustomer = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            outputName = new TextBox();
            outputState = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            outputZIPCode = new TextBox();
            label5 = new Label();
            label6 = new Label();
            outputAddress = new TextBox();
            SuspendLayout();
            // 
            // txtCustID
            // 
            txtCustID.Location = new Point(302, 77);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(115, 39);
            txtCustID.TabIndex = 0;
            // 
            // outputCity
            // 
            outputCity.BorderStyle = BorderStyle.FixedSingle;
            outputCity.Location = new Point(302, 262);
            outputCity.Name = "outputCity";
            outputCity.ReadOnly = true;
            outputCity.Size = new Size(407, 39);
            outputCity.TabIndex = 2;
            // 
            // btnGetCustomer
            // 
            btnGetCustomer.Location = new Point(438, 73);
            btnGetCustomer.Name = "btnGetCustomer";
            btnGetCustomer.Size = new Size(271, 46);
            btnGetCustomer.TabIndex = 4;
            btnGetCustomer.Text = "Get Customer";
            btnGetCustomer.UseVisualStyleBackColor = true;
            btnGetCustomer.Click += btnGetCustomer_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(91, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(247, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(559, 399);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // outputName
            // 
            outputName.BorderStyle = BorderStyle.FixedSingle;
            outputName.Location = new Point(302, 141);
            outputName.Name = "outputName";
            outputName.ReadOnly = true;
            outputName.Size = new Size(407, 39);
            outputName.TabIndex = 9;
            // 
            // outputState
            // 
            outputState.BorderStyle = BorderStyle.FixedSingle;
            outputState.Location = new Point(302, 322);
            outputState.Name = "outputState";
            outputState.ReadOnly = true;
            outputState.Size = new Size(136, 39);
            outputState.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 143);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 269);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 12;
            label2.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 332);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 13;
            label3.Text = "State:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 80);
            label4.Name = "label4";
            label4.Size = new Size(152, 32);
            label4.TabIndex = 14;
            label4.Text = "Customer ID:";
            // 
            // outputZIPCode
            // 
            outputZIPCode.BorderStyle = BorderStyle.FixedSingle;
            outputZIPCode.Location = new Point(573, 322);
            outputZIPCode.Name = "outputZIPCode";
            outputZIPCode.ReadOnly = true;
            outputZIPCode.Size = new Size(136, 39);
            outputZIPCode.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 325);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 16;
            label5.Text = "ZIP Code:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 206);
            label6.Name = "label6";
            label6.Size = new Size(103, 32);
            label6.TabIndex = 18;
            label6.Text = "Address:";
            // 
            // outputAddress
            // 
            outputAddress.BorderStyle = BorderStyle.FixedSingle;
            outputAddress.Location = new Point(302, 202);
            outputAddress.Name = "outputAddress";
            outputAddress.ReadOnly = true;
            outputAddress.Size = new Size(407, 39);
            outputAddress.TabIndex = 17;
            // 
            // Form1
            // 
            AcceptButton = btnGetCustomer;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 518);
            Controls.Add(label6);
            Controls.Add(outputAddress);
            Controls.Add(label5);
            Controls.Add(outputZIPCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputState);
            Controls.Add(outputName);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnGetCustomer);
            Controls.Add(outputCity);
            Controls.Add(txtCustID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustID;
        private TextBox outputCity;
        private Button btnGetCustomer;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnExit;
        private TextBox outputName;
        private TextBox outputState;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox outputZIPCode;
        private Label label5;
        private Label label6;
        private TextBox outputAddress;
    }
}