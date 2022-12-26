using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }

        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IOrderDetailRepository OrderDetail { get; }
        IOrderHeaderRepository OrderHeader { get; }


        IAdCategoriesRepository AdCategories { get; }
        IAddressRepository Adress { get; }
        IAdsRepository Ads { get; } 
        ICategoriesRepository Categories { get; }
        ICitiesRepository Cities { get; }
        IDeadlineRepository Deadline { get; } 
        IDistrictRepository District { get; }
        IUserRepository User { get; }






        void Save();
    }
}
