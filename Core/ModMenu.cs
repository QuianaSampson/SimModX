using System;
using SimModX.Core;

namespace SimModX.Core
{
    public class ModMenu
    {
        private ModCreator modCreator;

        public ModMenu()
        {
            modCreator = new ModCreator();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Which mod would you like to create? (1) Trait, (2) Career, or (3) Object:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateTraitMod();
            }
            else if (choice == "2")
            {
                CreateCareerMod();
            }
            else if (choice == "3")
            {
                CreateObjectMod();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting.");
            }
        }

        private void CreateTraitMod()
        {
            Console.WriteLine("Enter the trait name:");
            string traitName = Console.ReadLine();

            Console.WriteLine("Enter the trait description:");
            string traitDescription = Console.ReadLine();

            // Validate user input
            if (string.IsNullOrWhiteSpace(traitName) || string.IsNullOrWhiteSpace(traitDescription))
            {
                Console.WriteLine("Invalid input. Trait name and description cannot be empty.");
                return;
            }

            modCreator.CreateTraitMod(traitName, traitDescription);
            Console.WriteLine("Trait mod creation complete.");
        }

        private void CreateCareerMod()
        {
            Console.WriteLine("Enter the career name:");
            string careerName = Console.ReadLine();

            Console.WriteLine("Enter the career description:");
            string careerDescription = Console.ReadLine();

            Console.WriteLine("Enter the career type (e.g., FullTime, PartTime):");
            string careerType = Console.ReadLine();

            // Validate user input
            if (string.IsNullOrWhiteSpace(careerName) || string.IsNullOrWhiteSpace(careerDescription) || string.IsNullOrWhiteSpace(careerType))
            {
                Console.WriteLine("Invalid input. All fields must be filled.");
                return;
            }

            modCreator.CreateCareerMod(careerName, careerDescription, careerType);
            Console.WriteLine("Career mod creation complete.");
        }

        private void CreateObjectMod()
        {
            Console.WriteLine("Enter the object name:");
            string objectName = Console.ReadLine();

            Console.WriteLine("Enter the object type (e.g., Furniture, Decoration):");
            string objectType = Console.ReadLine();

            Console.WriteLine("Enter the object description:");
            string objectDescription = Console.ReadLine();

            // Validate user input
            if (string.IsNullOrWhiteSpace(objectName) || string.IsNullOrWhiteSpace(objectType) || string.IsNullOrWhiteSpace(objectDescription))
            {
                Console.WriteLine("Invalid input. All fields must be filled.");
                return;
            }

            modCreator.CreateObjectMod(objectName, objectType, objectDescription);
            Console.WriteLine("Object mod creation complete.");
        }
    }
}
