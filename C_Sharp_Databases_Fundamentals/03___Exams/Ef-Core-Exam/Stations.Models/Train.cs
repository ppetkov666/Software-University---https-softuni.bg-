﻿namespace Stations.Models
{
    using Stations.Models.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Train
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public int TrainNumber { get; set; } 

        public TrainType? Type { get; set; }

        public ICollection<TrainSeat> TrainSeats { get; set; } = new List<TrainSeat>();

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();

    }
}
