using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Buscar
    {
        public Buscar() { }
        
        public List<Curso> Curso(string Parametro, object Valor, List<Curso> ListaCursos)
        { //Curso
            List<Curso> resultado = new List<Curso>() { };
            if(Parametro=="ID" && (Valor is int))
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getID() == (int)Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if(Parametro=="Nombre" && (Valor is string))
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getNombre() == (string)Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if(Parametro=="Carrera" && (Valor is string))
            {
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getCarrera() == (string)Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if(Parametro=="Facultad" && (Valor is string))
            { 
                foreach (Curso curso in ListaCursos)
                {
                    if (curso.getFacultad() == (string)Valor)
                    {
                        resultado.Add(curso);
                    }
                }
            }
            else if (Parametro == "Todos")
            {
                foreach(Curso curso in ListaCursos)
                {
                    resultado.Add(curso);
                }
            }
            return resultado;
        } //Curso

        public List<Apunte> Apunte(string Parametro ,object Valor, List<Apunte> ListaApuntes)
        { //Apunte
            List<Apunte> resultado = new List<Apunte>() { };
            if (Parametro == "ID" && (Valor is int))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getID() == (int)Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Autor" && (Valor is int))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getAutor() == (int)Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Curso" && (Valor is int))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getCarrera() == (string)Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Titulo" && (Valor is string))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getTitulo() == (string)Valor)
                    {
                        resultado.Add(apunte);
                    }
                }
            }
            else if (Parametro == "Carrera" && (Valor is string))
            {
                foreach (Apunte apunte in ListaApuntes)
                {
                    if (apunte.getCarrera() == (string)Valor)
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

        public List<Cuenta> Cuenta(string Parametro, object Valor, List<Cuenta> ListaCuentas)
        { //Cuenta
            List<Cuenta> resultado = new List<Cuenta>() { };
            if (Parametro == "Rut" && (Valor is int))
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getRut() == (int)Valor)
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "Nombre" && (Valor is string))
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getNombre() == (string)Valor)
                    {
                        resultado.Add(cuenta);
                    }
                }
            }
            else if (Parametro == "Carrera" && (Valor is string))
            {
                foreach (Cuenta cuenta in ListaCuentas)
                {
                    if (cuenta.getCarrera() == (string)Valor)
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
