namespace FINALPROJECTCSC323


{
    partial class RESTAURANTMENUUI
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
            btnClose = new Button();
            cmbCategory = new ComboBox();
            cmbMenuItem = new ComboBox();
            upDownQuantity = new DomainUpDown();
            btnAdd = new Button();
            flowCartItems = new FlowLayoutPanel();
            lblTotal = new Label();
            btnPlaceOrder = new Button();
            pnlConfirmOrder = new Panel();
            btnBack = new Button();
            label5 = new Label();
            btnConfirmOrder = new Button();
            label4 = new Label();
            cmbNotification = new ComboBox();
            cmbPaymentMethod = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbDiscount = new ComboBox();
            lblDiscountedTotal = new Label();
            cmbdelivery = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            pnlConfirmOrder.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(1807, 675);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(64, 44);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(253, 28);
            cmbCategory.TabIndex = 1;
            // 
            // cmbMenuItem
            // 
            cmbMenuItem.FormattingEnabled = true;
            cmbMenuItem.Location = new Point(357, 44);
            cmbMenuItem.Name = "cmbMenuItem";
            cmbMenuItem.Size = new Size(215, 28);
            cmbMenuItem.TabIndex = 2;
            cmbMenuItem.SelectedIndexChanged += cmbMenuItem_SelectedIndexChanged;
            // 
            // upDownQuantity
            // 
            upDownQuantity.Items.Add("1");
            upDownQuantity.Items.Add("2");
            upDownQuantity.Items.Add("3");
            upDownQuantity.Items.Add("4");
            upDownQuantity.Items.Add("5");
            upDownQuantity.Items.Add("6");
            upDownQuantity.Items.Add("7");
            upDownQuantity.Items.Add("8");
            upDownQuantity.Items.Add("9");
            upDownQuantity.Items.Add("10");
            upDownQuantity.Location = new Point(630, 45);
            upDownQuantity.Name = "upDownQuantity";
            upDownQuantity.ReadOnly = true;
            upDownQuantity.Size = new Size(75, 27);
            upDownQuantity.TabIndex = 3;
            upDownQuantity.Text = "1";
            upDownQuantity.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(774, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD TO CART";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flowCartItems
            // 
            flowCartItems.AutoScroll = true;
            flowCartItems.FlowDirection = FlowDirection.TopDown;
            flowCartItems.Location = new Point(64, 115);
            flowCartItems.Name = "flowCartItems";
            flowCartItems.Size = new Size(1201, 374);
            flowCartItems.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(66, 596);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Click += label1_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(965, 45);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(152, 39);
            btnPlaceOrder.TabIndex = 7;
            btnPlaceOrder.Text = "PLACE ORDER";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // pnlConfirmOrder
            // 
            pnlConfirmOrder.Controls.Add(label6);
            pnlConfirmOrder.Controls.Add(cmbdelivery);
            pnlConfirmOrder.Controls.Add(btnBack);
            pnlConfirmOrder.Controls.Add(label5);
            pnlConfirmOrder.Controls.Add(btnConfirmOrder);
            pnlConfirmOrder.Controls.Add(label4);
            pnlConfirmOrder.Controls.Add(cmbNotification);
            pnlConfirmOrder.Controls.Add(cmbPaymentMethod);
            pnlConfirmOrder.Location = new Point(1146, 5);
            pnlConfirmOrder.Name = "pnlConfirmOrder";
            pnlConfirmOrder.Size = new Size(755, 104);
            pnlConfirmOrder.TabIndex = 8;
            pnlConfirmOrder.Paint += panel1_Paint;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(596, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 28);
            btnBack.TabIndex = 13;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 26);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 12;
            label5.Text = "CHOOSE NOTIFICATION";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(596, 50);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(139, 29);
            btnConfirmOrder.TabIndex = 2;
            btnConfirmOrder.Text = "CONFIRM";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 26);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "CHOOSE PAYMENT";
            label4.Click += label4_Click;
            // 
            // cmbNotification
            // 
            cmbNotification.FormattingEnabled = true;
            cmbNotification.Location = new Point(208, 51);
            cmbNotification.Name = "cmbNotification";
            cmbNotification.Size = new Size(160, 28);
            cmbNotification.TabIndex = 1;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(22, 51);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(160, 28);
            cmbPaymentMethod.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 14);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 9;
            label1.Text = "CHOOSE A CATEGORY";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 14);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 10;
            label2.Text = "CHOOSE AN ITEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(630, 14);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 11;
            label3.Text = "QTY";
            // 
            // cmbDiscount
            // 
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Location = new Point(421, 588);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(151, 28);
            cmbDiscount.TabIndex = 12;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // lblDiscountedTotal
            // 
            lblDiscountedTotal.AutoSize = true;
            lblDiscountedTotal.Location = new Point(64, 650);
            lblDiscountedTotal.Name = "lblDiscountedTotal";
            lblDiscountedTotal.Size = new Size(0, 20);
            lblDiscountedTotal.TabIndex = 13;
            // 
            // cmbdelivery
            // 
            cmbdelivery.FormattingEnabled = true;
            cmbdelivery.Location = new Point(394, 51);
            cmbdelivery.Name = "cmbdelivery";
            cmbdelivery.Size = new Size(160, 28);
            cmbdelivery.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 26);
            label6.Name = "label6";
            label6.Size = new Size(201, 20);
            label6.TabIndex = 15;
            label6.Text = "CHOOSE DELIVERY METHOD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 553);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 14;
            label7.Text = "CHOOSE DISCOUNT";
            // 
            // RESTAURANTMENUUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 726);
            Controls.Add(label7);
            Controls.Add(lblDiscountedTotal);
            Controls.Add(cmbDiscount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlConfirmOrder);
            Controls.Add(btnPlaceOrder);
            Controls.Add(lblTotal);
            Controls.Add(flowCartItems);
            Controls.Add(btnAdd);
            Controls.Add(upDownQuantity);
            Controls.Add(cmbMenuItem);
            Controls.Add(cmbCategory);
            Controls.Add(btnClose);
            Name = "RESTAURANTMENUUI";
            Text = "RESTAURANTMENUUI";
            Load += RESTAURANTMENUUI_Load;
            pnlConfirmOrder.ResumeLayout(false);
            pnlConfirmOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private ComboBox cmbCategory;
        private ComboBox cmbMenuItem;
        private DomainUpDown upDownQuantity;
        private Button btnAdd;
        private FlowLayoutPanel flowCartItems;
        private Label lblTotal;
        private Button btnPlaceOrder;
        private Panel pnlConfirmOrder;
        private Button btnConfirmOrder;
        private ComboBox cmbNotification;
        private ComboBox cmbPaymentMethod;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbDiscount;
        private Label lblDiscountedTotal;
        private Button btnBack;
        private Label label6;
        private ComboBox cmbdelivery;
        private Label label7;
    }
}