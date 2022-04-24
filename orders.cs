namespace Shopping
{
    public class orders
    {
        private string orderID;
        private double amount;
        private List<item> items;
        private Date placeDate;
        private orderStatus status;
        public status checkStatus();
        public bool updateStatus();
        public bool shipOrder();
    }
}