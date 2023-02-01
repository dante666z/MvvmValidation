using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmValidation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SiguientePag : ContentPage
	{
		public SiguientePag (string text)
		{
            string variable = text;

            InitializeComponent ();
            BindingContext = new VM_SiguientePag(variable);
		}
	}
}