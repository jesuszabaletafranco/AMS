using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AMS.Models
{
    public class Usuario
    {
        [Key]
        [Column("usuarioID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [Column("Usuario")]
        [Required]        
        public string NombreUsuario { get; set; }
        [Required]
        public string Numero_Documento { get; set; }
        [Required]
        public string Razon_Social { get; set; }
        [Required]
        public string Primer_Nombre { get; set; }
        [Required]
        public string Segundo_Nombre { get; set; }
        [Required]
        public string Primer_Apellido { get; set; }
        [Required]
        public string Segundo_Apellido { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string UpdatePassword { get; set; }
        [Required]
        public int Tipo_DocumentoID { get; set; }
        [Required]
        public int Tipo_personaID { get; set; }
        [Required]
        public Boolean Estado { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy HH:mm:ss}")]
        public DateTime Fecha_Ultima_Modificacion { get; set; }

        //public ICollection<Usuario> Usuarios { get; set; }
    }
}
