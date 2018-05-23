using AppPropina.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.Model
{
    public class Propina: Notificable
    {

        private double numeroPersonas;

        public double NumeroPersonas
        {
            get
            {
                return numeroPersonas;
            }

            set
            {
                if (numeroPersonas == value)
                {
                    return;
                }
                numeroPersonas = value;
                OnPropertyChanged();
            }
        }


        private double totalCuenta;

        public double TotalCuenta
        {
            get
            {
                return totalCuenta;
            }

            set
            {
                if (totalCuenta == value)
                {
                    return;
                }
                totalCuenta = value;
                OnPropertyChanged();
            }
        }
        

        private double laPropina;

        public double LaPropina
        {
            get
            {
                return laPropina;
            }

            set
            {
                if (laPropina == value)
                {
                    return;
                }
                laPropina = value;
                OnPropertyChanged();
            }
        }

        private double porcentajePropina;

        public double PorcentajePropina
        {
            get
            {
                return porcentajePropina;
            }

            set
            {
                if (porcentajePropina == value)
                {
                    return;
                }
                porcentajePropina = value;
                OnPropertyChanged();
            }
        }


        private double totalconPropina;

        public double TotalconPropina
        {
            get
            {
                return totalconPropina;
            }

            set
            {
                if (totalconPropina == value)
                {
                    return;
                }
                totalconPropina = value;
                OnPropertyChanged();
            }
        }


        private double propinaporPersona;

        public double PropinaporPersona
        {
            get
            {
                return propinaporPersona;
            }

            set
            {
                if (propinaporPersona == value)
                {
                    return;
                }
                propinaporPersona = value;
                OnPropertyChanged();
            }
        }

        private double totalporPersona;

        public double TotalporPersona
        {
            get
            {
                return totalporPersona;
            }

            set
            {
                if (totalporPersona == value)
                {
                    return;
                }
                totalporPersona = value;
                OnPropertyChanged();
            }
        }

    }
}
