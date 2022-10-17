using System;
using System.ComponentModel.DataAnnotations;
namespace Yad2.Models
{
    public class Message
    {
        [Required]
        public int MessageId { get; set; }

        [Required]
        public string AssetType { get; set; }

        [Required]
        public string AssetCondition { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        public int OverallNumberOfFloors { get; set; }

        //public Boolean OnPillars { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }

        [Required]
        public int ParkingSpots { get; set; }

        [Required]
        public int NumberOfPorches { get; set; }

        public List<AssetProperties> AssetProperties { get; set; }

        public int BuiltSquareMeters { get; set; }

        [Required]
        public int TotalBuildSquareMeters { get; set; }

        public int Price { get; set; }


    }
}
