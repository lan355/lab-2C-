using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        internal static void taskTriangle(TextBox textBox1, int value)
        {
            throw new NotImplementedException();
        }

        internal static void taskRTriangle(TextBox textBox2, int value)
        {
            throw new NotImplementedException();
        }
    }
}
