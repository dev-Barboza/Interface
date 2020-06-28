namespace Interface
{
    public interface ICarrinho
    {

        
        void Create(Product product);

        void Read();

        void Update(int _code, Product product);

        void Delete(Product product);


    }
}