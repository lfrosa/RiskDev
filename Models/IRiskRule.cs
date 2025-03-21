
namespace RiskDev.Models;

public interface IRiskRule
{
    RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference);
}
