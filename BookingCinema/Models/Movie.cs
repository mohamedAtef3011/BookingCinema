﻿using BookingCinema.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingCinema.Models
{
    public class Movie
    {

        public int MovieID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        public List<Actors_Movie> Actors_Movies { get; set; }


        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }


        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }


    }
}