namespace QEMUManager
{
    public partial class VMList : Form
    {
        public VMList()
        {
            InitializeComponent();
        }

        private void Configure_Click(object sender, EventArgs e)
        {
            // 创建并显示 Manager 窗体
            using (var dialog = new Manager())
            {
                dialog.ShowDialog(); // 显示为模态对话框
            }
        }

        private void StartVM_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择一个虚拟机！", "启动失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedVM = listBox1.SelectedItem.ToString();
            MessageBox.Show($"启动虚拟机：{selectedVM}", "启动虚拟机", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 在这里添加启动虚拟机的逻辑
        }

        private void StopVM_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择一个虚拟机！", "停止失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedVM = listBox1.SelectedItem.ToString();
            MessageBox.Show($"停止虚拟机：{selectedVM}", "停止虚拟机", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 在这里添加停止虚拟机的逻辑
        }

        private void VMList_Load(object sender, EventArgs e)
        {
            // 在窗体加载时执行的代码
        }
    }
}