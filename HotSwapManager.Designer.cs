namespace QEMUManager
{
    partial class HotSwapManager : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cdromPath = new TextBox();
            usbPath = new TextBox();
            btnAttachCD = new Button();
            btnAttachUSB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 16);
            label1.TabIndex = 0;
            label1.Text = "CD-ROM (ISO) 路径:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 1;
            label2.Text = "USB 设备路径:";
            // 
            // cdromPath
            // 
            cdromPath.Location = new Point(173, 3);
            cdromPath.Name = "cdromPath";
            cdromPath.Size = new Size(260, 22);
            cdromPath.TabIndex = 2;
            // 
            // usbPath
            // 
            usbPath.Location = new Point(173, 39);
            usbPath.Name = "usbPath";
            usbPath.Size = new Size(260, 22);
            usbPath.TabIndex = 3;
            // 
            // btnAttachCD
            // 
            btnAttachCD.Location = new Point(456, 1);
            btnAttachCD.Name = "btnAttachCD";
            btnAttachCD.Size = new Size(100, 27);
            btnAttachCD.TabIndex = 4;
            btnAttachCD.Text = "附加 CD";
            btnAttachCD.UseVisualStyleBackColor = true;
            btnAttachCD.Click += btnAttachCD_Click;
            // 
            // btnAttachUSB
            // 
            btnAttachUSB.Location = new Point(456, 37);
            btnAttachUSB.Name = "btnAttachUSB";
            btnAttachUSB.Size = new Size(100, 27);
            btnAttachUSB.TabIndex = 5;
            btnAttachUSB.Text = "附加 USB";
            btnAttachUSB.UseVisualStyleBackColor = true;
            btnAttachUSB.Click += btnAttachUSB_Click;
            // 
            // HotSwapManager
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 90);
            Controls.Add(btnAttachUSB);
            Controls.Add(btnAttachCD);
            Controls.Add(usbPath);
            Controls.Add(cdromPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotSwapManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "热切换管理器";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cdromPath;
        private System.Windows.Forms.TextBox usbPath;
        private System.Windows.Forms.Button btnAttachCD;
        private System.Windows.Forms.Button btnAttachUSB;
    }
}