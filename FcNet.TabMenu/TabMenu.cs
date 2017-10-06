using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FcNet.TabMenu
{
    public partial class TabMenu : FlowLayoutPanel
    {
        public TabMenu() { }

        private TabCollection mTabs = new TabCollection();

        [Category("Behavior"), Description("Tabs"), MergableProperty(false), Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TabCollection Tabs
        {
            get { return mTabs; }
        }

        public Size TabSize { get; set; } = new Size(75, 23);

        public Padding TabMargin { get; set; } = new Padding(3);

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

        }

        protected override void OnParentBindingContextChanged(EventArgs e)
        {
            base.OnParentBindingContextChanged(e);

            if (Tabs != null)
            {
                foreach (TabItem tab in Tabs)
                {
                    //Button bt = new Button()
                    //{
                    //    Text = tab.Text,
                    //    Name = "Foo"
                    //};

                    Controls.Add(tab);
                }
            }

        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);



        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //    //if (Tabs != null)
            //    //{
            //    //    foreach (Button tab in Tabs)
            //    //    {
            //    //        this.Controls.Add(tab);
            //    //    }
            //    //}
        }
    }
}
