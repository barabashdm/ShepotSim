using System;
using ShepotSim;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShepotSim
{
    static class Program
    {
        internal static Form1 f1;
        internal static LoginForm2 f2;
        internal static AccountForm3 f3;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f1 = new Form1();
            f2 = new LoginForm2();
            f3 = new AccountForm3();
            Application.Run(f1);
        }
    }

    static class Data
    {
        public static int Value { get; set; }
    }

    static class DataExt
    {
        public static int ValueExt { get; set; }
    }
}
