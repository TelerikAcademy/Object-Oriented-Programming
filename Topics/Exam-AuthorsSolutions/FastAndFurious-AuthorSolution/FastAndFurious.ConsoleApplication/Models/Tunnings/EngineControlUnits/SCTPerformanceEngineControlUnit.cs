using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits
{
    public class SCTPerformanceEngineControlUnit : EngineControlUnit, IEngineControlUnit, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int SCTPerformanceEngineControlUnitWeightInGrams = 21000;
        private const int SCTPerformanceEngineControlUnitAccelerationBonus = 25;
        private const int SCTPerformanceEngineControlUnitTopSpeedBonus = 45;
        private const decimal SCTPerformanceEngineControlUnitPriceInUSADollars = 3599;

        public SCTPerformanceEngineControlUnit()
            : base(
                  SCTPerformanceEngineControlUnitPriceInUSADollars,
                  SCTPerformanceEngineControlUnitWeightInGrams,
                  SCTPerformanceEngineControlUnitAccelerationBonus,
                  SCTPerformanceEngineControlUnitTopSpeedBonus,
                  TunningGradeType.LowGrade,
                  EngineControlUnitType.Stock)
        {
        }
    }
}
