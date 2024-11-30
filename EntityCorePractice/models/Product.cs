using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCorePractice.models;

public class Product
{
    
    [Key] // primary key
    public int Id { get; set; } // get; set; is a property accessor (getter and setter)
    
    public string Name { get; set; } = null!; // non-nullable reference type
    
    [Column(TypeName = "decimal(18, 2)")] // decimal with 18 digits and 2 decimal places
    public decimal Price { get; set; }
    
}