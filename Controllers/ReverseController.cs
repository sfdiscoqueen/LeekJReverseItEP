
// Jasmine Leek
// 27oct2022
// Reverse It - Endpoints
// this is a webapi that allows a user to input via url, then generates the input in reverse
// peer review: Andrea Burr - i love the code it loks super clean runs great, i really like that there isnt a whole bunch of lines its short and too the point, great job!


using Microsoft.AspNetCore.Mvc;

namespace LeekJReverseItEP.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseController : ControllerBase
{

    [HttpGet]
    [Route("It/{originalInput}")]

    public string ReverseIt(string originalInput)
    {
        string reverseInput = string.Empty;

        for (int i = originalInput.Length - 1; i >= 0; i--)
        {
            reverseInput += originalInput[i];
        }
        return $"\n Voila! \n {originalInput} | {reverseInput} \n";

    }
}