﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Model.Auth;
using backend.Model.Booking;
using backend.Model.Cinemas;
using backend.Model.CinemaRoom;
using backend.Model.Movie;
using backend.Model.Price;
using backend.Model.Product;

namespace backend.Model.CinemaRoom
{
    public class Seats
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string seatsId { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string seatsNumber { get; set; } = "";

        [Required]
        public bool isTaken { get; set; } = false;
        [Required]

        public bool isMiddle { get; set; } = false;

        [Column(TypeName = "varchar(100)")]
        [ForeignKey("cinemaRoom")]
        public string cinemaRoomId { get; set; } = "";

        public cinemaRoom cinemaRoom { get; set; } = null!;

        public List<orderDetailTicket> orderDetail = [];


    }
}
