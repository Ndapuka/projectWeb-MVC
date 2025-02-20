using ProjectWebMVC.Data;
using ProjectWebMVC.Models;

namespace ProjectWebMVC.Services
{
    public class SellerService
    {
        private readonly ProjectWebMVCContext _context;
        public SellerService(ProjectWebMVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
    }
}
