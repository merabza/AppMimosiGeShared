using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class CrmCallErrors
{
    public static Error CrmCallNotFound => Error.NotFound(nameof(CrmCallNotFound), "ზარი ვერ მოიძებნა");

    public static Error StudentContractNotFound =>
        Error.Problem(nameof(StudentContractNotFound), "მოსწავლის კონტრაქტი ვერ მოიძებნა");

    public static Error CallTypeNotFound => Error.Problem(nameof(CallTypeNotFound), "ზარის ტიპი ვერ მოიძებნა");

    public static Error CallDateIsRequired =>
        Error.Problem(nameof(CallDateIsRequired), "ზარის თარიღი შევსებული უნდა იყოს");

    public static Error AnswerTypeIsRequired =>
        Error.Problem(nameof(AnswerTypeIsRequired), "ზარის შედეგი არჩეული უნდა იყოს");

    public static Error AnswerTypeNotFound => Error.Problem(nameof(AnswerTypeNotFound), "ზარის შედეგი ვერ მოიძებნა");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
