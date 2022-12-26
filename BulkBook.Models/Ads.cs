using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.Models
{
    public class Ads
    {
    [Key]
    public int Id { get; set; }
    [ForeignKey("UserId")]
    public int AdvertiserId { get; set; }
    public int AcceptedUserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    [ForeignKey("CategoriesId")]
    public int CategoryId { get; set; }
    [ForeignKey("AdCategoryId")]
    public int AdCategoryId { get; set; }
    [ForeignKey("DeadlineId")]
    public int DeadlineId { get; set; }

    public AdCategories AdCategories { get; set; }
    public Categories Categories { get; set; }
    public Deadline Deadline { get; set; }
    public User User { get; set; }



  }
}
