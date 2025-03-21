

namespace RiskDev.Models.Roles;

public class HighRiskRule : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        if (trade.ClientSector.ToLower() == "private")
            return RiskCategory.HighRisk;
        return null;
    }
}
