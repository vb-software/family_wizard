using FamilyWizardReporting.Domain.Enums;

namespace FamilyWizardReporting.Domain.Interfaces
{
    public interface IEntry
    {
        public DateTime EntryDate { get; set; }
        public EntryType EntryType { get; set; }
    }
}