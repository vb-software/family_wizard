using FamilyWizardReporting.Domain.Enums;
using FamilyWizardReporting.Domain.Interfaces;

namespace FamilyWizardReporting.Domain.Entities
{
    public class LoginEntry : IEntry
    {
        public User User { get; set; }
        public DateTime EntryDate { get; set; }
        public EntryType EntryType { get; set; }
    }
}