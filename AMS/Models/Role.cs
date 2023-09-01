using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AMS.Models
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleID { get; set; }
        public int Grupo_usuarioID { get; set; }
        public string Rol_Nombre { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Fecha_Ultima_Modificacion { get; set; }
    }
}
