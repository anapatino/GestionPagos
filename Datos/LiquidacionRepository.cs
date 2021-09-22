using System;
using System.Collections.Generic;
using System.IO;
using Entidad;

namespace Datos
{
    public class LiquidacionRepository
    {
        public string ruta = @"ListaPersonasLiquidadas.txt";
        public void Guardar(LiquidacionIncapacidad persona)
        {
            using StreamWriter escritor = new(ruta, true);
            escritor.WriteLine($"{persona.Codigo};{persona.Nombre};{persona.Apellido};{persona.Responsable};{persona.SalarioDevengando};{persona.SalarioDiario};{persona.DiasIncapacidad};{persona.ValorNoPercibido};{persona.Tarifa};{persona.ValorIncapacidad};{persona.ValorLiquidado}");
        }

    }
}
