using Infrastructure.Entities;

namespace Infrastructure.Data.Interfaces;

public interface IToDoRespository : IAsyncEfRepository<ToDo>
{
    string SayHello();
}
