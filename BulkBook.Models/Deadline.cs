using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.Models
{
    public class Deadline
    {
    [Key]
    public int Id { get; set; }
    public DateTime? FirstDate { get; set; }
    public DateTime? LastName { get; set; }
  }
}
