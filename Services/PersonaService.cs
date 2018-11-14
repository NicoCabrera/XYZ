using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XYZ.Models;

namespace XYZ.Services
{
    public class PersonaService
    {

        public Persona getPersona() {
            Persona persona = new Persona();
            persona.age = 20;
            persona.name = "Nico";
            return persona;
        }
    }
}