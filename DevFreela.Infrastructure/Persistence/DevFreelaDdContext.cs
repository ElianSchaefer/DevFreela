using DevFreeela.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{

    public class DevFreelaDdContext
    {
        public DevFreelaDdContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha descrição de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha descrição de projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha descrição de projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Elian Schaefer", "elianfsf@gmail.com", new DateTime(1992, 1, 1)),
                new User("Pedro Batoré", "pedrinho@gmail.com", new DateTime(1990, 10, 1)),
                new User("Julio Pires", "juliop@gmail.com", new DateTime(1980, 12, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("c#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
