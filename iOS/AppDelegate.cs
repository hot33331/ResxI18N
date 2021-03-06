﻿// copyright msg systems ag
// Tobias Hoppenthaler - tobias.hoppenthaler@msg.group
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ResxI18N.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
