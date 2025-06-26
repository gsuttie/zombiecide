namespace ZombicideGallery.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;  // Survivor, Runner, Walker, etc.
        public int Health { get; set; }
        public string[] Skills { get; set; } = Array.Empty<string>();
    }
}
