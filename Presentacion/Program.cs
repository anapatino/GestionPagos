using System;
using Logica;
using Entidad;
namespace Presentacion
{
    class Program
    {
        private static readonly LiquidacionService liquidacionService = new LiquidacionService();
        static void Main(string[] args)
        {
            char seguir = 'S';
            do
            {
                int opcion = Menu();
                switch (opcion)
                {
                    case 1:Guardar();
                        break;
                    case 2: seguir = 'N';
                        break;
                }
            } while (seguir=='S');
        }

        public static int Menu()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("------------Bienvenido--------------");
            Console.WriteLine("1.Registrar Datos");
            Console.WriteLine("2.Salir");
            Console.WriteLine();
            Console.Write("   Elija su opcion : ");
            do
            {
                opcion = int.Parse(Console.ReadLine());

            } while (opcion < 1 && opcion > 2);
            return opcion;
        }
        public static void Guardar()
        {
            Console.Clear();
            Console.WriteLine("------------Registro--------------");
            Console.WriteLine();
            var persona = RegistrarDatos();
            string mensaje = liquidacionService.Guarda(persona);
            Console.WriteLine($"   {mensaje}");
            Console.Write("          Pulse una tecla para salir "); Console.ReadKey();
        }


        public static LiquidacionIncapacidad RegistrarDatos()
        {
            Console.Clear();
            LiquidacionIncapacidad persona;
            string nombre, apellido, responsable="";
            decimal salarioDevengando, salarioDiario,salarioMinimo= (decimal)908.526;
            int dias,codigoLiquidacion;

            Console.Write("Nombre               : ");nombre = Console.ReadLine();
            Console.Write("Apellido             : ");apellido = Console.ReadLine();
            do
            {
                Console.Write("Salario Devengando   : "); salarioDevengando = decimal.Parse(Console.ReadLine());
            } while (salarioDevengando<salarioMinimo);
            Console.Write("Salario Diario       : ");salarioDiario = decimal.Parse(Console.ReadLine());
            Console.Write("Dias de Incapacidad  : ");dias = int.Parse(Console.ReadLine());
            Random codigo = new Random();
            codigoLiquidacion=(codigo.Next(100, 999));


            if (dias<=2)
            {
                responsable ="EMPLEADOR";
            }
            else if ((dias >3 )&& (dias < 90))
            {
                responsable ="EPS";
            }

            persona = new(codigoLiquidacion,nombre, apellido, responsable, salarioDevengando, salarioDiario, dias);
            persona.CalcularLiquidacion();
         
            return persona;
        }

        public static void ConsultarRegistro(LiquidacionIncapacidad persona)
        {
            Console.Clear();
            Console.WriteLine($"Nombre               : {persona.Nombre}"); 
            Console.WriteLine($"Apellido             : {persona.Apellido}"); 
            Console.WriteLine($"Salario Devengando   : {persona.SalarioDevengando}"); 
            Console.WriteLine($"Salario Diario       : {persona.SalarioDiario}"); 
            Console.WriteLine($"Dias de Incapacidad  : {persona.DiasIncapacidad}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Responsable a Pagar ( {persona.Responsable})");
            Console.WriteLine($"Valor dejado de Percibir ({persona.ValorNoPercibido})");
            Console.WriteLine($"TARIFA DE ({persona.Tarifa})");
            Console.WriteLine($"Valor calculado incapacidad ({persona.ValorIncapacidad}) ");
          
            Console.ReadKey();
        }
    }
 } 
  

    
  


