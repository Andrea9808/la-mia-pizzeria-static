namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string _mame { get; set; }
        public string _description { get; set; }
        public string _img { get; set; }
        public decimal _price { get; set; }

        public Pizza() { }

        public Pizza(string mame, string description, string img, decimal price)
        {
            _mame = mame;
            _description = description;
            _img = img;
            _price = price;
        }
    }
}
