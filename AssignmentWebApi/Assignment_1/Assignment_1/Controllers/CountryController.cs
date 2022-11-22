using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    public class CountryController : ApiController
    {
        //Creating
        static List<Country> countrylist = new List<Country>
        {
            new Country{ID = 1,CountryName="INDIA",Capital="New Delhi"},
            new Country{ID = 2,CountryName="BANGLADESH",Capital="Dhaka"},
            new Country{ID = 3,CountryName="RUSSIA",Capital = "Moscow"},
            new Country{ID = 4,CountryName="CHINA",Capital = "Beijing"},
            new Country{ID = 5,CountryName="MALAYSIA",Capital = "Kuala Lumpur"},

        };

        //Reading
        public IEnumerable<Country>Get()
        {
            return countrylist;
        }
        //Getting by Id
        public Country Get(int id)
        {
            return countrylist[id-1];
        }
        //Inserting
        public IEnumerable<Country> Post([FromBody]  Country c)
        {
            countrylist.Add(c);
            return countrylist;
        }
        //Updating
        //public IEnumerable<Country> Put(int id, [FromBody] Country c)
        //{
        //    countrylist[id - 1] = c;
        //    return countrylist;
        //}

        //Deleting
        public IEnumerable<Country> Delete(int id)
        {
            countrylist.RemoveAt(id - 1);
            return countrylist;
        }

    }
}
