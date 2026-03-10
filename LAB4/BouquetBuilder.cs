namespace LAB4
{
    public abstract class BouquetBuilder
    {
        protected Bouquet bouquet;

        public void CreateBouquet()
        {
            bouquet = new Bouquet();
        }

        public Bouquet GetBouquet()
        {
            return bouquet;
        }

        public abstract void SetName();
        public abstract void AddMainFlowers();
        public abstract void AddSecondaryFlowers();
        public abstract void AddGreenery();
        public abstract void SetWrapping();
        public abstract void SetRibbon();
        public abstract void SetCard();
        public abstract void SetDecor();
    }
}