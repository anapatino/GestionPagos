﻿using System;
using Datos;
using Entidad;
namespace Logica
{
    public class LiquidacionService
    {
        readonly LiquidacionRepository liquidacionRepository;
        public LiquidacionService()
        {
            liquidacionRepository = new LiquidacionRepository();
        }
        public string Guarda(LiquidacionIncapacidad persona)
        {
            try
            {
                liquidacionRepository.Guardar(persona);
                return "Su registro se ha guardado con exito!";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Guardar: {e.Message}";
            }
        }


    }
}
