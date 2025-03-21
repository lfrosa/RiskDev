

namespace RiskDev.Models.Roles;

public class NoneRule : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
         if (trade.Value <= 1_000_000)
            return RiskCategory.Insufficient;

        return null;
    }
}
