namespace U7Offer
{
    internal class Article
    {

        public string Title { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public bool IsOnStock { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public string PicturePath { get; set; }
        public Article(string title, string brand, float price, bool isOnStock, int minAge, int maxAge, string picturePath)
        {
            Title = title;
            Brand = brand;
            Price = price;
            IsOnStock = isOnStock;
            MinAge = minAge;
            MaxAge = maxAge;
            PicturePath = picturePath;
        }

        public override string ToString()
        {
            return $"Artikelname:\t{Title}" +
                $"\nMarke:\t\t{Brand}" +
                $"\nPreis:\t\t{Price}" +
                $"\nAuf Lager:\t{(IsOnStock ? "ja" : "nein")}" +
                $"\nAlter:\t\t{((MinAge > 0) ? $"von {MinAge} " : "")}{((MaxAge != 999) ? $"bis {MaxAge}" : "")}";
        }





    }
}
