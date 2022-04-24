namespace Shopping
{
    public class catalog: search
    {
        Dictionary<string,List<product>> productNames;
        Dictionary<string,List<product>> productCategories;
        public List<product> searchByName(string name){
            return productNames[name];
        }
        public List<product> searchByCategory(string category){
            return productCategories[category];
        }
    }
}