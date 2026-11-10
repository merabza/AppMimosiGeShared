using System.Globalization;
using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class BankTransactionErrors
{
    public static Error BankIsNotConfigured =>
        Error.Problem(nameof(BankIsNotConfigured),
            "ბანკთან ინტეგრაციის პარამეტრები (ClientId, ClientSecret, ანგარიში) შევსებული არ არის");

    public static Error BankIsUnreachable =>
        Error.Failure(nameof(BankIsUnreachable), "ბანკის API-სთან კავშირი ვერ დამყარდა");

    public static Error BankResponseIsInvalid =>
        Error.Failure(nameof(BankResponseIsInvalid), "ბანკის API-მ გაუგებარი პასუხი დააბრუნა");

    public static Error BankTransactionNotFound =>
        Error.NotFound(nameof(BankTransactionNotFound), "ბანკის ჩარიცხვა ვერ მოიძებნა");

    public static Error ListFilterIsInvalid =>
        Error.Problem(nameof(ListFilterIsInvalid), "ჩარიცხვების სიის ფილტრი არასწორია");

    public static Error PeriodIsInvalid =>
        Error.Problem(nameof(PeriodIsInvalid), "პერიოდის დასაწყისი დასასრულზე გვიან ვერ იქნება");

    public static Error ImportIsRunning =>
        Error.Conflict(nameof(ImportIsRunning), "ბანკიდან ჩარიცხვების მიღება უკვე მიმდინარეობს, სცადეთ ცოტა ხანში");

    public static Error ShareAmountMustBePositive =>
        Error.Problem(nameof(ShareAmountMustBePositive), "წილის თანხა 0-ზე მეტი უნდა იყოს");

    public static Error ShareAmountHasTooManyDecimals =>
        Error.Problem(nameof(ShareAmountHasTooManyDecimals), "წილის თანხას 2-ზე მეტი ათწილადი ვერ ექნება");

    public static Error ShareStudentContractNotFound =>
        Error.Problem(nameof(ShareStudentContractNotFound), "წილის მოსწავლის კონტრაქტი ვერ მოიძებნა");

    public static Error ShareStudentContractIsRepeated =>
        Error.Problem(nameof(ShareStudentContractIsRepeated), "ერთი კონტრაქტი განაწილებაში ორჯერ ვერ იქნება");

    public static Error AllocationExceedsAmount =>
        Error.Conflict(nameof(AllocationExceedsAmount), "განაწილებული ჯამი ჩარიცხულ თანხაზე მეტი ვერ იქნება");

    public static Error BankTransactionHasCheckedPayments =>
        Error.Conflict(nameof(BankTransactionHasCheckedPayments),
            "ჩარიცხვის განაწილების გადახდა შემოწმებულია: განაწილება აღარ იცვლება");

    public static Error BankTransactionIsIgnored =>
        Error.Conflict(nameof(BankTransactionIsIgnored),
            "ჩარიცხვა მონიშნულია „არ არის მოსწავლის გადახდა“: გასანაწილებლად ჯერ მონიშვნა მოხსენით");

    public static Error BankTransactionHasPayments =>
        Error.Conflict(nameof(BankTransactionHasPayments),
            "ჩარიცხვა განაწილებულია: „არ არის მოსწავლის გადახდად“ მოსანიშნად ჯერ განაწილება წაშალეთ");

    public static Error PaymentBelongsToBankTransaction =>
        Error.Conflict(nameof(PaymentBelongsToBankTransaction),
            "გადახდა ბანკის ჩარიცხვის განაწილებაა: შეცვალეთ ან წაშალეთ ჩარიცხვების გვერდზე");

    public static Error ManualPaymentOnIntegratedAccount =>
        Error.Problem(nameof(ManualPaymentOnIntegratedAccount),
            "ამ ანგარიშის გადახდები ბანკიდან ავტომატურად შემოდის: ხელით შეყვანა არ შეიძლება, გაანაწილეთ ჩარიცხვების გვერდზე");

    //ბანკის ლიმიტი (საქართველოს ბანკი: ამონაწერი 1-ჯერ წუთში ანგარიშზე): 429 და Retry-After წამებში, თუ ბანკმა გამოგზავნა
    public static Error BankRateLimitExceeded(int? retryAfterSeconds)
    {
        return Error.Failure(nameof(BankRateLimitExceeded),
            retryAfterSeconds is { } seconds
                ? string.Create(CultureInfo.InvariantCulture,
                    $"ბანკი ასე ხშირ მოთხოვნას არ იღებს: სცადეთ {seconds} წამში")
                : "ბანკი ასე ხშირ მოთხოვნას არ იღებს: სცადეთ ერთ წუთში");
    }

    //ბანკის problem+json პასუხი: HTTP სტატუსი, ბანკის შეცდომის კოდი და სათაური (პერსონალური მონაცემები მათში არ არის)
    public static Error BankApiError(int status, string? code, string? title)
    {
        return Error.Failure(nameof(BankApiError),
            string.Create(CultureInfo.InvariantCulture,
                $"ბანკის API-ს შეცდომა: HTTP {status} {code ?? "-"} {title ?? "-"}"));
    }
}
