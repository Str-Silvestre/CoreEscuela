using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Drawing;
using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            var escuela = new Escuela("Cenforcasa", 2015, TiposEscuela.Primaria);
            escuela.Pais = "Rep. Dom.";
            escuela.Ciudad = "San Cristobal";

            escuela.TipoEscuela = TiposEscuela.Primaria;

            escuela.Cursos = new List<Curso>(){
                new Curso{Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add( new Curso{ Nombre = "102", Jornada = TiposJornada.Tarde});
            escuela.Cursos.Add( new Curso{ Nombre = "202", Jornada = TiposJornada.Tarde});

            var otrosCursos = new List<Curso>(){
                new Curso{Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "501", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "501", Jornada = TiposJornada.Noche}
            };

            escuela.Cursos.AddRange(otrosCursos);
            escuela.Cursos.RemoveAll(delegate(Curso cur)
                                       {    
                                           return cur.Nombre == "301";

                                       });

            escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501" && cur.Jornada == TiposJornada.Noche);
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
