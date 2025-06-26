namespace ZombicideGallery.Models
{
    public static class CharacterData
    {
        public static readonly List<Character> InitialCharacters = new List<Character>
        {
            new Character
            {
                Id = 1,
                Name = "Amy",
                ImagePath = "/images/characters/amy.png",
                Description = "A quick and agile survivor specializing in melee combat",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Slippery", "Extra Action", "Melee Expert" }
            },
            new Character
            {
                Id = 2,
                Name = "Doug",
                ImagePath = "/images/characters/doug.png",
                Description = "A seasoned survivor with excellent shooting skills",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Marksman", "Sniper", "Tough" }
            },
            new Character
            {
                Id = 3,
                Name = "Josh",
                ImagePath = "/images/characters/josh.png",
                Description = "A strategic survivor who excels at finding equipment",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Scout", "Lucky", "Search Expert" }
            }
        };
    }
}
