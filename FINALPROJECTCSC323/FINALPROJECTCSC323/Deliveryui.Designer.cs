namespace FINALPROJECTCSC323
{
    partial class Deliveryui
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
            components = new System.ComponentModel.Container();
            lblStatus = new Label();
            timerDelivery = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(324, 155);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(178, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Order is being delivered...";
            // 
            // timerDelivery
            // 
            timerDelivery.Enabled = true;
            timerDelivery.Interval = 3000;
            timerDelivery.Tick += timerDelivery_Tick;
            // 
            // Deliveryui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Name = "Deliveryui";
            Text = "Deliveryui";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private System.Windows.Forms.Timer timerDelivery;
    }
}