using FcNet.FormStyleJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
