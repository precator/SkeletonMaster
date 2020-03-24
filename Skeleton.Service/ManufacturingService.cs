using System;
using System.Collections.Generic;
using System.Text;
using Skeleton.Repository;

namespace Skeleton.Service
{
    public class ManufacturingService
    {
        private SkeletonRepository _repository ;

        public ManufacturingService(SkeletonRepository repository)
        {
            _repository = repository;
        }
        public double GetManufacturingProfit()
        {

            //formula for labor([productionperhour] *[playerprodmodifier]) / ([player admin] * [wages])   tyrr
            var adminPercentage = _repository.GetAdminPercentage();
            var getProducts = _repository.GetProductsManufacturingList();
            var playerModifier = 1.02;
            var buildingLevel = 5;
            foreach (var item in getProducts)
            {
                if (item.ProductId == 28)
                {
                    var unitsPerHour = item.UnitsPerHour;
                    var adminPercentage2 = adminPercentage;
                    var producedAt = item.ProducedAt;
                    //var buildingWages = _repository.GetBuildingWages((int)item.ProducedAt);
                    var buildingWages = item.ProducedAtNavigation.Wages;
                    //var laborPerHour = (((unitsPerHour * buildingLevel) * playerModifier) / (adminPercentage2 * (buildingWages * buildingLevel)));
                    var inputOneID = item.InputOneId;
                    var inputOneQTY = item.InputOneQty;
                    var inputTwoID = item.InputTwoId;
                    var inputTwoQTY = item.InputTwoQty;
                    var inputThreeID = item.InputThreeId;
                    var inputThreeQTY = item.InputThreeQty;
                    var inputFourID = item.InputFourId;
                    var inputFourQTY = item.InputFourQty;
                    var inputFiveID = item.InputFiveId;
                    var inputFiveQTY = item.InputFiveQty;
                    var unitCost = (((buildingWages * adminPercentage2)) / (unitsPerHour * playerModifier));
                    
                    if(inputOneID > 0)
                    {
                        var inputOneProductionInfo = _repository.GetProductManufacturing(inputOneID);
                        var inputOneUnitsPerHour = inputOneProductionInfo.UnitsPerHour;
                        //var totalCost = 

                    }
                    if (inputTwoID > 0)
                    {

                    }
                    if (inputThreeID > 0)
                    {

                    }
                    if (inputFourID > 0)
                    {

                    }
                    if (inputFiveID > 0)
                    {

                    }
                }
            }

            return 4.55;
        }
    }
}
