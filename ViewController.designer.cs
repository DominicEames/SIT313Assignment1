// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Assignment1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ErrLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton signUpBtn { get; set; }

        [Action ("UIButton199_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton199_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ErrLbl != null) {
                ErrLbl.Dispose ();
                ErrLbl = null;
            }

            if (loginBtn != null) {
                loginBtn.Dispose ();
                loginBtn = null;
            }

            if (NameBox != null) {
                NameBox.Dispose ();
                NameBox = null;
            }

            if (PasswordTxt != null) {
                PasswordTxt.Dispose ();
                PasswordTxt = null;
            }

            if (signUpBtn != null) {
                signUpBtn.Dispose ();
                signUpBtn = null;
            }
        }
    }
}