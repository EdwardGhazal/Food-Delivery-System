namespace FINALPROJECTCSC323
{
    partial class ProfileUI
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lstOrders = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(47, 42);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(50, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "label1";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(47, 96);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(50, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "label2";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(47, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label3";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(47, 203);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "label4";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(47, 252);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(50, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "label1";
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(47, 315);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(244, 104);
            lstOrders.TabIndex = 5;
            lstOrders.Click += lstOrders_Click;
            lstOrders.MouseClick += lstOrders_MouseClick;
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 289);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 6;
            label1.Text = "ORDERS";
            // 
            // ProfileUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lstOrders);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "ProfileUI";
            Text = "Profile";
            Load += ProfileUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private ListBox lstOrders;
        private Label label1;
    }
}