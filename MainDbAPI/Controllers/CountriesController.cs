using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MainDbAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using DataAccess;


namespace MainDbAPI.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        //private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        private readonly string _conString;

        public CountriesController(IConfiguration configuration)
        {
            _configuration = configuration;
            _conString = _configuration.GetConnectionString("DefaultConnection");
            
        }
      
        //[Route("get_country")]
        [HttpGet]
        public IActionResult GetCountries()
        {
            List<CountryModel> countries = new List<CountryModel>();
            var dt = CountryDA.GetCountries();
            foreach (DataRow dataRow in dt.Rows)
            {
                CountryModel countryModel = new CountryModel();
                countryModel.CountryId = Convert.ToInt32(dataRow["CountryId"]);
                countryModel.CountryName = dataRow["CountryName"].ToString();
                countryModel.Description = dataRow.IsNull("Description") ? null : dataRow["Description"].ToString();
                countryModel.CreatedDate = dataRow["CreatedDate"].ToString();
                countries.Add(countryModel);
            }
            return Ok(countries);

        }



        // GET api/<controller>/5
        [HttpGet("{countryId}")]
        public IActionResult GetCountriesById(int countryId)
        {
            List<CountryModel> countriesById = new List<CountryModel>();
            var dt = CountryDA.GetCountryById(countryId);
            foreach (DataRow dataRow in dt.Rows)
            {
                CountryModel countryModel = new CountryModel();
                countryModel.CountryId = Convert.ToInt32(dataRow["CountryId"]);
                countryModel.CountryName = dataRow["CountryName"].ToString();
                countryModel.Description = dataRow.IsNull("Description") ? null : dataRow["Description"].ToString();
                countriesById.Add(countryModel);
            }
            return Ok(countriesById);

        }



        // POST api/<controller>
        [HttpPost("{countryName},{description},{createDate}")]
        public IActionResult Post(string countryName, string description, DateTime createDate)
        {
            CountryDA.Insert(countryName,description,createDate);
            return Ok();

        }


        // PUT api/<controller>/5
        [HttpPut("{countryName},{description},{createDate},{countryId}")]
        public void Put(string countryName, string description, DateTime createDate, int countryId)
        {
            CountryDA.Update(countryName, description, createDate, countryId);
        }



        // DELETE api/<controller>/5
        [HttpDelete("{countryId}")]
        public void Delete(int countryId)
        {
            CountryDA.Delete(countryId);
        }



    }
}
