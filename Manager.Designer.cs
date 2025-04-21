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
            CPUThreads = new ComboBox();
            label15 = new Label();
            CPUModel = new ComboBox();
            label14 = new Label();
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
            btnHotSwap = new Button();
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
            USBOptions.Controls.Add(label7);
            USBOptions.Controls.Add(USBMassType);
            USBOptions.Controls.Add(EnableUSBMass);
            USBOptions.Controls.Add(EnableUSBMouse);
            USBOptions.Controls.Add(EnableUSBTablet);
            USBOptions.Controls.Add(EnableUSBKeyboard);
            resources.ApplyResources(USBOptions, "USBOptions");
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
            USBMassType.FormattingEnabled = true;
            resources.ApplyResources(USBMassType, "USBMassType");
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
            VirtIOOptions.Controls.Add(EnableRNG);
            VirtIOOptions.Controls.Add(EnableSerial);
            VirtIOOptions.Controls.Add(EnableBalloon);
            resources.ApplyResources(VirtIOOptions, "VirtIOOptions");
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
            BootOptions.Controls.Add(label9);
            BootOptions.Controls.Add(FirmwarePath);
            BootOptions.Controls.Add(rbBootFromCDROM);
            BootOptions.Controls.Add(label8);
            BootOptions.Controls.Add(Boot);
            BootOptions.Controls.Add(rbBootFromHDD);
            resources.ApplyResources(BootOptions, "BootOptions");
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
            Boot.FormattingEnabled = true;
            Boot.Items.AddRange(new object[] { resources.GetString("Boot.Items"), resources.GetString("Boot.Items1") });
            resources.ApplyResources(Boot, "Boot");
            Boot.Name = "Boot";
            // 
            // NetworkOptions
            // 
            NetworkOptions.Controls.Add(label4);
            NetworkOptions.Controls.Add(NetworkCardType);
            NetworkOptions.Controls.Add(EnbaleNetUser);
            resources.ApplyResources(NetworkOptions, "NetworkOptions");
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
            NetworkCardType.FormattingEnabled = true;
            NetworkCardType.Items.AddRange(new object[] { resources.GetString("NetworkCardType.Items"), resources.GetString("NetworkCardType.Items1"), resources.GetString("NetworkCardType.Items2"), resources.GetString("NetworkCardType.Items3"), resources.GetString("NetworkCardType.Items4"), resources.GetString("NetworkCardType.Items5") });
            resources.ApplyResources(NetworkCardType, "NetworkCardType");
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
            HardwareOptions.Controls.Add(CPUThreads);
            HardwareOptions.Controls.Add(label15);
            HardwareOptions.Controls.Add(CPUModel);
            HardwareOptions.Controls.Add(label14);
            HardwareOptions.Controls.Add(MemSize);
            HardwareOptions.Controls.Add(label12);
            HardwareOptions.Controls.Add(MachineType);
            HardwareOptions.Controls.Add(label11);
            HardwareOptions.Controls.Add(VideocardModel);
            HardwareOptions.Controls.Add(label10);
            HardwareOptions.Controls.Add(SoundcardModel);
            HardwareOptions.Controls.Add(EnableSoundCard);
            resources.ApplyResources(HardwareOptions, "HardwareOptions");
            HardwareOptions.Name = "HardwareOptions";
            HardwareOptions.TabStop = false;
            // 
            // CPUThreads
            // 
            CPUThreads.FormattingEnabled = true;
            CPUThreads.Items.AddRange(new object[] { resources.GetString("CPUThreads.Items"), resources.GetString("CPUThreads.Items1"), resources.GetString("CPUThreads.Items2"), resources.GetString("CPUThreads.Items3"), resources.GetString("CPUThreads.Items4") });
            resources.ApplyResources(CPUThreads, "CPUThreads");
            CPUThreads.Name = "CPUThreads";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // CPUModel
            // 
            CPUModel.FormattingEnabled = true;
            CPUModel.Items.AddRange(new object[] { resources.GetString("CPUModel.Items"), resources.GetString("CPUModel.Items1"), resources.GetString("CPUModel.Items2"), resources.GetString("CPUModel.Items3"), resources.GetString("CPUModel.Items4"), resources.GetString("CPUModel.Items5"), resources.GetString("CPUModel.Items6"), resources.GetString("CPUModel.Items7"), resources.GetString("CPUModel.Items8"), resources.GetString("CPUModel.Items9"), resources.GetString("CPUModel.Items10"), resources.GetString("CPUModel.Items11"), resources.GetString("CPUModel.Items12"), resources.GetString("CPUModel.Items13"), resources.GetString("CPUModel.Items14"), resources.GetString("CPUModel.Items15"), resources.GetString("CPUModel.Items16"), resources.GetString("CPUModel.Items17"), resources.GetString("CPUModel.Items18"), resources.GetString("CPUModel.Items19"), resources.GetString("CPUModel.Items20"), resources.GetString("CPUModel.Items21"), resources.GetString("CPUModel.Items22"), resources.GetString("CPUModel.Items23"), resources.GetString("CPUModel.Items24"), resources.GetString("CPUModel.Items25"), resources.GetString("CPUModel.Items26"), resources.GetString("CPUModel.Items27"), resources.GetString("CPUModel.Items28"), resources.GetString("CPUModel.Items29"), resources.GetString("CPUModel.Items30"), resources.GetString("CPUModel.Items31"), resources.GetString("CPUModel.Items32"), resources.GetString("CPUModel.Items33"), resources.GetString("CPUModel.Items34"), resources.GetString("CPUModel.Items35"), resources.GetString("CPUModel.Items36"), resources.GetString("CPUModel.Items37"), resources.GetString("CPUModel.Items38"), resources.GetString("CPUModel.Items39"), resources.GetString("CPUModel.Items40"), resources.GetString("CPUModel.Items41"), resources.GetString("CPUModel.Items42"), resources.GetString("CPUModel.Items43"), resources.GetString("CPUModel.Items44"), resources.GetString("CPUModel.Items45"), resources.GetString("CPUModel.Items46"), resources.GetString("CPUModel.Items47"), resources.GetString("CPUModel.Items48"), resources.GetString("CPUModel.Items49"), resources.GetString("CPUModel.Items50"), resources.GetString("CPUModel.Items51"), resources.GetString("CPUModel.Items52"), resources.GetString("CPUModel.Items53"), resources.GetString("CPUModel.Items54"), resources.GetString("CPUModel.Items55"), resources.GetString("CPUModel.Items56"), resources.GetString("CPUModel.Items57"), resources.GetString("CPUModel.Items58"), resources.GetString("CPUModel.Items59"), resources.GetString("CPUModel.Items60"), resources.GetString("CPUModel.Items61"), resources.GetString("CPUModel.Items62"), resources.GetString("CPUModel.Items63"), resources.GetString("CPUModel.Items64"), resources.GetString("CPUModel.Items65"), resources.GetString("CPUModel.Items66"), resources.GetString("CPUModel.Items67"), resources.GetString("CPUModel.Items68"), resources.GetString("CPUModel.Items69"), resources.GetString("CPUModel.Items70"), resources.GetString("CPUModel.Items71"), resources.GetString("CPUModel.Items72"), resources.GetString("CPUModel.Items73"), resources.GetString("CPUModel.Items74"), resources.GetString("CPUModel.Items75"), resources.GetString("CPUModel.Items76"), resources.GetString("CPUModel.Items77"), resources.GetString("CPUModel.Items78"), resources.GetString("CPUModel.Items79"), resources.GetString("CPUModel.Items80"), resources.GetString("CPUModel.Items81"), resources.GetString("CPUModel.Items82"), resources.GetString("CPUModel.Items83"), resources.GetString("CPUModel.Items84"), resources.GetString("CPUModel.Items85"), resources.GetString("CPUModel.Items86"), resources.GetString("CPUModel.Items87"), resources.GetString("CPUModel.Items88"), resources.GetString("CPUModel.Items89"), resources.GetString("CPUModel.Items90"), resources.GetString("CPUModel.Items91"), resources.GetString("CPUModel.Items92"), resources.GetString("CPUModel.Items93"), resources.GetString("CPUModel.Items94"), resources.GetString("CPUModel.Items95"), resources.GetString("CPUModel.Items96"), resources.GetString("CPUModel.Items97"), resources.GetString("CPUModel.Items98"), resources.GetString("CPUModel.Items99"), resources.GetString("CPUModel.Items100"), resources.GetString("CPUModel.Items101"), resources.GetString("CPUModel.Items102"), resources.GetString("CPUModel.Items103"), resources.GetString("CPUModel.Items104"), resources.GetString("CPUModel.Items105"), resources.GetString("CPUModel.Items106"), resources.GetString("CPUModel.Items107"), resources.GetString("CPUModel.Items108"), resources.GetString("CPUModel.Items109"), resources.GetString("CPUModel.Items110"), resources.GetString("CPUModel.Items111"), resources.GetString("CPUModel.Items112"), resources.GetString("CPUModel.Items113"), resources.GetString("CPUModel.Items114"), resources.GetString("CPUModel.Items115"), resources.GetString("CPUModel.Items116"), resources.GetString("CPUModel.Items117"), resources.GetString("CPUModel.Items118"), resources.GetString("CPUModel.Items119"), resources.GetString("CPUModel.Items120"), resources.GetString("CPUModel.Items121"), resources.GetString("CPUModel.Items122"), resources.GetString("CPUModel.Items123"), resources.GetString("CPUModel.Items124"), resources.GetString("CPUModel.Items125"), resources.GetString("CPUModel.Items126"), resources.GetString("CPUModel.Items127"), resources.GetString("CPUModel.Items128"), resources.GetString("CPUModel.Items129"), resources.GetString("CPUModel.Items130"), resources.GetString("CPUModel.Items131"), resources.GetString("CPUModel.Items132"), resources.GetString("CPUModel.Items133"), resources.GetString("CPUModel.Items134"), resources.GetString("CPUModel.Items135"), resources.GetString("CPUModel.Items136"), resources.GetString("CPUModel.Items137"), resources.GetString("CPUModel.Items138"), resources.GetString("CPUModel.Items139"), resources.GetString("CPUModel.Items140"), resources.GetString("CPUModel.Items141") });
            resources.ApplyResources(CPUModel, "CPUModel");
            CPUModel.Name = "CPUModel";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            label14.Click += label14_Click;
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
            MachineType.FormattingEnabled = true;
            MachineType.Items.AddRange(new object[] { resources.GetString("MachineType.Items"), resources.GetString("MachineType.Items1") });
            resources.ApplyResources(MachineType, "MachineType");
            MachineType.Name = "MachineType";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // VideocardModel
            // 
            VideocardModel.FormattingEnabled = true;
            VideocardModel.Items.AddRange(new object[] { resources.GetString("VideocardModel.Items"), resources.GetString("VideocardModel.Items1"), resources.GetString("VideocardModel.Items2") });
            resources.ApplyResources(VideocardModel, "VideocardModel");
            VideocardModel.Name = "VideocardModel";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // SoundcardModel
            // 
            SoundcardModel.FormattingEnabled = true;
            resources.ApplyResources(SoundcardModel, "SoundcardModel");
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
            // btnHotSwap
            // 
            resources.ApplyResources(btnHotSwap, "btnHotSwap");
            btnHotSwap.Name = "btnHotSwap";
            btnHotSwap.UseVisualStyleBackColor = true;
            btnHotSwap.Click += btnHotSwap_Click;
            // 
            // Manager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHotSwap);
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
        private Button btnHotSwap;
        private ComboBox CPUModel;
        private Label label14;
        private ComboBox CPUThreads;
        private Label label15;
    }
}