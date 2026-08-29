
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaApp_Evaluacion_
{

    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Nombre} - {Nacionalidad}";
        }
    }
}

