using System.ComponentModel.DataAnnotations;

namespace BookingCinema.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string? ProfilePicUrl { get; set; }

        public string? FullName { get; set; }

        public string? Bio { get; set; }



        public List<Movie> Movies { get; set; }
    }
}
