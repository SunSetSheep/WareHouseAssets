using System.ComponentModel.DataAnnotations;

namespace WareHouseAssets.Models
{
    public class Asset
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? Number_In_Stock { get; set; }
        [Required]
        public string? Supplier { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public string? Department { get; set; }
        [Required]
        public DateOnly LastUpdated { get; set; }


    }
}
