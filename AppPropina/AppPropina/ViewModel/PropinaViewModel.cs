using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.ViewModel
{

    using Model;
    using Xamarin.Forms;

    class PropinaViewModel
    {
        #region Propiedades

        public Propina PropinaModel { get; set; }
        public Command CalcularCommand { get; set; }

        #endregion

        #region Constructores

        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommand = new Command(Calcular);
        }

        private void Calcular(object obj) {

            PropinaModel.LaPropina = (PropinaModel.TotalCuenta * PropinaModel.PorcentajePropina) / 100;
            PropinaModel.TotalconPropina = PropinaModel.LaPropina + PropinaModel.TotalCuenta;

            PropinaModel.PropinaporPersona = PropinaModel.LaPropina / PropinaModel.NumeroPersonas;
            PropinaModel.TotalporPersona = PropinaModel.PropinaporPersona + (PropinaModel.TotalCuenta / PropinaModel.NumeroPersonas);
             
        }

        #endregion


    }
}
