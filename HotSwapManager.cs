using System.Diagnostics;

namespace QEMUManager
{
    public partial class HotSwapManager : Form
    {
        private Process qemuProcess;
        private Manager manager; // 添加一个 Manager 类型的字段

        public HotSwapManager(Process qemuProcess, Manager manager)
        {
            InitializeComponent();
            this.qemuProcess = qemuProcess;
            this.manager = manager; // 保存 Manager 窗体的实例
        }

        private void btnAttachCD_Click(object sender, EventArgs e)
        {
            string cdromPath = this.cdromPath.Text;
            if (!System.IO.File.Exists(cdromPath))
            {
                MessageBox.Show("指定的 CD-ROM 文件不存在。", "无法附加 CD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string command = $"change cdrom {cdromPath}";
            SendCommandToQEMU(command);
        }

        private void btnAttachUSB_Click(object sender, EventArgs e)
        {
            string usbPath = this.usbPath.Text;
            if (!System.IO.File.Exists(usbPath))
            {
                MessageBox.Show("指定的 USB 设备文件不存在。", "无法附加 USB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string command = $"usb_add {usbPath}";
            SendCommandToQEMU(command);
        }

        private void SendCommandToQEMU(string command)
        {
            if (qemuProcess == null || qemuProcess.HasExited)
            {
                MessageBox.Show("虚拟机未在运行", "虚拟机未在运行", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter writer = qemuProcess.StandardInput)
                {
                    writer.WriteLine(command);
                    writer.Flush();
                }
                MessageBox.Show("命令已发送到 QEMU Monitor", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发送命令时出错：{ex.Message}", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}