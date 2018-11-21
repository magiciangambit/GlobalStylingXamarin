using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsingGlobalStyles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GlobalResourceDictionary : ResourceDictionary
    {
		public GlobalResourceDictionary ()
		{
			InitializeComponent ();
		}
	}
}