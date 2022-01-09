using KennelCodePattern.Interfaces;
using System;

namespace KennelCodePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenuManager Menumanager = Factory.CreateMenu();

            Menumanager.Menu();
        }
    }
}
