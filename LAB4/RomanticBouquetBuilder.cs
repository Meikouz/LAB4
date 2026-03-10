namespace LAB4
{
    public class RomanticBouquetBuilder : BouquetBuilder
    {
        public override void SetName()
        {
            bouquet.Name = "Романтичний букет";
        }

        public override void AddMainFlowers()
        {
            bouquet.AddFlower("Червоні троянди");
            bouquet.AddFlower("Червоні троянди");
            bouquet.AddFlower("Червоні троянди");
        }

        public override void AddSecondaryFlowers()
        {
            bouquet.AddFlower("Білі еустоми");
        }

        public override void AddGreenery()
        {
            bouquet.Greenery = "Евкаліпт";
        }

        public override void SetWrapping()
        {
            bouquet.Wrapping = "Рожева матова упаковка";
        }

        public override void SetRibbon()
        {
            bouquet.Ribbon = "Атласна червона стрічка";
        }

        public override void SetCard()
        {
            bouquet.Card = "Листівка: З любов’ю";
        }

        public override void SetDecor()
        {
            bouquet.Decor = "Перлини";
        }
    }
}