
namespace RiskDev.Models;

internal interface IRiskRule
{
    RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference);
}
