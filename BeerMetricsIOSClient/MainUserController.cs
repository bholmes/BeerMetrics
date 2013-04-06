
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using BeerMetricsGeneralLibrary;

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

		partial void OnScan (MonoTouch.Foundation.NSObject sender)
		{
			var scanner = new ZXing.Mobile.MobileBarcodeScanner();
			scanner.Scan().ContinueWith(t => {   
				if (t.Result != null)
				{
					//Console.WriteLine("Scanned Barcode: " + t.Result.Text);
					var newCtrl = new UIViewController ();
					var beer = Engine.Service.LookupBeerFromScanCode (t.Result.Text);
					newCtrl.Title = beer.Name;
					newCtrl.View.BackgroundColor = UIColor.White;
					NavigationController.PushViewController (newCtrl, false);
				}
			}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext ());
		}
	}
}

