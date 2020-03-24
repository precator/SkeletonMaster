using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Skeleton.Models;
namespace Skeleton.Repository
{
    public class SkeletonRepository
    {
       

        private readonly SkeletonContext _context; //This is our service layer where we put all the business logic to make a skinny controller 
        public SkeletonRepository(SkeletonContext context)
        {
            _context = context;
        }
        public double GetAdminPercentage()
        {
            var adminPercantage = _context.MyInfo.Select(r => r.AdminOverhead).FirstOrDefault();
            return adminPercantage;
        }
        public IEnumerable<ProductManufacturing> GetProductsManufacturingList()
        {
            var productManufacturings = _context.ProductManufacturing;
            return productManufacturings;
        }
        public ProductManufacturing GetProductManufacturing(int productId)
        {
            var productManufacturing = _context.ProductManufacturing.Where(e => e.ProductId == productId).FirstOrDefault(); 
            return productManufacturing;
        }

        
        public Double GetBuildingWages(int producedAt)
        {
            var buildingWages = _context.Buildings.Where(t => t.Id == producedAt).Select(f => f.Wages).FirstOrDefault();
            return buildingWages;
        }
    }
}
