﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Usuario 
    {
        public int UsuarioId {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pass {  get; set; }
        public int Rol_Id { get; set; }
    }
}
