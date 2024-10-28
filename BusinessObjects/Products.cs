using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessObjects
{
    public class Products
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(40)]
        public string ProductName { get; set; } =  null!;
        
        [ForeignKey("Categories")]
        public int CategoryID {  get; set; }
        public int? UnitsInStock {  get; set; }
        [Column(TypeName = "money")]
        public decimal? Price {  get; set; }
        public Categories Categories { get; set; } = null!;
    }
}
