using KennelCodePattern.Interfaces;
using KennelCodePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern
{
    public class Factory
    {
        
        public static IMenuManager CreateMenu()
        {
            return new MenuManager();
        }


        public static ICustomer CreateCustomer()
        {
            return new Customer();
        }


        public static IAnimal CreateAnimal()
        {
            return new Animal();
        }

        public static IStandardService CreateStandardService()
        {
            return new StandardService();
        }
        public static IWash CreateWash()
        {
            return new Wash();
        }

        public static IClaws CreateClowCutting()
        {
            return new Claws();
        }

        public static IReceipt CreateReceipt()
        {
            return new Receipt();
        }

        public static ISetPrice CreateSetPriceAndName()
        {
            return new SetPrice();
        }
    }
}
