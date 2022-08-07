using System.ComponentModel.DataAnnotations;

namespace BookingCinema.Models
{
    public class Actor
    {

        [Key]
        public int ActorId { get; set; }
        public string? ProfilePicUrl { get; set; }

        public string? FullName { get; set; }

        public string? Bio { get; set; }


        public List<Actors_Movie> Actors_Movies { get; set; }

    }
}
