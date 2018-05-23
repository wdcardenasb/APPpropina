using System;
using System.Collections.Generic;
using System.Text;

namespace AppNumeroCuatro.ViewModel
{
    using Model;
    using Xamarin.Forms;

    public class PropinaViewModel
    {

        #region Propiedades
          public Propina PropinaModel { get; set; }
          public Command CalcularCommand { get; set; }
        #endregion

        #region Construtor

        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommand = new Command(Calcular);
            
        }



        #endregion


        #region Metodos
        private void Calcular()
        {
            PropinaModel.PropinaTotal = (PropinaModel.Total * PropinaModel.PorcentajePropina) / 100;
            PropinaModel.TotalCuenta = PropinaModel.Total + PropinaModel.PropinaTotal;
            PropinaModel.PropinaPorPersona = PropinaModel.PropinaTotal / PropinaModel.Personas;
            PropinaModel.TotalPorPersona = PropinaModel.Total / PropinaModel.Personas;
          
            // total propina ok ,
                //total, 
                //propina por persona ok,
                 //total por persona ok
        }
        #endregion
    }
}
