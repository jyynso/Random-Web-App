using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IPT_MVC_Activity.Models
{
    public class Miniature
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Table Ready")]
        public bool TableReady { get; set; } = false;
        public string? Description { get; set; }
        //public List<Miniature> Miniatures { get; set; }
        //public string ControlString { get; set; }
        //public string CurrentUserRole { get; set; }
    }
}
