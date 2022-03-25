

using System.ComponentModel.DataAnnotations;

namespace GestaoDeVeiculos.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string? Montadora { get; set; }

        [StringLength(15)]
        public string? Modelo { get; set; }

        // Placas devem possuir no máximo 7 caracteres
        [StringLength(7)]
        public string? Placa { get; set; }
    }
}
