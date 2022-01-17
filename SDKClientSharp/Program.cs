using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SDKClientSharp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FormLang form = new FormLang();
            form.ShowDialog();

            Form mainForm = null;
            if(form.DemoType == DemoType.Basic)
            {
                mainForm = new FormBasic();
            }
            else
            {
                mainForm = new FormMain();
            }

            Application.Run(mainForm);
            
        }
    }
}
