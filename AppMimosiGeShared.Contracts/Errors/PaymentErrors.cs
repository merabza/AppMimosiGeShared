using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class PaymentErrors
{
    public static Error PaymentNotFound => Error.NotFound(nameof(PaymentNotFound), "გადახდა ვერ მოიძებნა");

    public static Error StudentContractNotFound =>
        Error.Problem(nameof(StudentContractNotFound), "მოსწავლის კონტრაქტი ვერ მოიძებნა");

    public static Error PayDateIsRequired =>
        Error.Problem(nameof(PayDateIsRequired), "გადახდის თარიღი შევსებული უნდა იყოს");

    public static Error AmountMustNotBeZero =>
        Error.Problem(nameof(AmountMustNotBeZero), "თანხა 0 ვერ იქნება (უარყოფითი თანხა დასაშვებია)");

    public static Error AmountHasTooManyDecimals =>
        Error.Problem(nameof(AmountHasTooManyDecimals), "თანხას 2-ზე მეტი ათწილადი ვერ ექნება");

    public static Error DocumentIsTooLong =>
        Error.Problem(nameof(DocumentIsTooLong), "დოკუმენტი 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error BankAccountIsRequired =>
        Error.Problem(nameof(BankAccountIsRequired), "გადახდის სახე (ბანკი) არჩეული უნდა იყოს");

    public static Error BankAccountNotFound =>
        Error.Problem(nameof(BankAccountNotFound), "გადახდის სახე (ბანკი) ვერ მოიძებნა");

    public static Error CheckedRequiresRight =>
        Error.Conflict(nameof(CheckedRequiresRight),
            "\"შემოწმებულია\" ალამს მხოლოდ გადახდების შემოწმების უფლების მქონე როლი ცვლის");

    public static Error PaymentIsChecked =>
        Error.Conflict(nameof(PaymentIsChecked),
            "გადახდა შემოწმებულია: მის შეცვლას ან წაშლას მხოლოდ გადახდების შემოწმების უფლების მქონე როლი შეძლებს");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
