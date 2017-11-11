using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieReview
    {
       
        public int ReviewID { get; set; }


        [Required(ErrorMessage ="Name is required.")]
        public string Reviewer { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public string Review { get; set; }

    }
}
