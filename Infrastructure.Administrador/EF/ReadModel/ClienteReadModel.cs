using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Administrador.EF.ReadModel
{
    internal class ClienteReadModel
    {
        [Key]
        [Column("clienteId")]
        public Guid Id { get; set; }

        [Required]
        [Column("nombreCompleto")]
        [MaxLength(250)]
        public string NombreCompleto { get; set; }

        [Required]
        [Column("nombreTienda")]
        [MaxLength(250)]
        public string NombreTienda { get; set; }

        [Required]
        [Column("tipoTienda")]
        [MaxLength(250)]
        public string TipoTienda { get; set; }

        [Required]
        [Column("direccion")]
        [MaxLength(250)]
        public string Direccion { get; set; }

        [Required]
        [Column("telefono")]
        [MaxLength(250)]
        public string Telefono { get; set; }

        public ClienteReadModel()
        {
            NombreCompleto = "";
            NombreTienda = "";
            TipoTienda = "";
            Direccion = "";
            Telefono = "";
        }
    }
}
