namespace Shopping
{
    public interface search
    {
         List<product> searchByName(string name);
         List<product> searchByCategory(string category);
    }
}