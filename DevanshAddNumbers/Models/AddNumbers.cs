using System.ComponentModel.DataAnnotations;

namespace DevanshAddNumbers.Models
{
    public class AddNumbers
    {
        // Data Member::
        [Required(ErrorMessage ="Number Can't Be Empty!!")]
        [Range(1,100)]
        public int? Number1 { get; set; }
        [Required]
        [Range(1, 100)]
        public int? Number2 { get; set; }
        // Member Fun::

        public int? Sum()
        {
            return Number1 + Number2;
        }
    }
}
