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
            },
            new Character
            {
                Id = 4,
                Name = "Wanda",
                ImagePath = "/images/characters/wanda.png",
                Description = "A former police officer with exceptional leadership skills",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Leadership", "Tactician", "Quick Reflexes" }
            },
            new Character
            {
                Id = 5,
                Name = "Ned",
                ImagePath = "/images/characters/ned.png",
                Description = "A resourceful mechanic who can craft weapons",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Craftsman", "Engineer", "Resourceful" }
            },
            new Character
            {
                Id = 6,
                Name = "Elle",
                ImagePath = "/images/characters/elle.png",
                Description = "A former athlete with incredible speed and agility",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Sprint", "Parkour", "Athletic" }
            },
            new Character
            {
                Id = 7,
                Name = "Bruce",
                ImagePath = "/images/characters/bruce.png",
                Description = "A battle-hardened veteran with combat expertise",
                Type = "Survivor",
                Health = 4,
                Skills = new[] { "Combat Training", "Heavy Weapons", "Resilient" }
            },
            new Character
            {
                Id = 8,
                Name = "Derek",
                ImagePath = "/images/characters/derek.png",
                Description = "A stealthy hunter with excellent survival skills",
                Type = "Survivor",
                Health = 3,
                Skills = new[] { "Stealth", "Hunter", "Survival Expert" }
            },
            new Character
            {
                Id = 9,
                Name = "Phil",
                ImagePath = "/images/characters/phil.png",
                Description = "A former firefighter with incredible strength",
                Type = "Survivor",
                Health = 4,
                Skills = new[] { "Strong", "Break Door", "Fire Resistant" }
            }
        };
    }
}