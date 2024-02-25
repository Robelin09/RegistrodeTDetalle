using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class DetallesTickets
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "El campo Emisor es obligatorio.")]
        public string? Emisor { get; set; }

        [Required(ErrorMessage = "El campo Mensaje es obligatorio.")]
        public string? Mensaje { get; set; }
    }
}
