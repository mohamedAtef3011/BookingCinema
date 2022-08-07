using System.ComponentModel.DataAnnotations.Schema;

namespace BookingCinema.Models
{
    public class Actors_Movie
    {
        public int MoiveId { get; set; }
        [ForeignKey("MoiveId")]
        public Movie Movie { get; set; }

        
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
    }
}
