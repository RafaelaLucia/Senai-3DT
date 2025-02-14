﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSaep.Models
{
    public class Comentarios
    {

        [Key]
        public int Id { get; set; }
        public string Comentario { get; set; }

        [ForeignKey("Perfis")]
        public int IdPerfis { get; set; }
        public Perfis Perfis { get; set; }

        [ForeignKey("Equipamentos")]
        public int IdEquipamentos { get; set; }
        public Equipamentos Equipamentos { get; set; }

        public DateTime Data { get; set; }

        //==================================================
    }
}
