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

        public List<Curso> Curso(string Parametro, string Valor, List<Curso> ListaCursos)
        { //Curso
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
            else if (Parametro == "Nombre")
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getNombre() == Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "Carrera")
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getCarrera() == Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "Facultad")
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getFacultad() == Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "Todos")
            {
                foreach (Curso curso in ListaCursos)
                {
                    resultado.Add(curso);
                }
            }
            return resultado;
        } //Curso

        public List<Apunte> Apunte(string Parametro, string Valor, List<Apunte> ListaApuntes)
        { //Apunte
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
            else if (Parametro == "Autor" && int.TryParse(Valor, out auxParse))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getAutor() == int.Parse(Valor))
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Curso" && int.TryParse(Valor, out auxParse))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getCurso() == int.Parse(Valor))
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Titulo")
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getTitulo() == Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Carrera")
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getCarrera() == Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Todos")
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    resultado.Add(apunte);
                }
            }
            return resultado;
        } //Apunte

        public List<Cuenta> Cuenta(string Parametro, string Valor, List<Cuenta> ListaCuentas)
        { //Cuenta
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
            else if (Parametro == "Nombre")
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getNombre() == Valor)
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "Carrera")
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getCarrera() == Valor)
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "Todos")
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
