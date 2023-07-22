using dotnet_bistleague.Usecase;

namespace dotnet_bistleague.Repository;

public interface IHelloRepository
{
    string GetMessage();
}

public class HelloRepository: IHelloRepository
{
    public string GetMessage()
    {
        return "World";
    }
}