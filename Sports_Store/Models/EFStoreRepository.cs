namespace Sports_Store.Models;


public class EfStoreRepository : IStoreRepository
{
    private SportsStoreDb _context;

    public EfStoreRepository(SportsStoreDb context)
    {
        _context = context;
    }
    
    public IQueryable<Product> Products => _context.Products;
}