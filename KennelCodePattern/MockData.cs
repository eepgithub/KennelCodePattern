using KennelCodePattern.Interfaces;
using KennelCodePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern
{
    public class MockupDataForTesting
    {
        public static List<IAnimal> CreateMockAnimals()
        {
            
            var animals = new List<IAnimal>
            {
                 new Animal { AnimalName = "Hund1", Owner = new Customer() { UserName = "Test1" }, IsCheckedIn = false, ClawCutting = new Claws() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Animal { AnimalName = "Hund2", Owner = new Customer() { UserName = "Test2" }, IsCheckedIn = true, ClawCutting = new Claws() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Animal { AnimalName = "Hund3", Owner = new Customer() { UserName = "Test3" }, IsCheckedIn = true, ClawCutting = new Claws() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Animal { AnimalName = "Hund4", Owner = new Customer() { UserName = "Test4" }, IsCheckedIn = false, ClawCutting = new Claws() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } }
            };
            return animals;
        }

        public static List<ICustomer> CreateMockCustomers()
        {
            
            var customers = new List<ICustomer>
            {
                new Customer { SSO = 1, UserName = "Test5", Email = "mail1@test.com", PhoneNo = 0712345678, Animals = new() {}, },
                new Customer { SSO = 1, UserName = "Test6", Email = "mail2@test.com", PhoneNo = 0787654321, Animals = new() { } },
                new Customer { SSO = 1, UserName = "Test7", Email = "Mail3@test.com", PhoneNo = 0712312332, Animals = new() { } },
                new Customer { SSO = 1, UserName = "Test8", Email = "mail4@test.com", PhoneNo = 0745665634, Animals = new() { } }
            };
            return customers;
        }
    }
}
