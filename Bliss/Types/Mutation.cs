using AutoMapper;
using Bliss.Models;
using Bliss_Application.Exceptions;
using Bliss_Domain.Entities;
using Bliss_Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bliss.Types
{
    public class Mutation
    {
        private readonly IMapper _mapper;

        public Mutation(IMapper mapper)
        {
            _mapper = mapper;
        }


        public Income AddIncome(BlissDBContext context, IncomeInput income)
        {
            var category = context.IncomeCategories.FirstOrDefault(x => x.Id == income.CategoryId); 

            var incomeMapped = _mapper.Map<Income>(income);
            incomeMapped.Category = category;
            incomeMapped.DateAdded = DateTime.UtcNow;
            context.Incomes.Add(incomeMapped);
            context.SaveChanges();
            return incomeMapped;
        }


        public Income UpdateIncome(BlissDBContext context, int Id, IncomeUpdateInput income)
        {
            IncomeCategory category;
            var incomeMapped = _mapper.Map<Income>(income);
            if(income.CategoryId > 0)
            {
                category = context.IncomeCategories.FirstOrDefault(x => x.Id == income.CategoryId);

                if (category == null)
                {
                    throw new NotExistingException(income.CategoryId ?? 0, "IncomeCategory");
                }

                incomeMapped.Category = category;
            }

            var original = context.Incomes.Include(x => x.Category).FirstOrDefault(x => x.Id == Id);

            if (original == null)
            {
                throw new NotExistingException(Id, "Incomes");
            }

            original.Name = incomeMapped.Name ?? original.Name;
            original.Description = incomeMapped.Description ?? original.Description;
            original.Amount = incomeMapped.Amount >= 0 ? incomeMapped.Amount : original.Amount;
            original.Category = incomeMapped.Category ?? original.Category;

            context.SaveChanges();

            return original;
        }

        public void DeleteIncome(BlissDBContext context, int Id)
        {


        }
    }
}
