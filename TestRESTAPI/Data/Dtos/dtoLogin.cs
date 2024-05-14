using System.ComponentModel.DataAnnotations;

namespace TestRESTAPI.Data.Dtos
{
    public class dtoLogin
    {
        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }
    }
}
