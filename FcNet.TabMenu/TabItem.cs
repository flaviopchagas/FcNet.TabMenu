using System;
using System.Windows.Forms;

namespace FcNet.TabMenu
{
    [Serializable]
    public class TabItem : Button
    {
        public TabItem() { }

        public TabItem(string text)
        {
            Text = text;
        }

        public override string Text { get; set; }
    };
}
