// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace BeerMetricsIOSClient
{
	[Register ("NewUserViewController")]
	partial class NewUserViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField _userNameField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _passwordField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _retypePasswordField { get; set; }

		[Action ("OnCreateNew:")]
		partial void OnCreateNew (MonoTouch.Foundation.NSObject sender);

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

			if (_retypePasswordField != null) {
				_retypePasswordField.Dispose ();
				_retypePasswordField = null;
			}
		}
	}
}
