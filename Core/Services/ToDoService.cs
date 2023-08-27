using Core.Interfaces;
using Infrastructure.Data.Interfaces;

namespace Core.Services;

public class ToDoService : IToDoService
{
    private readonly IToDoRespository _toDoRespository;

    public ToDoService(IToDoRespository toDoRespository)
    {
        _toDoRespository = toDoRespository;
    }

    public string SayHello()
    {
        return _toDoRespository.SayHello();
    }
}
