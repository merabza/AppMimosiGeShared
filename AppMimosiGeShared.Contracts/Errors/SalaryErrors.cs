using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class SalaryErrors
{
    public static Error SalaryHeaderNotFound => Error.NotFound(nameof(SalaryHeaderNotFound), "უწყისი ვერ მოიძებნა");

    public static Error SalaryPartNotFound =>
        Error.NotFound(nameof(SalaryPartNotFound), "ხელფასის მდგენელი ვერ მოიძებნა");

    public static Error ChargeDateIsRequired =>
        Error.Problem(nameof(ChargeDateIsRequired), "დარიცხვის თარიღი შევსებული უნდა იყოს");

    public static Error TransferDateIsRequired =>
        Error.Problem(nameof(TransferDateIsRequired), "გადარიცხვის თარიღი შევსებული უნდა იყოს");

    public static Error SalaryHeaderHasData =>
        Error.Conflict(nameof(SalaryHeaderHasData),
            "უწყისს მდგენელები ან სტრიქონები აქვს, ამიტომ ვერ წაიშლება. ჯერ მდგენელები წაშალეთ");

    public static Error EmployeeNotFound =>
        Error.Problem(nameof(EmployeeNotFound), "თანამშრომლის კონტრაქტი ვერ მოიძებნა");

    public static Error PartTypeIsRequired =>
        Error.Problem(nameof(PartTypeIsRequired), "მდგენელის ტიპი არჩეული უნდა იყოს");

    public static Error PartTypeNotFound => Error.Problem(nameof(PartTypeNotFound), "მდგენელის ტიპი ვერ მოიძებნა");

    public static Error PartIsCalculated =>
        Error.Conflict(nameof(PartIsCalculated),
            "ჩატარებული გაკვეთილების ხელფასს გამოთვლა ქმნის: ხელით ვერ დაემატება, შეიცვლება ან წაიშლება");

    public static Error DeductionMustBePositive =>
        Error.Problem(nameof(DeductionMustBePositive),
            "გამოქვითვა დადებითი თანხით იწერება: ფორმულა მას ხელზე ასაღებს აკლებს");

    public static Error DeclarationMonthIsRequired =>
        Error.Problem(nameof(DeclarationMonthIsRequired), "დეკლარაციის თვე არჩეული უნდა იყოს");
}
