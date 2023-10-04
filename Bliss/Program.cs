using Bliss_Domain.Entities;
using Bliss_Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("BlissDB");

builder.Services.AddDbContext<BlissDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .RegisterDbContext<BlissDBContext>();


var app = builder.Build();

app.MapGraphQL();




app.Run();

public class Query
{

    //[UsePaging]
    public IQueryable<Bank> Banks(BlissDBContext context)
    {
        return context.Banks;
    }

    public Bank Bank(BlissDBContext context, int Id) {
        return context.Banks.FirstOrDefault(x => x.Id == Id);
    }

    public IQueryable<Jar> Jars(BlissDBContext context) {
        return context.Jars;
    }

    public IQueryable<IncomeCategory> IncomeCategories(BlissDBContext context) {
        return context.IncomeCategories;
    }

    public IQueryable<ExpenseCategory> ExpenseCategories(BlissDBContext context) {
        return context.ExpenseCategoroes;
    }

    public IQueryable<Income> Incomes(BlissDBContext context, bool IsDeleted = false)
    {
        return context.Incomes.Where(x => x.IsDeleted == IsDeleted);
    }

    public IQueryable<Expense> Expenses(BlissDBContext context, bool IsDeleted = false)
    {
        return context.Expenses;
    }

}


public class Mutation
{
    [UseMutationConvention]
    public Income AddIncome(BlissDBContext context, Income income) {



        context.Incomes.Add(income);
        context.SaveChanges();
        return income;
    }
}

