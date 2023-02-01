using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace MvvmValidation
{
    public class VM_SiguientePag
    {
        public string NombreParam="";
        private string texto ="Click!";
        public VM_SiguientePag(string n)
        {
            ClickMensaje = new Command(async () => await Mensaje());
            NombreParam = n;
        }
        public Command ClickMensaje { get; set; }

        async Task Mensaje()
        {
            await Application.Current.MainPage.DisplayAlert("The XamSharp blog", "Message", "OK");
        }
        private string nombre ;

        public string NombreUsuario
        {
            get { return nombre = NombreParam; }
            set { nombre = value; }
        }

        public string TextButton 
        {
            get { return texto ; }
            set { texto =value; }
        }
        
    }
}
