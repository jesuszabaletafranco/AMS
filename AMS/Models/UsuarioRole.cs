using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AMS.Models
{
    public class UsuarioRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Usuario_RoleID { get; set; }
        public int UsuarioID { get; set; }
        public int RoleID { get; set; }
        public int Fecha_Expe { get; set; }
        public int Estado { get; set; }
        public int Fecha_Ultima_Modificacion { get; set; }
    }
}
