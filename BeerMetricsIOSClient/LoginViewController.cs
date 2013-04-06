
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BeerMetricsIOSClient
{
	public partial class LoginViewController : UIViewController
	{
		UINavigationController _navCtrl;

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public LoginViewController (UINavigationController navCtrl)
			: base (UserInterfaceIdiomIsPhone ? "LoginViewController_iPhone" : "LoginViewController_iPad", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void OnLogin (MonoTouch.Foundation.NSObject sender)
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

