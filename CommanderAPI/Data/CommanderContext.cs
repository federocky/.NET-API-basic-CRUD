using CommanderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderAPI.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        //map to a representation of this model in db called Commands
        public DbSet<Command> Commands { get; set; }

    }
}
