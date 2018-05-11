using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Ingresar
    {
        public Ingresar() { }

        public string[] String(string miMensaje)
        {
            if (miMensaje.Count() > 0)
            {
                return new string[] { miMensaje.Trim().ToUpper() };
            }
            return new string[] { };
        }

        public int[] Int(string miMensaje)
        {
            if (int.TryParse(miMensaje.Trim(), out int n))
            {
                return new int[] { int.Parse(miMensaje.Trim()) };
            }
            return new int[] { };
        }

        public int[] Rut(string miRut)
        { //Rut
            //Si es un string vacio, fuera
            if (!(miRut.Trim().Count() > 0))
            {
                return new int[] { };
            }
            //Vemos si termina en k ("Remplacela por un 0")
            char[] auxMiRut = miRut.Trim().ToUpper().ToCharArray();
            if (auxMiRut.Last() == 'K')
            {
                auxMiRut[auxMiRut.Count() - 1] = '0';
            }
            miRut = new string(auxMiRut);
            //Vemos si se ingreso sin puntos ni '-'
            if (int.TryParse(miRut.Trim(), out int n))
            {   //Vemos que sea un numero rasonable
                if ((7 < miRut.Trim().Count()) && (10 > miRut.Trim().Count()))
                {
                    return new int[] { int.Parse(miRut.Trim()) };
                }
            }
            //Si se ingreso solo con '-' (debio haber sido el '.' y '-' antes
            else if (miRut.Trim().Split('-').Count() == 2 && (miRut.Split('.').Count() != 3))
            //Vemos que el resto sean numeros y solo haya uno despues de
            {
                if ((int.TryParse(miRut.Trim().Split('-')[0], out int m)) &&
                   (int.TryParse(miRut.Trim().Split('-')[1], out int j)))
                {  //Que sea un valor rasonable
                    if ((miRut.Trim().Split('-')[0].Trim().Count() < 9) &&
                        (miRut.Trim().Split('-')[0].Trim().Count() > 6) &&
                         miRut.Trim().Split('-')[1].Trim().Count() == 1)
                    {
                        return new int[] { int.Parse(miRut.Trim().Split('-')[0].Trim() +
                                                     miRut.Trim().Split('-')[1].Trim())};
                    }
                }
            }
            //Si se ingreso con puntos y '-'
            else if (miRut.Trim().Contains('.') && miRut.Trim().Contains('-'))
            {   //Se podria haber simplificado muuuucho si simplemente sacaba los espacios blancos al
                //principio, no se me ocurrio antes :(, o tambien se veria mas lindo con variables
                if (miRut.Trim().Split('.').Count() == 3)
                {
                    if (miRut.Trim().Split('.')[2].Contains('-'))
                    {
                        if ((miRut.Trim().Split('.')[0].Trim().Count() < 3) &&
                            (miRut.Trim().Split('.')[1].Trim().Count() == 3) &&
                            (miRut.Trim().Split('.')[2].Trim().Split('-')[0].Trim().Count() == 3) &&
                            (miRut.Trim().Split('.')[2].Trim().Split('-')[1].Trim().Count() == 1) &&
                            (int.TryParse(miRut.Trim().Split('.')[0].Trim(), out int m)) &&
                            (int.TryParse(miRut.Trim().Split('.')[1].Trim(), out int j)) &&
                            (int.TryParse(miRut.Trim().Split('.')[2].Trim().Split('-')[1].Trim(), out int l)) &&
                            (int.TryParse(miRut.Trim().Split('.')[2].Trim().Split('-')[1].Trim(), out int k)))
                        {
                            return new int[] {int.Parse(miRut.Trim().Split('.')[0].Trim() +
                                                        miRut.Trim().Split('.')[1].Trim() +
                                                        miRut.Trim().Split('.')[2].Trim().Split('-')[0].Trim() +
                                                        miRut.Trim().Split('.')[2].Trim().Split('-')[1].Trim()) };
                        }
                    }

                }
            }
            return new int[] { };
        } //Rut
    }
}
