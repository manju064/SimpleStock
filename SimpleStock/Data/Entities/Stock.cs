using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal PreviousPrice { get; set; }

        public decimal Change { get; set; }

        public decimal ChangePercentage { get; set; }
    }
}
