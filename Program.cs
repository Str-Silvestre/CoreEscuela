using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Cenforcasa", 2015, TiposEscuela.Primaria);
            escuela.Pais = "Rep. Dom.";
            escuela.Ciudad = "San Cristobal";

            escuela.TipoEscuela = TiposEscuela.Primaria;
            escuela.Cursos = new Curso[] {
                new Curso{Nombre = "101"},
                new Curso{Nombre = "201"},
                new Curso{Nombre = "301"}
            };


            ImprimirCursosEscuela(escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=======================");
            WriteLine("Cursos De la Escuela");
            WriteLine("=======================");
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($" Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }

        }

        private static void ImprimirCusos(Curso[] listCursos)
        {
            int contador = 0;
            while (contador < listCursos.LongLength)
            {
                WriteLine($"Nombre: {listCursos[contador].Nombre}, Id: {listCursos[contador].UniqueId} ");

                contador++;
            }
        }
    }
}
