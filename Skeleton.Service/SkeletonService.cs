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

            //formula for labor([productionperhour] *[playerprodmodifier]) / ([player admin] * [wages])   tyrr
            var adminPercentage = _repository.GetAdminPercentage();
            var getProducts = _repository.GetProductsManufacturingList();
            
            return 2.22;
        }
    }
}
