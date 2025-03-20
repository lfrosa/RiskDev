

namespace RiskDev.Models.Roles;

internal class NoneRule : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
         if (trade.Value <= 1_000_000)
            return RiskCategory.None;

        return null;
    }
}
