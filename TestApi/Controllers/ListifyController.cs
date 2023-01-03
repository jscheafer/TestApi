using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ListifyController : ControllerBase
  {
    static Listify ilistify = new Listify();
    [HttpPost]
    public void Post(int begin = 1, int end = 100)
    {
      //listify.IntList.Clear();
      ilistify.IntList = new Ilistify<int>();

      foreach (int i in Enumerable.Range(begin, end))
      {
        ilistify.IntList.Add(i);
      }

    }
    [HttpGet("{index}")]
    public int Get(int index = 1)
    {
      if (ilistify.IntList[index] != null)
      {
        try
        {
          return (int)ilistify.IntList[index];
        }
        catch
        {
          return -1;
        }
      }else { return -1; }

    }
  }
  }

