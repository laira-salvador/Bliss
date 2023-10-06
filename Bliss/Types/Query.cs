using AutoMapper;
using Bliss_Domain.Entities;
using Bliss_Infrastructure.Data;
using Bliss_Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Bliss.Types
{
    public class Query
    {
        private readonly IMapper _mapper;

        public Query(IMapper mapper)
        {
            _mapper = mapper;
        }

        //[UsePaging]
        public IQueryable<Bank> Banks(BlissDBContext context)
        {
            return context.Banks;
        }

        public Bank Bank(BlissDBContext context, int Id)
        {
            return context.Banks.FirstOrDefault(x => x.Id == Id);
        }

        public IQueryable<Jar> Jars(BlissDBContext context) {
            return context.Jars;
        }
        
        public IQueryable<IncomeCategory> IncomeCategories(BlissDBContext context)
        {
            return context.IncomeCategories;
        }

        public IQueryable<ExpenseCategory> ExpenseCategories(BlissDBContext context)
        {
            return context.ExpenseCategoroes;
        }

        public IQueryable<Income> Incomes(BlissDBContext context, bool IsDeleted = false)
        {
           return context.Incomes.Include(x => x.Category).Where(x => x.IsDeleted == IsDeleted);
           
        }

        public Income Income(BlissDBContext context, int Id) {
            return context.Incomes.Include(x => x.Category).FirstOrDefault(x => x.Id == Id);
        }


        public IQueryable<Expense> Expenses(BlissDBContext context, bool IsDeleted = false)
        {
            return context.Expenses;
        }
    }
}
