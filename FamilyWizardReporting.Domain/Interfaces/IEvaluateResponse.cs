using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyWizardReporting.Domain.Enums;

namespace FamilyWizardReporting.Domain.Interfaces
{
    public interface IEvaluateResponse
    {
        public EvaluateResponseState EvaluateResponseState { get; set; }
    }
}