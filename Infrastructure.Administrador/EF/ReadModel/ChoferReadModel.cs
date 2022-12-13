using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Administrador.EF.ReadModel
{
    internal class ChoferReadModel
    {
        [Key]
        [Column("choferId")]
        public Guid Id { get; set; }

        [Required]
        [Column("nombreCompleto")]
        [MaxLength(250)]
        public string NombreCompleto { get; set; }

        [Required]
        [Column("direccion")]
        [MaxLength(250)]
        public string Direccion { get; set; }

        [Required]
        [Column("telefono")]
        [MaxLength(250)]
        public string Telefono { get; set; }

        [Required]
        [Column("Modelo")]
        [MaxLength(250)]
        public string Modelo { get; set; }

        [Required]
        [Column("Marca")]
        [MaxLength(250)]
        public string Marca { get; set; }

        [Required]
        [Column("placa")]
        [MaxLength(250)]
        public string Placa { get; set; }

        public ChoferReadModel()
        {
            NombreCompleto = "";
            Direccion = "";
            Telefono = "";
            Modelo = "";
            Marca = "";
            Placa = "";
        }
    }
}
