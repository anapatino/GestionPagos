using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Eps:LiquidacionIncapacidad
    {
        public Eps()
        {

        }
        public Eps(string nombre, string apellido, string responsable, decimal salarioDevengando, decimal salarioDiario, int dias)
             : base(nombre, apellido, responsable, salarioDevengando, salarioDiario, dias)
        {

        }

        public override void CalcularTarifa()
        {
            if (DiasIncapacidad <= 15)
            {
                Tarifa = (decimal)66.66;

            }
            else if ((DiasIncapacidad > 15) && (DiasIncapacidad <= 90))
            {
                Tarifa = (decimal)60;
            }
            else
            {
                Tarifa = 0;
            }
        }
    }


}
