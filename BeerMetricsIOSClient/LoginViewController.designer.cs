// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace BeerMetricsIOSClient
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField _userNameField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _passwordField { get; set; }

		[Action ("OnLogin:")]
		partial void OnLogin (MonoTouch.Foundation.NSObject sender);

		[Action ("OnCancel:")]
		partial void OnCancel (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_userNameField != null) {
				_userNameField.Dispose ();
				_userNameField = null;
			}

			if (_passwordField != null) {
				_passwordField.Dispose ();
				_passwordField = null;
			}
		}
	}
}
