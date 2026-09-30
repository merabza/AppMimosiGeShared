using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class TeacherContractErrors
{
    public static Error TeacherContractNotFound =>
        Error.NotFound(nameof(TeacherContractNotFound), "თანამშრომლის კონტრაქტი ვერ მოიძებნა");

    public static Error ContractNumberIsRequired =>
        Error.Problem(nameof(ContractNumberIsRequired), "კონტრაქტის ნომერი შევსებული უნდა იყოს");

    public static Error ContractNumberFormatIsInvalid =>
        Error.Problem(nameof(ContractNumberFormatIsInvalid),
            "კონტრაქტის ნომერი უნდა იყოს ფორმატით T0.00 (მაგალითად T3.01)");

    public static Error ContractNumberAlreadyExists =>
        Error.Conflict(nameof(ContractNumberAlreadyExists), "თანამშრომლის კონტრაქტი ასეთი ნომრით უკვე არსებობს");

    public static Error ContractDateIsRequired =>
        Error.Problem(nameof(ContractDateIsRequired), "კონტრაქტის თარიღი შევსებული უნდა იყოს");

    public static Error TeacherNotFound => Error.Problem(nameof(TeacherNotFound), "თანამშრომელი ვერ მოიძებნა");

    public static Error BankAccountIsTooLong =>
        Error.Problem(nameof(BankAccountIsTooLong), "ანგარიშის ნომერი 22 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error BankAccountCodeIsTooLong =>
        Error.Problem(nameof(BankAccountCodeIsTooLong), "ბანკის კოდი 8 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error RsQuoteTypeNotFound =>
        Error.Problem(nameof(RsQuoteTypeNotFound), "განაცემის სახე ვერ მოიძებნა");

    public static Error RsCountryNotFound => Error.Problem(nameof(RsCountryNotFound), "ქვეყანა ვერ მოიძებნა");

    public static Error FixedAmountMustNotBeNegative =>
        Error.Problem(nameof(FixedAmountMustNotBeNegative), "ფიქსირებული თანხა უარყოფითი ვერ იქნება");

    public static Error DescriptionIsTooLong =>
        Error.Problem(nameof(DescriptionIsTooLong), "განაცემის შინაარსი 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error SalarySchemeNotFound =>
        Error.Problem(nameof(SalarySchemeNotFound), "ხელფასის სქემა ვერ მოიძებნა");

    public static Error WorkHourGroupNotFound =>
        Error.Problem(nameof(WorkHourGroupNotFound), "სამუშაო საათების ჯგუფი ვერ მოიძებნა");

    public static Error WorkHoursStartMustBeBeforeEnd =>
        Error.Problem(nameof(WorkHoursStartMustBeBeforeEnd), "სამუშაოს დაწყების დრო დასრულების დროზე ადრე უნდა იყოს");

    public static Error ContractEndDateIsBeforeContractDate =>
        Error.Problem(nameof(ContractEndDateIsBeforeContractDate),
            "კონტრაქტის დასრულების თარიღი კონტრაქტის თარიღზე ადრე ვერ იქნება");

    public static Error TeacherContractIsInUse =>
        Error.Conflict(nameof(TeacherContractIsInUse),
            "კონტრაქტის წაშლა შეუძლებელია: მას უკვე აქვს მიბმული ჯგუფი, გაკვეთილი, ხელფასი ან სამუშაო საათები");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
