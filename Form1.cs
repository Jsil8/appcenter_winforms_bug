using System.Reflection;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            AppCenter.Start("appSecret=xxx", typeof(Crashes));
        }
    }
}