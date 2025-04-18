namespace QEMUManager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            txtQEMUPath = new TextBox();
            btnBrowseQEMU = new Button();
            txtCDROMPath = new TextBox();
            btnBrowseISO = new Button();
            txtHDDPath = new TextBox();
            btnBrowseHDD = new Button();
            rbBootFromCDROM = new RadioButton();
            rbBootFromHDD = new RadioButton();
            chkUseSDL = new CheckBox();
            chkUseHAXM = new CheckBox();
            chkEnableUSB = new CheckBox();
            btnStartVM = new Button();
            btnKillVM = new Button();
            btnCreateImage = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            USBOptions = new GroupBox();
            label7 = new Label();
            USBMassType = new ComboBox();
            EnableUSBMass = new CheckBox();
            EnableUSBMouse = new CheckBox();
            EnableUSBTablet = new CheckBox();
            EnableUSBKeyboard = new CheckBox();
            VirtIOOptions = new GroupBox();
            EnableRNG = new CheckBox();
            EnableSerial = new CheckBox();
            EnableBalloon = new CheckBox();
            BootOptions = new GroupBox();
            label9 = new Label();
            FirmwarePath = new TextBox();
            label8 = new Label();
            Boot = new ComboBox();
            NetworkOptions = new GroupBox();
            label4 = new Label();
            NetworkCardType = new ComboBox();
            EnbaleNetUser = new CheckBox();
            EnableSoundCard = new CheckBox();
            HardwareOptions = new GroupBox();
            MemSize = new TextBox();
            label12 = new Label();
            MachineType = new ComboBox();
            label11 = new Label();
            VideocardModel = new ComboBox();
            label10 = new Label();
            SoundcardModel = new ComboBox();
            SyncHostClock = new CheckBox();
            EnableVirtIODisk = new CheckBox();
            label13 = new Label();
            SaveConfigure = new Button();
            ReadConfigure = new Button();
            USBOptions.SuspendLayout();
            VirtIOOptions.SuspendLayout();
            BootOptions.SuspendLayout();
            NetworkOptions.SuspendLayout();
            HardwareOptions.SuspendLayout();
            SuspendLayout();
            // 
            // txtQEMUPath
            // 
            resources.ApplyResources(txtQEMUPath, "txtQEMUPath");
            txtQEMUPath.Name = "txtQEMUPath";
            // 
            // btnBrowseQEMU
            // 
            resources.ApplyResources(btnBrowseQEMU, "btnBrowseQEMU");
            btnBrowseQEMU.Name = "btnBrowseQEMU";
            btnBrowseQEMU.UseVisualStyleBackColor = true;
            btnBrowseQEMU.Click += btnBrowseQEMU_Click;
            // 
            // txtCDROMPath
            // 
            resources.ApplyResources(txtCDROMPath, "txtCDROMPath");
            txtCDROMPath.Name = "txtCDROMPath";
            // 
            // btnBrowseISO
            // 
            resources.ApplyResources(btnBrowseISO, "btnBrowseISO");
            btnBrowseISO.Name = "btnBrowseISO";
            btnBrowseISO.UseVisualStyleBackColor = true;
            btnBrowseISO.Click += btnBrowseISO_Click;
            // 
            // txtHDDPath
            // 
            resources.ApplyResources(txtHDDPath, "txtHDDPath");
            txtHDDPath.Name = "txtHDDPath";
            // 
            // btnBrowseHDD
            // 
            resources.ApplyResources(btnBrowseHDD, "btnBrowseHDD");
            btnBrowseHDD.Name = "btnBrowseHDD";
            btnBrowseHDD.UseVisualStyleBackColor = true;
            btnBrowseHDD.Click += btnBrowseHDD_Click;
            // 
            // rbBootFromCDROM
            // 
            resources.ApplyResources(rbBootFromCDROM, "rbBootFromCDROM");
            rbBootFromCDROM.Checked = true;
            rbBootFromCDROM.Name = "rbBootFromCDROM";
            rbBootFromCDROM.TabStop = true;
            rbBootFromCDROM.UseVisualStyleBackColor = true;
            // 
            // rbBootFromHDD
            // 
            resources.ApplyResources(rbBootFromHDD, "rbBootFromHDD");
            rbBootFromHDD.Name = "rbBootFromHDD";
            rbBootFromHDD.UseVisualStyleBackColor = true;
            // 
            // chkUseSDL
            // 
            resources.ApplyResources(chkUseSDL, "chkUseSDL");
            chkUseSDL.Name = "chkUseSDL";
            chkUseSDL.UseVisualStyleBackColor = true;
            // 
            // chkUseHAXM
            // 
            resources.ApplyResources(chkUseHAXM, "chkUseHAXM");
            chkUseHAXM.Name = "chkUseHAXM";
            chkUseHAXM.UseVisualStyleBackColor = true;
            // 
            // chkEnableUSB
            // 
            resources.ApplyResources(chkEnableUSB, "chkEnableUSB");
            chkEnableUSB.Name = "chkEnableUSB";
            chkEnableUSB.UseVisualStyleBackColor = true;
            // 
            // btnStartVM
            // 
            resources.ApplyResources(btnStartVM, "btnStartVM");
            btnStartVM.Name = "btnStartVM";
            btnStartVM.UseVisualStyleBackColor = true;
            btnStartVM.Click += btnStartVM_Click;
            // 
            // btnKillVM
            // 
            resources.ApplyResources(btnKillVM, "btnKillVM");
            btnKillVM.Name = "btnKillVM";
            btnKillVM.UseVisualStyleBackColor = true;
            btnKillVM.Click += btnKillVM_Click;
            // 
            // btnCreateImage
            // 
            resources.ApplyResources(btnCreateImage, "btnCreateImage");
            btnCreateImage.Name = "btnCreateImage";
            btnCreateImage.UseVisualStyleBackColor = true;
            btnCreateImage.Click += btnCreateImage_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // USBOptions
            // 
            resources.ApplyResources(USBOptions, "USBOptions");
            USBOptions.Controls.Add(label7);
            USBOptions.Controls.Add(USBMassType);
            USBOptions.Controls.Add(EnableUSBMass);
            USBOptions.Controls.Add(EnableUSBMouse);
            USBOptions.Controls.Add(EnableUSBTablet);
            USBOptions.Controls.Add(EnableUSBKeyboard);
            USBOptions.Name = "USBOptions";
            USBOptions.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // USBMassType
            // 
            resources.ApplyResources(USBMassType, "USBMassType");
            USBMassType.FormattingEnabled = true;
            USBMassType.Name = "USBMassType";
            // 
            // EnableUSBMass
            // 
            resources.ApplyResources(EnableUSBMass, "EnableUSBMass");
            EnableUSBMass.Name = "EnableUSBMass";
            EnableUSBMass.UseVisualStyleBackColor = true;
            // 
            // EnableUSBMouse
            // 
            resources.ApplyResources(EnableUSBMouse, "EnableUSBMouse");
            EnableUSBMouse.Name = "EnableUSBMouse";
            EnableUSBMouse.UseVisualStyleBackColor = true;
            // 
            // EnableUSBTablet
            // 
            resources.ApplyResources(EnableUSBTablet, "EnableUSBTablet");
            EnableUSBTablet.Name = "EnableUSBTablet";
            EnableUSBTablet.UseVisualStyleBackColor = true;
            // 
            // EnableUSBKeyboard
            // 
            resources.ApplyResources(EnableUSBKeyboard, "EnableUSBKeyboard");
            EnableUSBKeyboard.Name = "EnableUSBKeyboard";
            EnableUSBKeyboard.UseVisualStyleBackColor = true;
            // 
            // VirtIOOptions
            // 
            resources.ApplyResources(VirtIOOptions, "VirtIOOptions");
            VirtIOOptions.Controls.Add(EnableRNG);
            VirtIOOptions.Controls.Add(EnableSerial);
            VirtIOOptions.Controls.Add(EnableBalloon);
            VirtIOOptions.Name = "VirtIOOptions";
            VirtIOOptions.TabStop = false;
            // 
            // EnableRNG
            // 
            resources.ApplyResources(EnableRNG, "EnableRNG");
            EnableRNG.Name = "EnableRNG";
            EnableRNG.UseVisualStyleBackColor = true;
            // 
            // EnableSerial
            // 
            resources.ApplyResources(EnableSerial, "EnableSerial");
            EnableSerial.Name = "EnableSerial";
            EnableSerial.UseVisualStyleBackColor = true;
            // 
            // EnableBalloon
            // 
            resources.ApplyResources(EnableBalloon, "EnableBalloon");
            EnableBalloon.Name = "EnableBalloon";
            EnableBalloon.UseVisualStyleBackColor = true;
            // 
            // BootOptions
            // 
            resources.ApplyResources(BootOptions, "BootOptions");
            BootOptions.Controls.Add(label9);
            BootOptions.Controls.Add(FirmwarePath);
            BootOptions.Controls.Add(rbBootFromCDROM);
            BootOptions.Controls.Add(label8);
            BootOptions.Controls.Add(Boot);
            BootOptions.Controls.Add(rbBootFromHDD);
            BootOptions.Name = "BootOptions";
            BootOptions.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // FirmwarePath
            // 
            resources.ApplyResources(FirmwarePath, "FirmwarePath");
            FirmwarePath.Name = "FirmwarePath";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // Boot
            // 
            resources.ApplyResources(Boot, "Boot");
            Boot.FormattingEnabled = true;
            Boot.Items.AddRange(new object[] { resources.GetString("Boot.Items"), resources.GetString("Boot.Items1") });
            Boot.Name = "Boot";
            // 
            // NetworkOptions
            // 
            resources.ApplyResources(NetworkOptions, "NetworkOptions");
            NetworkOptions.Controls.Add(label4);
            NetworkOptions.Controls.Add(NetworkCardType);
            NetworkOptions.Controls.Add(EnbaleNetUser);
            NetworkOptions.Name = "NetworkOptions";
            NetworkOptions.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // NetworkCardType
            // 
            resources.ApplyResources(NetworkCardType, "NetworkCardType");
            NetworkCardType.FormattingEnabled = true;
            NetworkCardType.Items.AddRange(new object[] { resources.GetString("NetworkCardType.Items"), resources.GetString("NetworkCardType.Items1"), resources.GetString("NetworkCardType.Items2"), resources.GetString("NetworkCardType.Items3"), resources.GetString("NetworkCardType.Items4"), resources.GetString("NetworkCardType.Items5") });
            NetworkCardType.Name = "NetworkCardType";
            // 
            // EnbaleNetUser
            // 
            resources.ApplyResources(EnbaleNetUser, "EnbaleNetUser");
            EnbaleNetUser.Name = "EnbaleNetUser";
            EnbaleNetUser.UseVisualStyleBackColor = true;
            // 
            // EnableSoundCard
            // 
            resources.ApplyResources(EnableSoundCard, "EnableSoundCard");
            EnableSoundCard.Name = "EnableSoundCard";
            EnableSoundCard.UseVisualStyleBackColor = true;
            // 
            // HardwareOptions
            // 
            resources.ApplyResources(HardwareOptions, "HardwareOptions");
            HardwareOptions.Controls.Add(MemSize);
            HardwareOptions.Controls.Add(label12);
            HardwareOptions.Controls.Add(MachineType);
            HardwareOptions.Controls.Add(label11);
            HardwareOptions.Controls.Add(VideocardModel);
            HardwareOptions.Controls.Add(label10);
            HardwareOptions.Controls.Add(SoundcardModel);
            HardwareOptions.Controls.Add(EnableSoundCard);
            HardwareOptions.Name = "HardwareOptions";
            HardwareOptions.TabStop = false;
            // 
            // MemSize
            // 
            resources.ApplyResources(MemSize, "MemSize");
            MemSize.Name = "MemSize";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // MachineType
            // 
            resources.ApplyResources(MachineType, "MachineType");
            MachineType.FormattingEnabled = true;
            MachineType.Items.AddRange(new object[] { resources.GetString("MachineType.Items"), resources.GetString("MachineType.Items1") });
            MachineType.Name = "MachineType";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // VideocardModel
            // 
            resources.ApplyResources(VideocardModel, "VideocardModel");
            VideocardModel.FormattingEnabled = true;
            VideocardModel.Items.AddRange(new object[] { resources.GetString("VideocardModel.Items"), resources.GetString("VideocardModel.Items1"), resources.GetString("VideocardModel.Items2") });
            VideocardModel.Name = "VideocardModel";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // SoundcardModel
            // 
            resources.ApplyResources(SoundcardModel, "SoundcardModel");
            SoundcardModel.FormattingEnabled = true;
            SoundcardModel.Items.AddRange(new object[] { resources.GetString("SoundcardModel.Items"), resources.GetString("SoundcardModel.Items1"), resources.GetString("SoundcardModel.Items2") });
            SoundcardModel.Name = "SoundcardModel";
            // 
            // SyncHostClock
            // 
            resources.ApplyResources(SyncHostClock, "SyncHostClock");
            SyncHostClock.Name = "SyncHostClock";
            SyncHostClock.UseVisualStyleBackColor = true;
            // 
            // EnableVirtIODisk
            // 
            resources.ApplyResources(EnableVirtIODisk, "EnableVirtIODisk");
            EnableVirtIODisk.Name = "EnableVirtIODisk";
            EnableVirtIODisk.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.ForeColor = Color.Gray;
            label13.Name = "label13";
            // 
            // SaveConfigure
            // 
            resources.ApplyResources(SaveConfigure, "SaveConfigure");
            SaveConfigure.Name = "SaveConfigure";
            SaveConfigure.UseVisualStyleBackColor = true;
            SaveConfigure.Click += SaveConfigure_Click;
            // 
            // ReadConfigure
            // 
            resources.ApplyResources(ReadConfigure, "ReadConfigure");
            ReadConfigure.Name = "ReadConfigure";
            ReadConfigure.UseVisualStyleBackColor = true;
            ReadConfigure.Click += ReadConfigure_Click;
            // 
            // Manager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReadConfigure);
            Controls.Add(SaveConfigure);
            Controls.Add(label13);
            Controls.Add(EnableVirtIODisk);
            Controls.Add(SyncHostClock);
            Controls.Add(HardwareOptions);
            Controls.Add(NetworkOptions);
            Controls.Add(BootOptions);
            Controls.Add(VirtIOOptions);
            Controls.Add(USBOptions);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateImage);
            Controls.Add(btnKillVM);
            Controls.Add(btnStartVM);
            Controls.Add(chkUseHAXM);
            Controls.Add(chkUseSDL);
            Controls.Add(chkEnableUSB);
            Controls.Add(btnBrowseHDD);
            Controls.Add(txtHDDPath);
            Controls.Add(btnBrowseISO);
            Controls.Add(txtCDROMPath);
            Controls.Add(btnBrowseQEMU);
            Controls.Add(txtQEMUPath);
            MaximizeBox = false;
            Name = "Manager";
            FormClosing += Manager_FormClosing;
            USBOptions.ResumeLayout(false);
            USBOptions.PerformLayout();
            VirtIOOptions.ResumeLayout(false);
            VirtIOOptions.PerformLayout();
            BootOptions.ResumeLayout(false);
            BootOptions.PerformLayout();
            NetworkOptions.ResumeLayout(false);
            NetworkOptions.PerformLayout();
            HardwareOptions.ResumeLayout(false);
            HardwareOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtQEMUPath;
        private System.Windows.Forms.Button btnBrowseQEMU;
        private System.Windows.Forms.TextBox txtCDROMPath;
        private System.Windows.Forms.Button btnBrowseISO;
        private System.Windows.Forms.TextBox txtHDDPath;
        private System.Windows.Forms.Button btnBrowseHDD;
        private System.Windows.Forms.RadioButton rbBootFromCDROM;
        private System.Windows.Forms.RadioButton rbBootFromHDD;
        private System.Windows.Forms.CheckBox chkUseSDL;
        private System.Windows.Forms.CheckBox chkUseHAXM;
        private System.Windows.Forms.CheckBox chkEnableUSB;
        private System.Windows.Forms.Button btnStartVM;
        private System.Windows.Forms.Button btnKillVM;
        private System.Windows.Forms.Button btnCreateImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox USBOptions;
        private System.Windows.Forms.CheckBox EnableUSBMass;
        private System.Windows.Forms.CheckBox EnableUSBMouse;
        private System.Windows.Forms.CheckBox EnableUSBTablet;
        private System.Windows.Forms.CheckBox EnableUSBKeyboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox USBMassType;
        private System.Windows.Forms.GroupBox VirtIOOptions;
        private System.Windows.Forms.CheckBox EnableSerial;
        private System.Windows.Forms.CheckBox EnableBalloon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Boot;
        private System.Windows.Forms.GroupBox BootOptions;
        private GroupBox NetworkOptions;
        private CheckBox EnbaleNetUser;
        private Label label4;
        private ComboBox NetworkCardType;
        private Label label9;
        private TextBox FirmwarePath;
        private CheckBox EnableSoundCard;
        private GroupBox HardwareOptions;
        private ComboBox SoundcardModel;
        private Label label10;
        private ComboBox VideocardModel;
        private ComboBox MachineType;
        private Label label11;
        private Label label12;
        private CheckBox EnableRNG;
        private CheckBox SyncHostClock;
        private CheckBox EnableVirtIODisk;
        private TextBox MemSize;
        private Label label13;
        private Button SaveConfigure;
        private Button ReadConfigure;
    }
}