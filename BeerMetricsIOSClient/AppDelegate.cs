using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using BeerMetricsGeneralLibrary;

namespace BeerMetricsIOSClient
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UINavigationController _navController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			var welcomeController = new WelcomeViewController ();
			_navController = new UINavigationController (welcomeController);

			window.RootViewController = _navController;
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}

	class MainMenuController : UIViewController
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.White;

			var button = UIButton.FromType (UIButtonType.RoundedRect);
			button.Frame = new System.Drawing.RectangleF (10, 10, 150, 44);
			button.SetTitle ("Scan Beer", UIControlState.Normal);

			var label = new UILabel (new System.Drawing.Rectangle (10, 70, 300, 44));


			button.TouchUpInside += delegate 
			{
				var scanner = new ZXing.Mobile.MobileBarcodeScanner();
				scanner.Scan().ContinueWith(t => {   
					if (t.Result != null)
					{
						try
						{
							var foundBeer = Engine.Service.LookupBeerFromScanCode (t.Result.Text);
							label.Text = foundBeer.Name;
						}
						catch (Exception e)
						{
							label.Text = "Could not find beer";
						}
					}

				}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext ());
			};

			View.Add (button);
			View.Add (label);
		}
	}






}

