
using RiskDev.Models;
using RiskDev.Models.Roles;


namespace RiskDev.Services;
public class RiskCategorizationService
{
    private List<IRiskRule> rules = [];

    public RiskCategorizationService()
    {
        rules.Add(new PepRule());
        rules.Add(new ExpiredRule());
        rules.Add(new HighRiskRule());
        rules.Add(new MediumRisk());
        rules.Add(new NoneRule());
    }
    public RiskCategory Evaluate(ITrade trade, DateTime dateReference)
    {
        foreach (var rule in rules)
        {
            var result = rule.EvaluateRisk(trade, dateReference);

            if (result is not null)
                return result;
        }
        return new RiskCategory
        {
            Category = EumRiskCategory.Insufficient,
            Color = ConsoleColor.White
        };

    }

}