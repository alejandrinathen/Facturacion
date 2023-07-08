using System.ComponentModel.DataAnnotations;


namespace BusinessObject.Models
{
    public class CustomerType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
