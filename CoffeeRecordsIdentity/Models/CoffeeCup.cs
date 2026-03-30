using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeRecordsIdentity.Models
{
    public class CoffeeCup
    {
        public int CoffeeCupId { get; set; }
        [Display(Name = "Short Name")]
        public string UserName { get; set; } = String.Empty;

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }


        [Display(Name = "Time and date")]
        public DateTime Created { get; set; }
        [Display(Name = "Id of Machine")]
        public int MachineNo { get; set; }
    }
}
