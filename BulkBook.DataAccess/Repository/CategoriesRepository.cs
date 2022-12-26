using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    public class CategoriesRepository : Repository<Categories>, ICategoriesRepository
    {
    private ApplicationDbContext _db;

    public CategoriesRepository(ApplicationDbContext db):base(db) 
    {
      _db= db;
    }



    public void Update(Categories obj)
        {
            throw new NotImplementedException();
        }
    }
}
