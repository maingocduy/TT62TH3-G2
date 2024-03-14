using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Entities
{
    public class account
    {
        [Key, Column(Order = 1)]

        public int Id_account { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
