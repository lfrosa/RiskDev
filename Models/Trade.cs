

namespace RiskDev.Models;
public class Trade : ITrade
{

    public Trade(double value, string clientSector, DateTime nextPaymentDate)
    {
        this.Value = value;
        this.ClientSector = clientSector;
        this.NextPaymentDate = nextPaymentDate;
    }
    public double Value  {get;}

    public string ClientSector {get;} = string.Empty;

    public DateTime NextPaymentDate {get;}

}