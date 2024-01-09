using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Icon is required")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; } = "Expense";
        [NotMapped]

        public string? TitleWithIcon { 
            
            get 
            {
                return this.Title + " " + this.Icon;
             } 
        }
    }
}
    