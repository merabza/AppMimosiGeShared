using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class WorkHourErrors
{
    public static Error WorkHourNotFound => Error.NotFound(nameof(WorkHourNotFound), "ჩანაწერი ვერ მოიძებნა");

    public static Error EmployeeIsRequired =>
        Error.Problem(nameof(EmployeeIsRequired), "თანამშრომელი არჩეული უნდა იყოს");

    public static Error EmployeeNotFound =>
        Error.Problem(nameof(EmployeeNotFound),
            "თანამშრომლის კონტრაქტი ვერ მოიძებნა ან მას სამუშაო საათების ჯგუფი არ აქვს");

    public static Error StartIsRequired =>
        Error.Problem(nameof(StartIsRequired), "სამუშაოს დაწყება შევსებული უნდა იყოს");

    public static Error EndMustBeAfterStart =>
        Error.Problem(nameof(EndMustBeAfterStart), "სამუშაოს დასრულება დაწყებაზე გვიან უნდა იყოს");

    public static Error LuftIsTooBig => Error.Problem(nameof(LuftIsTooBig), "ლუფტი 30 წუთზე მეტი ვერ იქნება");

    public static Error TodayRecordExists =>
        Error.Conflict(nameof(TodayRecordExists), "ამ თანამშრომელს დღევანდელი ჩანაწერი უკვე აქვს");

    public static Error TodayRecordNotFound =>
        Error.Conflict(nameof(TodayRecordNotFound),
            "ამ თანამშრომელს დღევანდელი ჩანაწერი არ აქვს: ჯერ სამუშაოს დაწყება უნდა დაფიქსირდეს");

    public static Error ContractIsNotActive =>
        Error.Conflict(nameof(ContractIsNotActive), "თანამშრომლის კონტრაქტი დღეს არ მოქმედებს");

    public static Error PeriodIsRequired =>
        Error.Problem(nameof(PeriodIsRequired), "პერიოდი (თარიღიდან და თარიღამდე) შევსებული უნდა იყოს");

    public static Error PeriodIsInvalid =>
        Error.Problem(nameof(PeriodIsInvalid), "დაწყების თარიღი დასრულების თარიღზე გვიან არის");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
