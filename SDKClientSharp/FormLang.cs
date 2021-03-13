using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SDKClientSharp
{
    public partial class FormLang : Form
    {
        const string chinese = "简体中文";
        const string english = "English";
        const string chineseCultureName = "zh-CN";
        const string englishCultureName = "en-US";
        readonly string[] _languages =  { english, chinese };
        public FormLang()
        {
            InitializeComponent();
        }

        private void FormLang_Load(object sender, EventArgs e)
        {
            InitLanguage();
        }

        private void InitLanguage()
        {
            comboBox1.DataSource = _languages;
            var cultureName = Thread.CurrentThread.CurrentUICulture.Name;
            switch (cultureName)
            {
                case chineseCultureName:
                    comboBox1.SelectedItem = chinese;
                    break;
                case englishCultureName:
                    comboBox1.SelectedItem = english;
                    break;
                default:
                    comboBox1.SelectedItem = chinese;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case english:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(englishCultureName);
                    break;
                case chinese:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(chineseCultureName);
                    break;
                default:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(chineseCultureName);
                    break;
            }

            this.Close();
        }
    }
}
