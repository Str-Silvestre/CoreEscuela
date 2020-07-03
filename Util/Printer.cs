using System.Security.Cryptography.X509Certificates;
using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);

        }

        public static void Pito( int hz = 1000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                Beep(hz, tiempo);
            }

        }
    }
}