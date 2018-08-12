using Foundation;
using System;
using UIKit;

namespace Assignment1
{
    public partial class LoggedIn : UIViewController
    {
        public LoggedIn(IntPtr handle) : base(handle)
        {
        }
        public string Username
        {
            get;
            set;
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            UsernameLbl.Text = Username;

            string[] data = new string[] { "Waitier", "Bartender", "Barista", "Chef", "Dishwasher", "Hostess", "Sommelier" };
            // Perform any additional setup after loading the view, typically from a nib.
            UITableView _table;
            _table = new UITableView
            {
                Frame = new CoreGraphics.CGRect(0, 250, View.Bounds.Width, View.Bounds.Height),
                Source = new TableSource(data)
            };
            View.AddSubview(_table);
            settingsBtn.TouchDown += (object sender, EventArgs e) =>
            {
                UIJobDescription controller = this.Storyboard.InstantiateViewController("UIJobDescription") as UIJobDescription;
                this.NavigationController.PushViewController(controller, true);
                return; // this navigation controller works and Username is sent to next view controller.
            };
        }
    }
}
