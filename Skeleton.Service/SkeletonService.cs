using System;
using System.Collections.Generic;
using System.Text;
using Skeleton.Repository;

namespace Skeleton.Service
{
    public class SkeletonService
    {
        private SkeletonRepository _repository ;

        public SkeletonService(SkeletonRepository repository)
        {
            _repository = repository;
        }
        public double GetManufacturingProfit()
        {

            
            var adminPercentage = _repository.GetAdminPercentage();
            var getProducts = _repository.GetProductsManufacturingList();
            
            return 2.22;
        }
    }
}
