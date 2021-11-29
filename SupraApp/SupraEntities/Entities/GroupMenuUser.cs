﻿using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    public class GroupMenuUser : IEntidad
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Guid GroupMenuId { get; set; }
        public GroupMenu GroupMenu { get; set; }
        public string UserName { get; set; }
        public bool Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime UltimoCambio { get; set; }
    }
}
