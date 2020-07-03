using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Cenforcasa", 2015, TiposEscuela.Primaria,
            pais : "Rep. Dom.", ciudad : "San Cristobal");

            Escuela.Cursos = new List<Curso>(){
                new Curso{Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso{Nombre = "501", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "501", Jornada = TiposJornada.Noche}
            };

            
                
           

        }
    }
}