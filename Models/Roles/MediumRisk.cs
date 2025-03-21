

namespace RiskDev.Models.Roles;

public class MediumRisk : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        if (trade.ClientSector.ToLower() == "public")
            return RiskCategory.MediumRisk;

        return null;
    }
}


