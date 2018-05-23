using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropina.View
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;
		}

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {

            var total = decimal.Parse(entTotal.Text);
            var propina = int.Parse(entPropina.Text);
            var personas = int.Parse(entPersonas.Text);

            var totalPropina = (total * (propina / 100)).ToString();
             
            txtPropina.Detail = totalPropina.ToString();
            txtPersona.Detail = (total / personas).ToString();
            txtTotal.Detail = (total+totalPropina).ToString();

        }
 

    }
}
