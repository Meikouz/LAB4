namespace LAB4
{
    public class WeddingBouquetBuilder : BouquetBuilder
    {
        public override void SetName()
        {
            bouquet.Name = "Весільний букет";
        }

        public override void AddMainFlowers()
        {
            bouquet.AddFlower("Білі троянди");
            bouquet.AddFlower("Півонії");
        }

        public override void AddSecondaryFlowers()
        {
            bouquet.AddFlower("Гіпсофіла");
        }

        public override void AddGreenery()
        {
            bouquet.Greenery = "Рускус";
        }

        public override void SetWrapping()
        {
            bouquet.Wrapping = "Біла прозора упаковка";
        }

        public override void SetRibbon()
        {
            bouquet.Ribbon = "Біла мереживна стрічка";
        }

        public override void SetCard()
        {
            bouquet.Card = "Листівка: Щастя молодятам";
        }

        public override void SetDecor()
        {
            bouquet.Decor = "Міні-брошка";
        }
    }
}