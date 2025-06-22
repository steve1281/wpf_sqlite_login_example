using System.ComponentModel.DataAnnotations;

namespace SQlite_Login_Example
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

    }
}
