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

        public List<AssetProperty> AssetProperties { get; set; }

        public int BuiltSquareMeters { get; set; }

        [Required]
        public int TotalBuildSquareMeters { get; set; }

        public int Price { get; set; }

        [Required]
        public long EntryDate { get; set; } //positive number to indicate entry date, 0 for immediate, 1 for flex

        public List<string> PictureLinks { get; set; }

        public List<string> VideoLinks { get; set; }

        [Required]
        public Contact ContactPerson { get; set; }

        [Required]
        public int SubscriptionType { get; set; }

        [Required]
        public Boolean ExtraMailingOption { get; set; }
    }
}
