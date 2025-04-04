

namespace RiskDev.Models;
public class Trade : ITrade
{

    public Trade(double value, string clientSector, DateTime nextPaymentDate, bool isPep)
    {
        this.Value = value;
        this.ClientSector = clientSector;
        this.NextPaymentDate = nextPaymentDate;
        this.IsPep = isPep;

        
    }
    public double Value { get; }

    public string ClientSector { get; } = string.Empty;

    public DateTime NextPaymentDate { get; }

    public bool IsPep { get; }
    
}