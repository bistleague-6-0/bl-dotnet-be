using dotnet_bistleague.Repository;

namespace dotnet_bistleague.Usecase;

public interface IHelloUsecase
{
    string GetMessage(string name);
}

public class HelloUsecase: IHelloUsecase
{
    private readonly IHelloRepository _repository;

    public HelloUsecase(IHelloRepository repo)
    {
        this._repository = repo;
    }
    public string GetMessage(string name)
    {
        return "hello " + name + " " + _repository.GetMessage();
        throw new NotImplementedException();
    }
}