using CommanderAPI.Models;
using System.Collections.Generic;

namespace CommanderAPI.Data
{
    public class MockCommanderRepo : ICommandorRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Platform = "no se"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Cut bread",
                    Line = "get a knife",
                    Platform = "Linux"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "Make a tea",
                    Line = "put the bag",
                    Platform = "Windows"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            if (id != 1) return null;

            return new Command 
            { 
                Id = 0, 
                HowTo = "Boil an egg", 
                Line = "Boil water", 
                Platform = "no se" 
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
