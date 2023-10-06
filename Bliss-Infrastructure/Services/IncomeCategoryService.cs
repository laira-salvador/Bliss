using Bliss_Application.Interfaces;
using Bliss_Domain.Entities;
using Bliss_Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Infrastructure.Services
{
    public class IncomeCategoryService : IIncomeCategoryService
    {
        private readonly BlissDBContext _blissDBContext;

        public IncomeCategoryService(BlissDBContext blissDBContext)
        {
            _blissDBContext = blissDBContext;
        }
        IncomeCategory IIncomeCategoryService.Add(IncomeCategory Category)
        {
            _blissDBContext.IncomeCategories.Add(Category);
            _blissDBContext.SaveChanges();
            return Category;
        }

        IQueryable<IncomeCategory> IIncomeCategoryService.GetAll()
        {
            return _blissDBContext.IncomeCategories;
        }

        IncomeCategory IIncomeCategoryService.GetSingle(int Id)
        {
            return _blissDBContext.IncomeCategories.FirstOrDefault(x => x.Id == Id);
        }
    }
}
