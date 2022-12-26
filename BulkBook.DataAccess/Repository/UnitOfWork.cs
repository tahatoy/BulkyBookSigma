using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;

namespace BulkBook.DataAccess.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType=new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
            OrderHeader=new OrderHeaderRepository(_db);

            Ads = new AdsRepository(_db);
            AdCategories = new AdCategoriesRepository(_db);
            Categories = new CategoriesRepository(_db);
            Cities = new CitiesRepository(_db);
            Deadline = new DeadlineRepoistory(_db);
            District = new DistrictRepository(_db);
            User = new UserRepository(_db);


    }

        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }

        public IProductRepository Product { get; private set; }

        public ICompanyRepository Company { get;private set; }
        public IApplicationUserRepository ApplicationUser { get; set; }
        public IShoppingCartRepository ShoppingCart { get; set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get;private set; }


        public IAdCategoriesRepository AdCategories { get; private set; }

        public IAddressRepository Adress { get;private set; }

        public IAdsRepository Ads { get;private set; }

        public ICategoriesRepository Categories { get;private set; }

        public ICitiesRepository Cities { get;private set; }

        public IDeadlineRepository Deadline { get;private set; }

        public IDistrictRepository District { get;private set; }

        public IUserRepository User { get;private set; }

        public void Save()
        {
           _db.SaveChanges();
           ;
        }
    }
}
