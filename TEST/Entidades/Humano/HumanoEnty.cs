using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TEST.Entidades.Humano
{
    public class HumanoEnty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Nombre { get; set; }

        public string Sexo { get; set; }
        public int Edad { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
    }
}
