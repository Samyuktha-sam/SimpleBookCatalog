using SimpleBookCatalog.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace SimpleBookCatalog.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please provide a Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please provide a Author")]

        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Catagory), ErrorMessage ="Please select the Category")]
        public Catagory Category { get; set; }
    }

} 