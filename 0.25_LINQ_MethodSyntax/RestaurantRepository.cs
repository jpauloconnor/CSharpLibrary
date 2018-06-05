using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_LINQ_MethodSyntax
{
    public class RestaurantRepository
    {
        public Restaurant Find(List<Restaurant> restaurantList, int restaurantId)
        {
            Restaurant selectedRestaurant = null;

            selectedRestaurant = restaurantList.FirstOrDefault(r => 
                                    r.RestaurantID == restaurantId);

            return selectedRestaurant;
        }

        public IEnumerable<string> GetRestaurantNames(List<Restaurant> restauranList)
        {
            var query = restauranList.Select(r => r.Name);
            return query;
        }

        public IEnumerable<Restaurant> PrintNames(List<Restaurant> restaurantList)
        {
            var query = restaurantList.OrderBy(r => r.Name);
            return query;
        }

        public IEnumerable<Restaurant> PrintNamesInReverse(List<Restaurant> restaurantList)
        {
            return PrintNames(restaurantList).Reverse();
        }



        public List<Restaurant> Retrieve()
        {
            List<Restaurant> restaurantList = new List<Restaurant>
            {
                new Restaurant()
                {
                    RestaurantID = 1,
                    Name = "DT Kirby's",
                    IsFavorite = true,
                    Manager = "Don"
                },
                new Restaurant()
                {
                    RestaurantID = 2,
                    Name = "Rasta Pasta",
                    IsFavorite = true,
                    Manager = "JC"
                },
                new Restaurant()
                {
                    RestaurantID = 3,
                    Name = "Avogadro's Number",
                    IsFavorite = true,
                    Manager = "Mike"
                },
            };

            return restaurantList;
        }
    }
}
