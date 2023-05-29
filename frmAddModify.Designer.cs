namespace MMABooks.EF
{
    partial class frmAddModify
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
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtZIPCode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            txtCity = new TextBox();
            cbState = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 136);
            label6.Name = "label6";
            label6.Size = new Size(103, 32);
            label6.TabIndex = 32;
            label6.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(302, 134);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(407, 39);
            txtAddress.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 257);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 30;
            label5.Text = "ZIP Code:";
            // 
            // txtZIPCode
            // 
            txtZIPCode.BorderStyle = BorderStyle.FixedSingle;
            txtZIPCode.Location = new Point(573, 254);
            txtZIPCode.Name = "txtZIPCode";
            txtZIPCode.Size = new Size(136, 39);
            txtZIPCode.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 257);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 28;
            label3.Text = "State:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 196);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 27;
            label2.Text = "City:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 75);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 26;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(302, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(407, 39);
            txtName.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(403, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(247, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(302, 194);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(407, 39);
            txtCity.TabIndex = 2;
            // 
            // cbState
            // 
            cbState.FormattingEnabled = true;
            cbState.Location = new Point(302, 254);
            cbState.Name = "cbState";
            cbState.Size = new Size(144, 40);
            cbState.TabIndex = 3;
            // 
            // frmAddModify
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(cbState);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtZIPCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtCity);
            Name = "frmAddModify";
            Text = "frmAddModify";
            Load += frmAddModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtZIPCode;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtCity;
        private ComboBox cbState;
    }
}