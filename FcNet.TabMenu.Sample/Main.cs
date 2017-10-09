using FcNet.FormStyleJson;
using System.Windows.Forms;

namespace FcNet.TabMenu.Sample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ThemeEngine.ApplyTheme(this, @".\Theme\default.json");
        }
    }
}
