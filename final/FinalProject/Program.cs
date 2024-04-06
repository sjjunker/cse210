using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Garden Plot Planner!");

        Menu newMenu = new Menu();
        newMenu.DisplayMenu();
    }
}