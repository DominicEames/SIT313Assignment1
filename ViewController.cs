using System;

using UIKit;

namespace Assignment1
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
               loginBtn.TouchDown += (object sender, EventArgs e) =>
            {
                if (PasswordTxt.Text == "password")
                { 
                    LoggedIn controller = this.Storyboard.InstantiateViewController("LoggedIn") as LoggedIn;
                    controller.Username = NameBox.Text;
                    this.NavigationController.PushViewController(controller, true);
                    return; // this navigation controller works and Username is sent to next view controller.
                }
                else
                { 
                    //ErrLbl.Hidden = false; // this works but then, app crashes after gets displayed.
                    //Create Alert
                    var okAlertController = UIAlertController.Create("Error", "Invalid Password!", UIAlertControllerStyle.Alert);

                    //Add Action
                    okAlertController.AddAction(UIAlertAction.Create("Try Again", UIAlertActionStyle.Default, null));

                    // Present Alert
                    PresentViewController(okAlertController, true, null);
                }
                    


            };
            signUpBtn.TouchDown += (object sender, EventArgs e) =>
            { //This chnage of view controller doesnt work it just freazes and then crashes after few seconds.
                UISignUp controllerSign = this.Storyboard.InstantiateViewController("UISignUp") as UISignUp;
                this.NavigationController.PushViewController(controllerSign, true);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
