

namespace RiskDev.Models.Roles;

public class NoneRule : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        return new RiskCategory
        {
            Category = EumRiskCategory.Insufficient,
            Color = ConsoleColor.White
        };
    }
}
