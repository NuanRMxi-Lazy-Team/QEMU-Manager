using System;
using System.Windows.Forms;

namespace QEMUManager
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 2 && args[0].Equals("/load", StringComparison.OrdinalIgnoreCase))
            {
                string configFilePath = args[1];
                using (var manager = new Manager())
                {
                    
                    Application.Run(manager);
                }
            }
            else
            {
                using (var manager = new Manager())
                {
                    Application.Run(manager);
                }
            }
        }
    }
}