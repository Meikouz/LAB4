using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    public class Bouquet
    {
        public string Name { get; set; }
        public List<string> Flowers { get; set; } = new List<string>();
        public string Wrapping { get; set; }
        public string Ribbon { get; set; }
        public string Card { get; set; }
        public string Decor { get; set; }
        public string Greenery { get; set; }

        public void AddFlower(string flower)
        {
            Flowers.Add(flower);
        }

        public string GetDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Назва букета: " + Name);
            sb.AppendLine("Квіти: " + (Flowers.Count > 0 ? string.Join(", ", Flowers) : "ще не додано"));
            sb.AppendLine("Зелень: " + (string.IsNullOrEmpty(Greenery) ? "ще не додано" : Greenery));
            sb.AppendLine("Упаковка: " + (string.IsNullOrEmpty(Wrapping) ? "ще не вибрано" : Wrapping));
            sb.AppendLine("Стрічка: " + (string.IsNullOrEmpty(Ribbon) ? "ще не додано" : Ribbon));
            sb.AppendLine("Листівка: " + (string.IsNullOrEmpty(Card) ? "ще не додано" : Card));
            sb.AppendLine("Декор: " + (string.IsNullOrEmpty(Decor) ? "ще не додано" : Decor));
            return sb.ToString();
        }
    }
}