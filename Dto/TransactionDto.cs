using Atm_Project.Model;

namespace Atm.Dto
{
    public record TransactionDto(string AccountNo, Account Account, float Amount, string Type, DateTime Date);
}
