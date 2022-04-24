namespace Shopping
{
    public class shoppingCart
    {
        private List<item> items;
        private string cartID;
        public int getTotalCount();
        public bool addItem(item item, int quantity);
        public bool removeItem(item item);
        public double getTotalPrice();
        public List<item> getItems();
        public bool checkOut(); 
    }
}