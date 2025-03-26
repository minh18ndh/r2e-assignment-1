using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCarApp;

class Program {
    private static readonly CarService carService = new();

    static void Main() {
        while (true) {
            Console.Write(
            @"
            #########################
            Menu:
            1. Add a Car
            2. View All Cars
            3. Search Car by Make
            4. Filter Cars by Type
            5. Remove a Car by Model
            6. Exit
            #########################
            Enter your choice: ");

            switch (Console.ReadLine()) {
                case "1": carService.AddCar(); break;
                case "2": carService.ViewAllCar(); break;
                case "3": carService.SearchByMake(); break;
                case "4": carService.FilterByType(); break;
                case "5": carService.RemoveByModel(); break;
                case "6": Console.WriteLine("Exiting..."); return;
                default: Console.WriteLine("Invalid! Please choose from 1 to 6."); break;
            }
        }
    }
}