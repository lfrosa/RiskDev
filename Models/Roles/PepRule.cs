using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskDev.Models.Roles;
public class PepRule : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        if (trade.IsPep)
        {
            return new RiskCategory
            {
                Category = EumRiskCategory.Pep,
                Color = ConsoleColor.Yellow
            };
        }

        return null;
    }
}