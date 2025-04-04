
namespace RiskDev.Models.Roles;

public class ExpiredRule : IRiskRule
{

    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        if (trade.NextPaymentDate < DateReference.Date.AddDays(-30).Date)
        {
            return new RiskCategory
            {
                Category = EumRiskCategory.Expired,
                Color = ConsoleColor.Red
            };
        }
        return null;
    }
}
