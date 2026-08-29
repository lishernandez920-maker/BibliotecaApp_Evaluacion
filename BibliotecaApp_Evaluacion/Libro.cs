using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaApp_Evaluacion_
{
    public class Libro
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public int CopiasDisponibles { get; set; }
        public bool Estado { get; set; }
        public int AutorId { get; set; }

        public override string ToString()
        {
            return $"{Codigo} | {Titulo} | {Genero} | ${PrecioAlquiler} | Copias: {CopiasDisponibles}";
        }
    }
}

