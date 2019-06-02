using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();

        public static List<Departaments> GetDepartaments()
        {
            List<Departaments> dep = db.Departaments.ToList();
            dep.Add(new Departaments
            {
                DepartamentsId = 0,
                Nome = "Informe um departamento"
            });

            return dep.OrderBy(x => x.DepartamentsId).ToList();
        }

        public static List<City> GetCities()
        {
            List<City> dep = db.Cities.ToList();
            dep.Add(new City
            {
                CityId = 0,
                Nome = "Informe uma cidade"
            });

            return dep.OrderBy(x => x.CityId).ToList();
        }
                
        public void Dispose()
        {
            db.Dispose();
        }
    }
}