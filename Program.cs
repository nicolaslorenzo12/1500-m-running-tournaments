using Microsoft.EntityFrameworkCore;
using RunningRaceSimulation.Data;
using RunningRaceSimulation.Exceptions;
using RunningRaceSimulation.RaceSimulation;
using RunningRaceSimulation.Repositories;
using RunningRaceSimulation.Repositories.Interfaces;
using RunningRaceSimulation.Services;
using RunningRaceSimulation.Services.Interfaces;

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

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection")));

var app = builder.Build();

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();