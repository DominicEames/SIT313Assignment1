using Foundation;
using System;
using UIKit;

namespace Assignment1
{
    public partial class UISignUp : UIViewController
    {
        public UISignUp(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            continueBtn.TouchDown += (object sender, EventArgs e) =>
            {
                LoggedIn controller = this.Storyboard.InstantiateViewController("LoggedIn") as LoggedIn;
                controller.Username = userName.Text;
                this.NavigationController.PushViewController(controller, true);
                return; // this navigation controller works and Username is sent to next view controller.
            };
    }
    }
}