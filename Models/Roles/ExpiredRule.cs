﻿
namespace RiskDev.Models.Roles;

internal class ExpiredRule : IRiskRule
{
    public RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference)
    {
        if (trade.NextPaymentDate.AddDays(-30).Date > DateReference.Date)
            return RiskCategory.Expired;

        return null;
    }
}
