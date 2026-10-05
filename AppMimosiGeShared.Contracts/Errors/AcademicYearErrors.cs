using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class AcademicYearErrors
{
    public static Error AcademicYearNotFound =>
        Error.NotFound(nameof(AcademicYearNotFound), "სასწავლო წელი ვერ მოიძებნა");

    public static Error NoAcademicYears =>
        Error.Problem(nameof(NoAcademicYears),
            "სასწავლო წლები არ არის: პირველი წელი ცნობარში (სასწავლო წლები) უნდა დაემატოს");

    public static Error AcademicYearAlreadyExists =>
        Error.Conflict(nameof(AcademicYearAlreadyExists), "ასეთი სასწავლო წელი უკვე არსებობს");

    public static Error CloseDateIsOutOfRange =>
        Error.Problem(nameof(CloseDateIsOutOfRange),
            "ჯგუფების დახურვის თარიღი სასწავლო წლის დაწყების შემდეგ უნდა იყოს");
}
