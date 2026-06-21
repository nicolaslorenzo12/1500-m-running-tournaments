using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Data.Configurations
{
    public class RunnerConfiguration : IEntityTypeConfiguration<Runner>
    {

        // Builder let's me define how my entitiy maps to the database. I can also seed data using it
        public void Configure(EntityTypeBuilder<Runner> builder)
        {
            var names = new List<string>
            {
                "Jakob Ingebrigtsen",
                "Josh Kerr",
                "Yared Nuguse",
                "Cole Hocker",
                "Narve Gilje Nordas",
                "Timothy Cheruiyot",
                "Abel Kipsang",
                "Neil Gourley",
                "Stewart McSweyn",
                "Oliver Hoare",
                "Samuel Tefera",
                "Azeddine Habz",
                "Isaac Nader",
                "Mohamed Katir",
                "Reynold Cheruiyot",
                "George Mills",
                "Mario García",
                "Adel Mechaal",
                "Pietro Arese",
                "Marcin Lewandowski",
                "Henrik Ingebrigtsen",
                "Filip Ingebrigtsen",
                "Jake Wightman",
                "Hobbs Kessler",
                "Vincent Ciattei",
                "Elliot Giles",
                "Robert Farken",
                "Kieran Lumb",
                "Cameron Myers",
                "Paddy Dever",
                "Luke Houser",
                "Eric Holt",
                "Ben Pattison",
                "Ayanleh Souleiman",
                "Ronald Kwemoi",
                "Silas Kiplagat",
                "Elijah Manangoi",
                "Asbel Kiprop",
                "Taoufik Makhloufi",
                "Matthew Centrowitz",
                "Nick Willis",
                "Bernard Lagat",
                "Mo Farah",
                "James Webb",
                "Daniel Komen",
                "Noah Ngeny",
                "Hicham El Guerrouj",
                "Noureddine Morceli",
                "Sebastian Coe",
                "Steve Ovett",
                "Steve Cram",
                "Said Aouita",
                "Fermín Cacho",
                "Mehdi Baala",
                "Augustine Choge",
                "Mekonnen Gebremedhin",
                "Lopez Lomong",
                "Chris O'Hare",
                "Andrew Wheating",
                "Leo Manzano",
                "Nick Symmonds",
                "Andrés Díaz",
                "Brahim Boulami",
                "Yusuf Saad Kamel",
                "Harun Keitany",
                "Soufiane El Bakkali"
            };

            var runners = names.Select((name, index) => new
            {
                Id = index + 1,
                Name = name,
                Ranking = index + 1
            });

            // Here I am asking builder to seed this data into the database when I run my migrations. This means that when I create the database, it will already have this data in it.
            builder.HasData(runners);
        }
    }
}