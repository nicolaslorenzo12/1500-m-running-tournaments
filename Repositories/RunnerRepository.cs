using _1500_m_race_simulation.Models;
using _1500_m_race_simulation.Repositories.Interfaces;

namespace _1500_m_race_simulation.Repositories
{
    public class RunnerRepository : IRunnerRepository
    {
        public List<Runner> GetAll()
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

            return [.. names.Select((name, index) => new Runner(name, index + 1))];
        }
    }
}