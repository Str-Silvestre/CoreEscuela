using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.BackgroundColor = ConsoleColor.DarkGray;
            
            var engine = new EscuelaEngine();

            engine.Inicializar(); 

            Printer.WriteTitulo("BIENVENIDOS A LA ESCUELA");        
                        
            ImprimirCursosEscuela(engine.Escuela);

        }
        
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitulo("Cursos de la Escuela");
            
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($" Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                    Printer.Pito();
                }
            }

        }

       
    }
}
