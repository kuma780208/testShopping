namespace Shopping
{
    public class shipment
    {
        private string shipmentID;
        private string trackingNumber;
        private shipmentStatus status;
        private Date shipmentDate;
        public shipmentStatus checkStauts();
        public string getTrackingNumber();
    }
}