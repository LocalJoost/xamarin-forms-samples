﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithImages
{
    public class App
    {
        public static Page GetMainPage()
        {
			//
			// NOTE: uncomment the relevant page that you'd like to test
			//

			// C# examples
			var csTab = new TabbedPage ();
			csTab.Children.Add(new LocalImages {Title = "Local", Icon="csharp.png"});
			csTab.Children.Add(new DownloadImages {Title = "Download", Icon="csharp.png"});
			csTab.Children.Add(new EmbeddedImages {Title = "Embedded", Icon="csharp.png"});
//			return csTab;


			// Xaml examples
			var xamlTab = new TabbedPage ();
			xamlTab.Children.Add(new LocalImagesXaml { Title = "Local", Icon="xaml.png"});
			xamlTab.Children.Add(new DownloadImagesXaml {Title = "Downloaded", Icon="xaml.png"});
			xamlTab.Children.Add(new EmbeddedImagesXaml {Title = "Embedded", Icon="xaml.png"});
			return xamlTab;


			//return new LoadingPlaceholder ());
		}
    }
}
