using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data {
    public class MockCommanderRepo : ICommanderRepo {
        public IEnumerable<Command> GetAppCommands () {
            var commands = new List<Command> {
                new Command { Id = 0, HowTo = "Algo1", Line = "Algo mas1", Plataform = "Algo mas todavia1" },
                new Command { Id = 0, HowTo = "Algo2", Line = "Algo mas2", Plataform = "Algo mas todavia2" },
                new Command { Id = 0, HowTo = "Algo3", Line = "Algo mas3", Plataform = "Algo mas todavia3" }
            };
            return commands;
        }

        public Command GetCommandById (int id) {
            return new Command { Id = 0, HowTo = "Algo", Line = "Algo mas", Plataform = "Algo mas todavia" };
        }
    }
}