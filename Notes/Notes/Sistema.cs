﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Notes
{
    class Sistema
    {
        StreamWriter TxtCuentas { get; set; }

        public bool VerificarCuenta(int Rut, string Nombre, string Apellido,string Contrasena, string Email, string Carrera)
        {
            Cuenta NuevaCuenta = new Cuenta(Rut,Nombre,Apellido,Contrasena,Email,Carrera);

            TxtCuentas = File.CreateText("Cuentas.txt");
            
            TxtCuentas.Write(Rut.ToString(), Nombre);
            TxtCuentas.Close();
            return true;
        }
    }
}