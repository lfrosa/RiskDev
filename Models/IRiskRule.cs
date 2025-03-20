using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskDev.Models;

internal interface IRiskRule
{
    RiskCategory? EvaluateRisk(ITrade trade, DateTime DateReference);
}
