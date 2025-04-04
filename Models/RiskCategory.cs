namespace RiskDev.Models;

public class RiskCategory
{
    public EumRiskCategory Category { get; set; }
    public  ConsoleColor  Color { get; set; }


}

public enum EumRiskCategory
{
    Expired,
    HighRisk,
    MediumRisk,
    Insufficient,
    Pep
}

