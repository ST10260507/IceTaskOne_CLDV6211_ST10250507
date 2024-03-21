using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IceTaskOne.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string? Instrument { get; set; }
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        public string? Make { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
