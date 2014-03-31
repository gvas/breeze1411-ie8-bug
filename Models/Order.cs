using System.ComponentModel.DataAnnotations.Schema;

namespace Breeze1411_IE8_Bug.Models
{
    [Table("Orders")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}