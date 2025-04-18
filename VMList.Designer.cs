namespace QEMUManager
{
    partial class VMList
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
            listBox1 = new ListBox();
            StartVM = new Button();
            StopVM = new Button();
            Configure = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(58, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(390, 259);
            listBox1.TabIndex = 0;
            // 
            // StartVM
            // 
            StartVM.Location = new Point(480, 43);
            StartVM.Name = "StartVM";
            StartVM.Size = new Size(138, 22);
            StartVM.TabIndex = 1;
            StartVM.Text = "启动";
            StartVM.UseVisualStyleBackColor = true;
            // 
            // StopVM
            // 
            StopVM.Location = new Point(480, 83);
            StopVM.Name = "StopVM";
            StopVM.Size = new Size(138, 22);
            StopVM.TabIndex = 2;
            StopVM.Text = "停止";
            StopVM.UseVisualStyleBackColor = true;
            // 
            // Configure
            // 
            Configure.Location = new Point(480, 126);
            Configure.Name = "Configure";
            Configure.Size = new Size(138, 26);
            Configure.TabIndex = 3;
            Configure.Text = "配置";
            Configure.UseVisualStyleBackColor = true;
            Configure.Click += Configure_Click;
            // 
            // VMList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Configure);
            Controls.Add(StopVM);
            Controls.Add(StartVM);
            Controls.Add(listBox1);
            Name = "VMList";
            Text = "虚拟机列表";
            Load += VMList_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button StartVM;
        private Button StopVM;
        private Button Configure;
    }
}