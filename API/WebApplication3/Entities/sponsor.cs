using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Entities
{
    public class sponsor
    {
        [Key, Column(Order = 1)]
        public int Id_sponsor { get; set; }
        
        public string name  { get; set; }
        public string contact { get; set; }

        public string address { get; set; }

        public float contributionAmount { get; set; }


    }
}
