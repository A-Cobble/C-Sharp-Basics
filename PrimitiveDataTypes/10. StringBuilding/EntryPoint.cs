    internal class EntryPoint
    {
        static void Main()
        {
        string nameOfCharacter = "Alex ";
        string spellName = "Fireball";
        int damageTaken = 100;

        string damageReport = "The " + nameOfCharacter + " character took " + damageTaken + "damage from " + spellName;
        string damageReportV2 = string.Format("The {0} character took {1} damage from {2}!", nameOfCharacter, damageTaken, spellName);
        string damageReportV3 = string.Format("The {0} character took {1} damage from {2}, and the character {0} is now dead.", nameOfCharacter, damageTaken, spellName);

        System.Console.WriteLine(damageReport);
        System.Console.WriteLine(damageReportV2);
        System.Console.WriteLine(damageReportV3);

        // $ = string interpolation. allows defined variables to be placed dirrectly into the string
        string damageReportV4 = $"The {nameOfCharacter} character took {damageTaken} damage from {spellName}";

        System.Console.WriteLine(damageReportV4);
        }
    }