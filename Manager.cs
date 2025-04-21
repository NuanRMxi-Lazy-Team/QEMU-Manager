using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QEMUManager
{
    public partial class Manager : Form
    {
        private Process qemuProcess;

        public Manager()
        {
            InitializeComponent();
        }

        private void btnStartVM_Click(object sender, EventArgs e)
        {
            string qemuExecutable = txtQEMUPath.Text;
            if (!System.IO.File.Exists(qemuExecutable))
            {
                MessageBox.Show("指定的 QEMU 路径无效，请检查 QEMU 是否已正确安装。", "无法启动虚拟机", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string command = qemuExecutable;

            if (rbBootFromCDROM.Checked)
            {
                if (!System.IO.File.Exists(txtCDROMPath.Text))
                {
                    MessageBox.Show("指定的 CD-ROM 文件不存在。", "无法启动虚拟机", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                command += $" -cdrom \"{txtCDROMPath.Text}\"";
            }

            if (!string.IsNullOrEmpty(txtHDDPath.Text))
            {
                if (EnableVirtIODisk.Checked)
                {
                    command += $" -drive file=\"{txtHDDPath.Text}\",if=virtio";
                }
                else
                {
                    command += $" -hda \"{txtHDDPath.Text}\"";
                }
            }

            if (!string.IsNullOrEmpty(MemSize.Text))
            {
                command += $" -m \"{MemSize.Text}\"";
            }

            if (chkUseSDL.Checked)
            {
                command += " -sdl";
            }

            if (chkUseHAXM.Checked)
            {
                command += " -accel hax";
            }

            if (chkEnableUSB.Checked)
            {
                command += " -usb";
            }

            if (EnableUSBTablet.Checked)
            {
                command += " -device usb-tablet";
            }

            if (EnableUSBKeyboard.Checked)
            {
                command += " -device usb-kbd";
            }

            if (EnableUSBMass.Checked)
            {
                command += $" -device usb-storage,file={USBMassType.Text}";
            }

            if (EnbaleNetUser.Checked)
            {
                command += " -net user";
            }

            if (EnableRNG.Checked)
            {
                command += " -device virtio-rng-pci";
            }

            if (SyncHostClock.Checked)
            {
                command += " -rtc base=localtime,clock=host";
            }

            if (!string.IsNullOrEmpty(NetworkCardType.Text))
            {
                int startIndex = NetworkCardType.Text.IndexOf('(') + 1;
                int endIndex = NetworkCardType.Text.IndexOf(')');
                if (startIndex > 0 && endIndex > startIndex)
                {
                    string model = NetworkCardType.Text.Substring(startIndex, endIndex - startIndex).Trim();
                    command += $" -net nic,model={model}";
                }
            }

            if (EnableBalloon.Checked)
            {
                command += " -device virtio-balloon-pci";
            }

            if (EnableSerial.Checked)
            {
                command += " -device virtio-serial";
            }

            string boot = Boot.Text;
            switch (boot)
            {
                case "UEFI":
                    if (!string.IsNullOrEmpty(FirmwarePath.Text))
                    {
                        command += $" -pflash \"{FirmwarePath.Text}\"";
                    }
                    else
                    {
                        MessageBox.Show("选用 UEFI 启动时，必须要指定一个 EFI 固件！", "固件路径不得为空", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Legacy BIOS":
                    break;
                default:
                    MessageBox.Show("未知的启动方式！", "启动方式错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string videocardModel = VideocardModel.Text;
            switch (videocardModel)
            {
                case "Cirrus 5446 PCI":
                    command += " -vga cirrus";
                    break;
                case "Red Hat QXL":
                    command += " -vga qxl";
                    break;
                case "Red Hat Virtio":
                    command += " -vga virtio";
                    break;
                default:
                    command += $" -vga {videocardModel.ToLower().Replace(" ", "")}";
                    break;
            }

            if (EnableSoundCard.Checked)
            {
                string soundcardModel = SoundcardModel.Text;
                switch (soundcardModel)
                {
                    case "Creative SB16":
                        command += " -device sb16";
                        break;
                    case "Intel 82801AA AC97":
                        command += " -device ac97";
                        break;
                    case "Intel ICH6 HDA":
                        command += " -device intel-hda -device hda-duplex";
                        break;
                    default:
                        // 如果用户选择了其他未定义的声卡类型，可以在这里添加更多的case
                        break;
                }
            }

            if (!string.IsNullOrEmpty(MachineType.Text))
            {
                command += $" -M {MachineType.Text}";
            }

            string cpuModel = CPUModel.Text;
            if (!string.IsNullOrEmpty(cpuModel))
            {
                command += $" -cpu {cpuModel}";
            }

            string cpuThreads = CPUThreads.Text;
            if (!string.IsNullOrEmpty(cpuThreads))
            {
                command += $" -smp {cpuThreads}";
            }

            try
            {
                qemuProcess = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c \"{command}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                });
                MessageBox.Show("虚拟机已启动！", "启动成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"启动虚拟机时出错：{ex.Message}", "启动失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKillVM_Click(object sender, EventArgs e)
        {
            if (qemuProcess == null || qemuProcess.HasExited)
            {
                MessageBox.Show("虚拟机未在运行", "虚拟机未在运行", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("你确定要强行结束 QEMU 的进程吗？虚拟机任何未保存的数据将会丢失！", "结束 QEMU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                qemuProcess.Kill();
                MessageBox.Show("QEMU 已终止", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHotSwap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("目前此功能有些问题，我们仍在努力修复","UNDER CONSTRUCTION",MessageBoxButtons.OK);
        }

        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            using (var dialog = new NewImageDialog(UpdateHDDPath))
            {
                dialog.ShowDialog();
            }
        }

        private void UpdateHDDPath(string newPath)
        {
            txtHDDPath.Text = newPath;
        }

        private void btnBrowseQEMU_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "可执行文件 (*.exe)|*.exe" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtQEMUPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseISO_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "ISO 文件 (*.iso)|*.iso" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCDROMPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseHDD_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "虚拟硬盘文件 (*.vhd;*.qcow2)|*.vhd;*.qcow2" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtHDDPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qemuProcess != null && !qemuProcess.HasExited)
            {
                if (MessageBox.Show("虚拟机正在运行，是否要终止 QEMU 进程并退出程序？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    qemuProcess.Kill();
                }
            }
        }

        private void SaveConfigure_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "配置文件 (*.cfg)|*.cfg",
                Title = "保存配置文件"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string configPath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(configPath))
                {
                    writer.WriteLine($"QEMUPath={txtQEMUPath.Text}");
                    writer.WriteLine($"CDROMPath={txtCDROMPath.Text}");
                    writer.WriteLine($"HDDPath={txtHDDPath.Text}");
                    writer.WriteLine($"MemorySize={MemSize.Text}");
                    writer.WriteLine($"MachineType={MachineType.Text}");
                    writer.WriteLine($"VideocardModel={VideocardModel.Text}");
                    writer.WriteLine($"SoundcardModel={SoundcardModel.Text}");
                    writer.WriteLine($"EnableUSB={chkEnableUSB.Checked}");
                    writer.WriteLine($"EnableSoundCard={EnableSoundCard.Checked}");
                    writer.WriteLine($"EnableVirtIODisk={EnableVirtIODisk.Checked}");
                    writer.WriteLine($"SyncHostClock={SyncHostClock.Checked}");
                    writer.WriteLine($"NetworkCardType={NetworkCardType.Text}");
                    writer.WriteLine($"EnbaleNetUser={EnbaleNetUser.Checked}");
                    writer.WriteLine($"CPUModel={CPUModel.Text}");
                    writer.WriteLine($"CPUThreads={CPUThreads.Text}");
                }
                MessageBox.Show("配置已保存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReadConfigure_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "配置文件 (*.cfg)|*.cfg",
                Title = "读取配置文件"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string configPath = openFileDialog.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(configPath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line.StartsWith("QEMUPath="))
                            {
                                txtQEMUPath.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("CDROMPath="))
                            {
                                txtCDROMPath.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("HDDPath="))
                            {
                                txtHDDPath.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("MemorySize="))
                            {
                                MemSize.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("MachineType="))
                            {
                                MachineType.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("VideocardModel="))
                            {
                                VideocardModel.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("SoundcardModel="))
                            {
                                SoundcardModel.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("EnableUSB="))
                            {
                                chkEnableUSB.Checked = bool.Parse(line.Split('=')[1]);
                            }
                            else if (line.StartsWith("EnableSoundCard="))
                            {
                                EnableSoundCard.Checked = bool.Parse(line.Split('=')[1]);
                            }
                            else if (line.StartsWith("EnableVirtIODisk="))
                            {
                                EnableVirtIODisk.Checked = bool.Parse(line.Split('=')[1]);
                            }
                            else if (line.StartsWith("SyncHostClock="))
                            {
                                SyncHostClock.Checked = bool.Parse(line.Split('=')[1]);
                            }
                            else if (line.StartsWith("NetworkCardType="))
                            {
                                NetworkCardType.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("EnbaleNetUser="))
                            {
                                EnbaleNetUser.Checked = bool.Parse(line.Split('=')[1]);
                            }
                            else if (line.StartsWith("CPUModel="))
                            {
                                CPUModel.Text = line.Split('=')[1];
                            }
                            else if (line.StartsWith("CPUThreads="))
                            {
                                CPUThreads.Text = line.Split('=')[1];
                            }
                        }
                    }
                    MessageBox.Show("配置已加载！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"读取配置文件时出错：{ex.Message}", "读取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

    }
}