using System.ComponentModel.DataAnnotations;
namespace Yad2.Models
{
    public class AssetProperty
    {
        [Required]
        public int PropertyId { get; set; }

        [Required]
        public string PropretyName { get; set; }
    }
}
