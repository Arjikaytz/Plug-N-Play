using PlugAndPlay.Common;
using PlugAndPlay.Business;
using PlugAndPlay.Data;
using System;
using System.Collections.Generic;

namespace PlugAndPlay
{
    class Program
    {
        static DBGearRepository repo = new DBGearRepository(); 
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Plug & Play Gear Manager ---");
                Console.WriteLine("1. View All Gear");
                Console.WriteLine("2. Add Gear");
                Console.WriteLine("3. Edit Gear");
                Console.WriteLine("4. Delete Gear");
                Console.WriteLine("5. Search Gear by Name");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();
                if (choice == "1") ViewAll();
                else if (choice == "2") AddGear();
                else if (choice == "3") EditGear();
                else if (choice == "4") DeleteGear();
                else if (choice == "5") SearchGear();
                else if (choice == "0") break;
                else Console.WriteLine("Invalid option. Try again.");
            }
        }

        static void ViewAll()
        {
            List<GearItem> all = new List<GearItem>();
            all.AddRange(repo.GetGuitars());
            all.AddRange(repo.GetPedals());
            all.AddRange(repo.GetAmplifiers());

            Console.WriteLine("\nID | Name | Type");
            foreach (var item in all)
            {
                Console.WriteLine($"{item.Id} | {item.Name} | {item.Type}");
            }
        }

        static void AddGear()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter type (Guitar/Pedal/Amplifier): ");
            string type = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Error: Name and type cannot be empty.");
                return;
            }

            GearItem newItem = new GearItem(0, name, type);
            repo.Add(newItem);
            Console.WriteLine("Gear added successfully!");
        }

        static void EditGear()
        {
            Console.Write("Enter gear ID to edit: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Console.Write("New name: ");
            string name = Console.ReadLine();
            Console.Write("New type: ");
            string type = Console.ReadLine();

            GearItem updated = new GearItem(id, name, type);
            repo.Update(updated);
            Console.WriteLine("Gear updated successfully!");
        }

        static void DeleteGear()
        {
            Console.Write("Enter gear ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            repo.Delete(id);
            Console.WriteLine("Gear deleted successfully!");
        }

        static void SearchGear()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            GearItem? item = repo.SearchByName(name);
            if (item != null)
                Console.WriteLine($"Found: {item.Id} | {item.Name} | {item.Type}");
            else
                Console.WriteLine("Gear not found.");
        }
    }
}
