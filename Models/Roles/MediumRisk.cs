

namespace RiskDev.Models.Roles;

public class MediumRisk : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        if (trade.Value > 1_000_000 && trade.ClientSector.ToLower() == "public")
        {
            return new RiskCategory
            {
                Category = EumRiskCategory.MediumRisk,
                Color = ConsoleColor.Yellow
            };
        }

        return null;
    }
}


