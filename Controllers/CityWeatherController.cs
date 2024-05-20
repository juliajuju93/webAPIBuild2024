using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webAPIBuild2024.Controllers;

[ApiController]
[Route("[controller]")]
public class CityWeatherController : ControllerBase
{
    private static readonly string[] Cities = new[]
    {
       "Redmond", "Bellevue", "Kirkland", "Sammamish", "Issaquah"
    };

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet(Name = "GetCityWeather")]
    public ActionResult Get()
    {
        var rng = new Random();
        return Ok(new
        {
            City = Cities[rng.Next(Cities.Length)],
            Summary = Summaries[rng.Next(Summaries.Length)]
        });
    }
}
