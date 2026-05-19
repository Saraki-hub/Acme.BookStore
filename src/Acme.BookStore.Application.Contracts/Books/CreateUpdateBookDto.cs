using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        public string Name { get; set; }= string.Empty;

        [Required]
        public BookLanguage Language { get; set; } = BookLanguage.Undefined;

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;


        [Required]
        public float Price { get; set; }
    }
}
