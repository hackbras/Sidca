namespace SidcaMrv2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public int id { get; set; }

        [StringLength(255)]
        public string nome { get; set; }

        [StringLength(255)]
        public string senha { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(255)]
        public string cargo { get; set; }

        [StringLength(255)]
        public string Gestor { get; set; }

        [StringLength(50)]
        public string Setor { get; set; }

        [StringLength(255)]
        public string ComputadorNome { get; set; }
    }
}
