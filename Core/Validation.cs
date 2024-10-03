// -------------------------------------------------------------------
// File Path: Core/Validation.cs
// Description: Handles validation for mod creation.
// -------------------------------------------------------------------

using System;  // Required for Console.WriteLine
using System.Linq;  // Required for array Contains method

namespace SimModX.Core
{
    public static class Validation
    {
        // Method to validate mod name and description
        public static bool ValidateModFields(string name, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Mod name cannot be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(description))
            {
                Console.WriteLine("Description cannot be empty.");
                return false;
            }

            return true;
        }

        // Method to validate career type
        public static bool ValidateCareerType(string careerType)
        {
            var validTypes = new[] { "FullTime", "PartTime", "Freelance" };
            if (!validTypes.Contains(careerType))  // Using Contains method from System.Linq
            {
                Console.WriteLine("Invalid career type. Must be FullTime, PartTime, or Freelance.");
                return false;
            }

            return true;
        }
    }
}
