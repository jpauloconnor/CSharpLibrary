using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace _0._29_Identity
{
    class Program
    {
        static void Main(string[] args)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var result = userManager.Create(new IdentityUser("paul@paul.com"), "Test123");
            var resultTwo = userManager.FindByName("paul@paul.com");
            var resultThree = userManager.FindByName("Some name");
            Console.WriteLine("Worked");
            Console.WriteLine(resultTwo);
            Console.ReadLine();
        }
    }
}
