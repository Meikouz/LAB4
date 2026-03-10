namespace LAB4
{
    public class SpringBouquetBuilder : BouquetBuilder
    {
        public override void SetName()
        {
            bouquet.Name = "Весняний букет";
        }

        public override void AddMainFlowers()
        {
            bouquet.AddFlower("Тюльпани");
            bouquet.AddFlower("Нарциси");
        }

        public override void AddSecondaryFlowers()
        {
            bouquet.AddFlower("Іриси");
        }

        public override void AddGreenery()
        {
            bouquet.Greenery = "Салал";
        }

        public override void SetWrapping()
        {
            bouquet.Wrapping = "Світло-зелений крафт";
        }

        public override void SetRibbon()
        {
            bouquet.Ribbon = "Жовта стрічка";
        }

        public override void SetCard()
        {
            bouquet.Card = "Листівка: З весняним настроєм";
        }

        public override void SetDecor()
        {
            bouquet.Decor = "Метелики";
        }
    }
}