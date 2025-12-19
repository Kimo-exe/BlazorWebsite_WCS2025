namespace Blazor.Models
{
    public class Skater
    {
        public string Naam { get; set; }

        public string Land { get; set; }

        public int Leeftijd { get; set; }

        public string Stance { get; set; }

        public int WorldRanking { get; set; }

        public string Flag { get; set; }
        
        public string Picture { get; set; }

        public Skater(string name, string country, int age, string stance, int rank, string flag, string pic)
        {
            Naam = name;
            Land = country;
            Leeftijd = age;
            Stance = stance;
            WorldRanking = rank;
            Flag = flag;
            Picture = pic;
        }

    }
}
