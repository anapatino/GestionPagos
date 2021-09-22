using System;

namespace Entidad
{
    public class LiquidacionIncapacidad
    {
        private string nombre, apellido,responsable;
        private decimal salarioDevengando,salarioDiario,valorLiquidado,valorNoPercibido,tarifa,valorIncapacidad;
        private int diasIncapacidad,codigo;

        public LiquidacionIncapacidad()
        {

        }
        public LiquidacionIncapacidad(int codigo,string nombre,string apellido,string responsable,decimal salarioDevengando,decimal  salarioDiario,int dias)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Responsable = responsable;
            SalarioDevengando = salarioDevengando;
            SalarioDiario = salarioDiario;
            DiasIncapacidad = dias;
            ValorLiquidado = valorLiquidado;
            ValorNoPercibido = ValorNoPercibido;
            Tarifa = tarifa;
            ValorIncapacidad = valorIncapacidad;
            Codigo = codigo;

        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Responsable { get; set; }
        public decimal SalarioDevengando { get; set; }
        public decimal SalarioDiario { get; set; }
        public int DiasIncapacidad { get; set; }
        public decimal ValorLiquidado{ get; set; }
        public decimal ValorNoPercibido { get; set; }
        public decimal Tarifa { get; set; }
        public decimal ValorIncapacidad { get; set; }
        public int Codigo { get; set; }

        public void CalcularLiquidacion()
        {
            CalcularValorNoPercibido();
            CalcularIncapacidad();
        }
        public void CalcularValorNoPercibido()
        {
            ValorNoPercibido = SalarioDiario * DiasIncapacidad;
            CalcularTarifa();
        }
        public void CalcularIncapacidad()
        {
            ValorIncapacidad = ValorNoPercibido * (Tarifa / 100);
        }

        public  void CalcularTarifa()
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
