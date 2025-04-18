using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QEMUManager
{
    public partial class NewImageDialog : Form
    {
        private Action<string> callback;

        public NewImageDialog(Action<string> callback)
        {
            this.callback = callback;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string size = txtSize.Text;
            string format = cmbFormat.SelectedItem.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(format))
            {
                MessageBox.Show("虚拟硬盘名称、大小和格式不能为空！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(size, out int sizeInt) || sizeInt <= 0)
            {
                MessageBox.Show("虚拟硬盘大小必须是正整数！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string command = $"qemu-img create -f {format} {name}.{format} {size}G";
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                });
                MessageBox.Show($"虚拟硬盘 {name}.{format} 已创建！", "创建成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                callback?.Invoke($"{name}.{format}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"创建虚拟硬盘时出错：{ex.Message}", "创建失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}