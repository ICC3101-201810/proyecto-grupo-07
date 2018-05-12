using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    public class Buscar
    {
        int auxParse;

        public Buscar() { }

        public List<Curso> Curso(string xParametro, string Valor, List<Curso> ListaCursos)
        { //Curso
            string Parametro = xParametro.ToUpper();
            Console.WriteLine(Parametro);
            List<Curso> resultado = new List<Curso>() { };
            if (Parametro == "ID" && int.TryParse(Valor, out auxParse))
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getID() == int.Parse(Valor))
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "NOMBRE")
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getNombre() == Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "CARRERA")
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getCarrera() == Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "FACULTAD")
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getFacultad() == Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "TODOS")
            {
                foreach (Curso curso in ListaCursos)
                {
                    resultado.Add(curso);
                }
            }
            return resultado;
        } //Curso

        public List<Apunte> Apunte(string xParametro, string Valor, List<Apunte> ListaApuntes)
        { //Apunte
            string Parametro = xParametro.ToUpper();
            List<Apunte> resultado = new List<Apunte>() { };
            if (Parametro == "ID" && int.TryParse(Valor, out auxParse))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getID() == int.Parse(Valor))
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "AUTOR" && int.TryParse(Valor, out auxParse))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getAutor() == int.Parse(Valor))
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "CURSO" && int.TryParse(Valor, out auxParse))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getCurso() == int.Parse(Valor))
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "TITULO")
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getTitulo() == Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "CARRERA")
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getCarrera() == Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "TODOS")
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    resultado.Add(apunte);
                }
            }
            return resultado;
        } //Apunte

        public List<Cuenta> Cuenta(string xParametro, string Valor, List<Cuenta> ListaCuentas)
        { //Cuenta
            string Parametro = xParametro.ToUpper();
            List<Cuenta> resultado = new List<Cuenta>() { };
            if (Parametro == "RUT" && int.TryParse(Valor, out int v))
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getRut() == int.Parse(Valor))
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "NOMBRE")
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getNombre() == Valor)
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "CARRERA")
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getCarrera() == Valor)
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "TODOS")
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    resultado.Add(cuenta);
                }
            }
            return resultado;
        } //Cuenta
    }
}
