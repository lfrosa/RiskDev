

namespace RiskDev.Models;
public interface ITrade
{
    /// <summary>
    /// indica o valor da operação em dólar
    /// </summary>
    double Value { get; }

    /// <summary>
    /// Indica o setor do cliente, que pode ser "Public" ou "Private"
    /// </summary>
    string ClientSector { get; } 

    /// <summary>
    /// Indica a expectativa da data do próximo pagamento do cliente ao banco
    /// </summary>
    DateTime NextPaymentDate { get; }

}