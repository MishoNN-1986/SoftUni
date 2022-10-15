using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.Models.Home
{
    public class IndexViewModel
    {
        [Display(Name = "Misho")]
        [DataType(DataType.MultilineText)]
        public string Input { get; set; }

        //public int Input2 { get; set; }

        public IEnumerable<string> Usernames { get; set; }
    }
}
