using Bliss;
using Bliss.Profiles;
using Bliss.Types;
using Bliss_Application.Exceptions;
using Bliss_Application.Interfaces;
using Bliss_Domain.Entities;
using Bliss_Infrastructure.Data;
using Bliss_Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("BlissDB");

builder.Services.AddDbContext<BlissDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(BlissProfile));
builder.Services.AddScoped<IIncomeCategoryService, IncomeCategoryService>();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .RegisterDbContext<BlissDBContext>()
    .AddErrorFilter<BlissErrorFilter>();


var app = builder.Build();

app.MapGraphQL();
app.Run();


