namespace SidcaMrv2.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("vw_area")]
    public partial class vw_area
    {
        [Key]
        [StringLength(8000)]
        public string Area { get; set; }
    }
}
