
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BeerMetricsIOSClient
{
	public partial class MainUserController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public MainUserController ()
			: base (UserInterfaceIdiomIsPhone ? "MainUserController_iPhone" : "MainUserController_iPad", null)
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
			
			NavigationItem.HidesBackButton = true;
		}

		partial void OnLogout (MonoTouch.Foundation.NSObject sender)
		{
			NavigationController.PopViewControllerAnimated (true);
		}
	}
}

