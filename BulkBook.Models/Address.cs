using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.Models
{
    public class Address
    {
    [Key]
    public int Id { get; set; }
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    [ForeignKey("DistrictId")]
    public int DistrictId { get; set; }
    public string FullAddress { get; set; }

    public User User { get; set; }
    public District District { get; set; }


  }
}
