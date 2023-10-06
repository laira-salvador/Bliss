using AutoMapper;
using Bliss.Models;
using Bliss_Domain.Entities;

namespace Bliss.Profiles
{
    public class BlissProfile : Profile
    {
        public BlissProfile()
        {
            CreateMap<IncomeCategoryInput, IncomeCategory>();
            CreateMap<Category, IncomeCategory>();
            CreateMap<Category, ExpenseCategory>();
            CreateMap<Income, IncomeInput>();
            CreateMap<IncomeInput, Income>();
            CreateMap<IncomeUpdateInput, Income>();
            CreateMap<Income, IncomeUpdateInput>();

        }
    }
}
