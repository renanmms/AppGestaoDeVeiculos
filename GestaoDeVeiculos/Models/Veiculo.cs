

using System.ComponentModel.DataAnnotations;

namespace GestaoDeVeiculos.Models
{
    // Modelo sugerido pela empresa
    public class Veiculo
    {
        public int Id { get; set; }

        // Data Annotations
        // Limitar o tamanho das strings para evitar estourar o limite do tamanho no banco
        [StringLength(15)]
        public string? Montadora { get; set; }

        [StringLength(15)]
        public string? Modelo { get; set; }

        // Placas devem possuir no máximo 7 caracteres
        [StringLength(7)]
        public string? Placa { get; set; }
    }
}
