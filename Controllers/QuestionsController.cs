/*
Carlos Felipe
10/25/22
Asking Questions - Endpoint
CODE: THis program takes in a user's name and time they woke up and concatenate's those inputs into a sentence
Peer review by :Kent TT. Great job the program works like its supposed to , there was no error at all.
*/
using Microsoft.AspNetCore.Mvc;

namespace FelipeCAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    public string Instructions(){
        return "Type in https://locasthost7257/Questions/\"name\"/\"time you woke up\"";
    }

   [HttpGet]
   [Route("{name}/{time}")]
   public string Concatenation(string name, string time){
    return $"You are {name} and you woke up at {time}";
   }

}
