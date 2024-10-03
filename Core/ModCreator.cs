// -------------------------------------------------------------------
// File Path: Core/ModCreator.cs
// Description: Handles creation of basic Sims 4 mods (traits, careers, etc.).
// -------------------------------------------------------------------

using System;
using System.IO;

namespace SimModX.Core
{
    public class ModCreator
    {
        public void CreateTraitMod(string modName, string description)
        {
            string traitFilePath = $"Mods/{modName}_trait.xml";
            string modContent = GenerateTraitXML(modName, description);

            // Save the mod file
            SaveModFile(traitFilePath, modContent);
        }

        private string GenerateTraitXML(string modName, string description)
        {
            return $"<Trait>\n  <Name>{modName}</Name>\n  <Description>{description}</Description>\n</Trait>";
        }

        private void SaveModFile(string path, string content)
        {
            Directory.CreateDirectory("Mods");
            File.WriteAllText(path, content);
            Console.WriteLine($"Mod file saved at: {path}");
        }
    }
}
