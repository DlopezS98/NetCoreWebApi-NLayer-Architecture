using Infrastructure.Entities;
using Infrastructure.Data.Interfaces;

namespace Infrastructure.Data.Repositories;

public class ToDosRepository : EfRepository<ToDo>, IToDoRespository
{
    public ToDosRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public string SayHello()
    {
        return "Hello World (Repository)";
    }
}
