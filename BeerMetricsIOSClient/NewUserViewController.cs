
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BeerMetricsIOSClient
{
	public partial class NewUserViewController : UIViewController
	{
		UINavigationController _navCtrl;

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public NewUserViewController (UINavigationController navCtrl)
			: base (UserInterfaceIdiomIsPhone ? "NewUserViewController_iPhone" : "NewUserViewController_iPad", null)
		{
			_navCtrl = navCtrl;
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			_userNameField.ShouldReturn = delegate {
				_passwordField.BecomeFirstResponder ();
				return true;
			};

			_passwordField.ShouldReturn = delegate {
				_retypePasswordField.BecomeFirstResponder ();
				return true;
			};
			
			_retypePasswordField.ShouldReturn = delegate {
				return _retypePasswordField.ResignFirstResponder ();
			};
		}

		partial void OnCreateNew (MonoTouch.Foundation.NSObject sender)
		{
			_navCtrl.PushViewController (new MainUserController (), false);
			
			this.DismissModalViewControllerAnimated (true);
		}

		partial void OnCancel (MonoTouch.Foundation.NSObject sender)
		{
			this.DismissModalViewControllerAnimated (true);
		}
	}
}

