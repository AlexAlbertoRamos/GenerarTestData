using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    public class Generar
    {
        static Random rnd = new Random();

        private static string dir = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

        public static string Nombre() {

            List<string> Lista = new List<string>();

            using (StreamReader r = new StreamReader(dir + "\\Files\\Nombres.txt")) {
                string linea;
                while ((linea = r.ReadLine()) != null) {
                    Lista.Add(linea);
                }
            }

            return Lista[rnd.Next(0, Lista.Count - 1)];
        }

        public static string Apellido() {

            List<string> Lista = new List<string>();

            using (StreamReader r = new StreamReader(dir + "\\Files\\Apellidos.txt")) {
                string linea;
                while ((linea = r.ReadLine()) != null) {
                    Lista.Add(linea);
                }
            }

            return Lista[rnd.Next(0, Lista.Count - 1)];
        }

        public static int Edad(int min, int max) {
            return rnd.Next(min, max);
        }

        public static double Nota() {
            return (double)rnd.Next(0, 10) + rnd.NextDouble();
        }

        public static string Carnet() {
            string PrimerGrupo = rnd.Next(25, 28).ToString();
            string SegundoGrupo = rnd.Next(1000, 9999).ToString();
            string TercerGrupo = rnd.Next(2010, 2016).ToString();

            return string.Format("{0}-{1}-{2}", PrimerGrupo, SegundoGrupo, TercerGrupo);
        }

        public static DateTime FechaNacimiento() {

            DateTime desde = new DateTime(1990,1,1);
            DateTime hasta = DateTime.Today;

            TimeSpan rango = hasta - desde;

            TimeSpan randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * rango.Ticks));

            return desde + randTimeSpan;
        }

        public static DateTime FechaNacimiento(DateTime desde, DateTime hasta) {
            TimeSpan rango = hasta - desde;

            TimeSpan randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * rango.Ticks));

            return desde + randTimeSpan;
        }
    }
}
