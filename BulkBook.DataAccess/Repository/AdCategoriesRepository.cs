using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    internal class AdCategoriesRepository:Repository<AdCategories>,IAdCategoriesRepository
    {
        private ApplicationDbContext _db;
        public AdCategoriesRepository(ApplicationDbContext db):base(db)
        {
          _db= db;
        }

        public void Update(AdCategories obj)
        {
            throw new NotImplementedException();
        }
    }
}
