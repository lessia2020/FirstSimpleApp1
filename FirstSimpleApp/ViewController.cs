using System;

using AppKit;
using Foundation;

namespace FirstSimpleApp
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        partial void PushButton(NSButton sender)
        {
			Console.WriteLine("Button pushed");
        }
        partial void ResetButton(NSButton sender)
        {
			Console.WriteLine("Reset");
        }
    }
}
