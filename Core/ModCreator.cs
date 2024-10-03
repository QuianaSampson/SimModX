// -------------------------------------------------------------------
// File Path: Core/ModCreator.cs
// Description: Handles creation of Sims 4 mods (traits, careers, objects) with enhanced XML structure.
// -------------------------------------------------------------------

using System;
using System.IO;

namespace SimModX.Core
{
    public class ModCreator
    {
        // Method to create a trait mod
        public void CreateTraitMod(string modName, string description)
        {
            string traitFilePath = $"Mods/{modName}_trait.xml";
            string modContent = GenerateTraitXML(modName, description);

            // Save the mod file
            SaveModFile(traitFilePath, modContent);
        }

        // Method to create a career mod
        public void CreateCareerMod(string careerName, string description, string careerType)
        {
            string careerFilePath = $"Mods/{careerName}_career.xml";
            string modContent = GenerateCareerXML(careerName, description, careerType);

            // Save the mod file
            SaveModFile(careerFilePath, modContent);
        }

        // Method to create an object mod
        public void CreateObjectMod(string objectName, string objectType, string description)
        {
            string objectFilePath = $"Mods/{objectName}_object.xml";
            string modContent = GenerateObjectXML(objectName, objectType, description);

            // Save the mod file
            SaveModFile(objectFilePath, modContent);
        }

        // Helper method to generate XML for traits with enhanced structure
        private string GenerateTraitXML(string modName, string description)
        {
            return $@"<Trait>
  <Name>{modName}</Name>
  <Description>{description}</Description>
  <Attributes>
    <Attribute>
      <Name>Positive</Name>
      <Value>true</Value>
    </Attribute>
  </Attributes>
</Trait>";
        }

        // Helper method to generate XML for careers with enhanced structure
        private string GenerateCareerXML(string careerName, string description, string careerType)
        {
            return $@"<Career>
  <Name>{careerName}</Name>
  <Type>{careerType}</Type>
  <Description>{description}</Description>
  <Levels>
    <Level>
      <Name>Entry Level</Name>
      <Salary>50</Salary>
    </Level>
    <Level>
      <Name>Mid Level</Name>
      <Salary>100</Salary>
    </Level>
    <Level>
      <Name>Senior Level</Name>
      <Salary>200</Salary>
    </Level>
  </Levels>
</Career>";
        }

        // Helper method to generate XML for objects with enhanced structure
        private string GenerateObjectXML(string objectName, string objectType, string description)
        {
            return $@"<Object>
  <Name>{objectName}</Name>
  <Type>{objectType}</Type>
  <Description>{description}</Description>
  <Properties>
    <Property>
      <Name>Price</Name>
      <Value>100</Value>
    </Property>
  </Properties>
</Object>";
        }

        // Method to save the mod file
        private void SaveModFile(string path, string content)
        {
            Directory.CreateDirectory("Mods");
            File.WriteAllText(path, content);
            Console.WriteLine($"Mod file saved at: {path}");
        }
    }
}
