using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FcNet.TabMenu
{
    public partial class TabMenu : FlowLayoutPanel
    {
        public TabMenu()
        {
            TabItems.CollectionChanged += TabItems_CollectionChanged;
        }

        private ObservableCollection<Button> _tabItems = new ObservableCollection<Button>();

        [Category("TabMenu"), Description("TabItems"), MergableProperty(false), Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Button> TabItems { get { return _tabItems; } }

        [Category("TabMenu"), Description("TabSize"), MergableProperty(false), Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Size TabSize { get; set; } = new Size(75, 23);

        [Category("TabMenu"), Description("TabMargin"), MergableProperty(false), Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Padding TabMargin { get; set; } = new Padding(3);

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            TabItems.CollectionChanged -= TabItems_CollectionChanged;
            try
            {
                base.OnControlRemoved(e);
                TabItems.Remove((Button)e.Control);
            }
            catch (Exception) { }
            finally { TabItems.CollectionChanged += TabItems_CollectionChanged; }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            TabItems.CollectionChanged -= TabItems_CollectionChanged;
            try
            {
                base.OnControlAdded(e);
                TabItems.Add((Button)e.Control);
            }
            catch (Exception)
            {
                Controls.Remove(e.Control);
                MessageBox.Show("Invalid control. Only Button is acceptable.");
            }
            finally { TabItems.CollectionChanged += TabItems_CollectionChanged; }
        }

        private void TabItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add) { Controls.Add((Control)e.NewItems[0]); }
            else if (e.Action == NotifyCollectionChangedAction.Remove) { Controls.Remove((Control)e.NewItems[0]); }
        }
    }
}

