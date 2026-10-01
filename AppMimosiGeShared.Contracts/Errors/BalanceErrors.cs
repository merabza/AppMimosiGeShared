using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

//დარიცხვები და გადახდები (ამონაწერი) და ბალანსები (დეპოზიტები)
public static class BalanceErrors
{
    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "ამონაწერის ფილტრის ან გვერდის პარამეტრები არასწორია");

    public static Error DepositsFilterIsInvalid =>
        Error.Problem(nameof(DepositsFilterIsInvalid), "ბალანსების ფილტრი არასწორია");
}
