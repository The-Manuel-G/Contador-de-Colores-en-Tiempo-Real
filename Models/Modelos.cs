using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace colorin.Models;



public class Persona {  

     public string Cedula  { get; set; } = string.Empty;
     public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } =  string.Empty;
     public string foto { get; set; } = string.Empty;
     public string Telefono { get; set; } = string.Empty;
    
}


public class Aplicacion
{
public Persona Persona { get; set; } = new Persona();
    public string Correo { get; set; } = string.Empty;
   
   
    public string Direccion { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } =  string.Empty;
     public string EstadoCivil {get; set; } = string.Empty;

    
     public string Mensaje { get; set ; } = string.Empty;
     public DateTime Fecha{ get; set; } = DateTime.Now;
        public string Profesion { get; set; } = string.Empty;
public List<Persona> Amigos { get; set; } = new List<Persona>();

}


 public class PersonaJCE
    {
        public string Cedula { get; set; } = string.Empty;
        public string Nombres { get; set; }= string.Empty;
        public string Apellido1 { get; set; }= string.Empty;
    
        public string Apellido2 { get; set; } = string.Empty;
        public string FechaNacimiento { get; set; } = string.Empty;
        public string LugarNacimiento { get; set; } = string.Empty;
        public string IdSexo { get; set; } = string.Empty;
        public string IdEstadoCivil { get; set; } = string.Empty;
        public string IDEstatus { get; set; }  = string.Empty;
        public object EstatusCedulaAzul { get; set; } = string.Empty;
        public object CedulaAnterior { get; set; } = string.Empty;
        public bool ok { get; set; } = false;
        public string foto { get; set; } = string.Empty;
    }
public enum PasoDelProceso{

    validacion,
    llenado,
    completo

}

