using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using trails.models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET: api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();
           runners.Add(new Runner{Id=1, First = "Geoffrey", Last = "Vandiest", Age = 42, FavoriteBeer = "Gueze Boon"  });
           runners.Add(new Runner{Id=2, First = "Nathalie", Last = "Renneson", Age = 42  });
           runners.Add(new Runner{Id=3, First = "Arno", Last = "Vandiest", Age = 13, FavoriteBeer = "Stella"  });
           runners.Add(new Runner{Id=4, First = "Bill", Last = "Vandiest", Age = 10, FavoriteBeer = "Piedbeouf"  });
           return runners.ToArray();
        }
        
        // GET: api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return this.Get().FirstOrDefault(r => r.Id == id);    
        }  
       
        
    }
}
