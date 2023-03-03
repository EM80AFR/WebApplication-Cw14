namespace web_app.Models
{
    public class ProductRepository
    {
        public List<Product> GeList()
        {
            return DataStorage.Products;
        }
        public Product? GetById(int id)
        {
            return DataStorage.Products.FirstOrDefault(x=>x.Id==id);
        }

        public void CreateProduct(Product prd)
        {
            DataStorage.Products.Add(prd);
        }
    }
}
