namespace Shopping
{
    public class productCategory{
        private string name;
        private string description;
    }
    public class product
    {
        private string id;
        private string name;
        private productCategory category;
        private double price;
        private int stock;
        public bool updatePrice(double newPrice){}
        public bool updateStock(int count){}
        public double getPice(){}
        public int getStock(){}
    }
}