using System.Diagnostics;

namespace MauiApp1
{
    public partial class TabbedPage : Microsoft.Maui.Controls.TabbedPage
    {
        int count = 0;

        public TabbedPage()
        {
            InitializeComponent();
        }

        private void TabbedPage_SizeChanged(object sender, EventArgs e)
        {
            //Task.Delay(1000).ContinueWith(t =>
            //{
            //    this.Dispatcher.Dispatch(() =>
            //    {
            //        this.ForceLayout();
            //        this.UpdateChildrenLayout();
                    
            //        foreach(var c in this.Children)
            //        {
            //            c.ForceLayout();
            //            this.UpdateChildrenLayout();
            //            Debug.WriteLine("Layout " + DateTime.Now.Ticks);
            //        }
            //    });
            //});
        }
    }

}
