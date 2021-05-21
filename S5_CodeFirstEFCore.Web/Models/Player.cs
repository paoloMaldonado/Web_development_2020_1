using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace S5_CodeFirstEFCore.Web.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Display(Name = "Nombre del futbolista")]
        public string FullName { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Numero de camiseta")]
        public int Dorsal { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Fec. de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int SoccerPositionId { get; set; }

        public virtual SoccerPosition SoccerPosition { get; set; }

    }
}
