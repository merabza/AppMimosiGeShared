using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class StudentContractErrors
{
    public static Error StudentContractNotFound =>
        Error.NotFound(nameof(StudentContractNotFound), "მოსწავლის კონტრაქტი ვერ მოიძებნა");

    public static Error ContractNumberIsRequired =>
        Error.Problem(nameof(ContractNumberIsRequired), "კონტრაქტის ნომერი შევსებული უნდა იყოს");

    public static Error ContractNumberFormatIsInvalid =>
        Error.Problem(nameof(ContractNumberFormatIsInvalid),
            "კონტრაქტის ნომერი უნდა იყოს ფორმატით 0.000 (მაგალითად 6.001)");

    public static Error ContractNumberAlreadyExists =>
        Error.Conflict(nameof(ContractNumberAlreadyExists),
            "ამ სასწავლო წელში კონტრაქტი ასეთი ნომრით უკვე არსებობს");

    public static Error ContractDateIsRequired =>
        Error.Problem(nameof(ContractDateIsRequired), "კონტრაქტის თარიღი შევსებული უნდა იყოს");

    public static Error StudentNotFound => Error.Problem(nameof(StudentNotFound), "მოსწავლე ვერ მოიძებნა");

    public static Error PayerNotFound => Error.Problem(nameof(PayerNotFound), "გადამხდელი ვერ მოიძებნა");

    public static Error AcademicYearNotFound =>
        Error.Problem(nameof(AcademicYearNotFound), "სასწავლო წელი ვერ მოიძებნა");

    public static Error StudentStatusNotFound =>
        Error.Problem(nameof(StudentStatusNotFound), "მოსწავლის სტატუსი ვერ მოიძებნა");

    public static Error DesiredMonthlyPaymentDayIsOutOfRange =>
        Error.Problem(nameof(DesiredMonthlyPaymentDayIsOutOfRange),
            "გადახდის სასურველი დღე უნდა იყოს 1-დან 28-მდე");

    public static Error CourseNotFound => Error.Problem(nameof(CourseNotFound), "საგანი ვერ მოიძებნა");

    public static Error GroupSizeNotFound => Error.Problem(nameof(GroupSizeNotFound), "ჯგუფის ზომა ვერ მოიძებნა");

    public static Error FourWeekHoursMustBePositive =>
        Error.Problem(nameof(FourWeekHoursMustBePositive), "4 კვირაში საათების რაოდენობა 0-ზე მეტი უნდა იყოს");

    public static Error FeeMustNotBeNegative =>
        Error.Problem(nameof(FeeMustNotBeNegative), "გადასახადი და საათის ღირებულება უარყოფითი ვერ იქნება");

    public static Error DetailNotFound =>
        Error.Problem(nameof(DetailNotFound), "კონტრაქტის დეტალი ამ კონტრაქტს არ ეკუთვნის");

    public static Error StudentContractIsInUse =>
        Error.Conflict(nameof(StudentContractIsInUse),
            "კონტრაქტის წაშლა შეუძლებელია: მას უკვე აქვს მიბმული ჯგუფი, გაკვეთილი, გადახდა ან CRM ზარი");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
