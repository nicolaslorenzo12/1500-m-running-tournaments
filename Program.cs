using Microsoft.EntityFrameworkCore;
using running_race_simulation.Data;
using running_race_simulation.RaceSimulation;
using running_race_simulation.Repositories;
using running_race_simulation.Repositories.Interfaces;
using running_race_simulation.Services;
using running_race_simulation.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRunnerRepository, RunnerRepository>();

builder.Services.AddScoped<ITournamentRepository, TournamentRepository>();
builder.Services.AddScoped<ITournamentService, TournamentService>();
builder.Services.AddSingleton<RaceSimulator>();

builder.Services.AddScoped<IRaceRepository, RaceRepository>();

builder.Services.AddScoped<IRaceService, RaceService>();

builder.Services.AddScoped<IRaceSimulator, RaceSimulator>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();