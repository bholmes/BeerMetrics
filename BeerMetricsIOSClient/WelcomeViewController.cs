
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BeerMetricsIOSClient
{
	public partial class WelcomeViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public WelcomeViewController ()
			: base (UserInterfaceIdiomIsPhone ? "WelcomeViewController_iPhone" : "WelcomeViewController_iPad", null)
		{
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
			PresentModalViewController (new LoginViewController (NavigationController), true);
		}

		partial void OnNewUser (MonoTouch.Foundation.NSObject sender)
		{
			PresentModalViewController (new NewUserViewController (NavigationController), true);
		}
	}
}

