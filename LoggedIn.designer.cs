// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Assignment1
{
    [Register ("LoggedIn")]
    partial class LoggedIn
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton settingsBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UsernameLbl { get; set; }

        [Action ("UIButton6930_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton6930_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (settingsBtn != null) {
                settingsBtn.Dispose ();
                settingsBtn = null;
            }

            if (UsernameLbl != null) {
                UsernameLbl.Dispose ();
                UsernameLbl = null;
            }
        }
    }
}