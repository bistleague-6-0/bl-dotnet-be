using dotnet_bistleague.Usecase;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_bistleague.Controllers;

[ApiController]
[Route("api/test")]
public class HelloWorldController: ControllerBase
{
    private readonly IHelloUsecase _usecase;
    public HelloWorldController(IHelloUsecase usecase)
    {
        this._usecase = usecase;
    }
    [HttpGet]
    public IActionResult Get() {
        var data = new
        {
            Message = _usecase.GetMessage("dika"),
            Timestamp = DateTime.UtcNow
        };
        return Ok(data);
    }
}