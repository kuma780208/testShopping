namespace Shopping
{
    public class Address{
        private string streetAddr;
        private string city;
        private string zip;
        private string state;
        private string country;
    }

    public enum orderStatus{
        created,
        shipped,
        delivered,
        canceld,
        refund
    }

    public enum shipmentStatus{
        pending,
        shipped
    }

    public enum accountStatus{
        active,
        blocked,
        archived
    }
}