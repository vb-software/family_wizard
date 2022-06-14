using FamilyWizardReporting.Domain.Enums;
using FamilyWizardReporting.Domain.Interfaces;

namespace FamilyWizardReporting.Domain.Entities
{
    public class MessageEntry : IEntry, IEvaluateResponse
    {
        public User Author { get; set; }
        public DateTime EntryDate { get; set; }
        public EntryType EntryType { get; set; }
        public EvaluateResponseState EvaluateResponseState { get; set; }
    }
}