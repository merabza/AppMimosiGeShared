using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class GroupErrors
{
    public static Error GroupNotFound => Error.NotFound(nameof(GroupNotFound), "ჯგუფი ვერ მოიძებნა");

    public static Error GroupCodeIsRequired =>
        Error.Problem(nameof(GroupCodeIsRequired), "ჯგუფის კოდი შევსებული უნდა იყოს");

    public static Error GroupCodeIsTooLong =>
        Error.Problem(nameof(GroupCodeIsTooLong), "ჯგუფის კოდი 5 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error GroupCodeAlreadyExists =>
        Error.Conflict(nameof(GroupCodeAlreadyExists), "ამ სასწავლო წელში ჯგუფი ასეთი კოდით უკვე არსებობს");

    public static Error AcademicYearNotFound =>
        Error.Problem(nameof(AcademicYearNotFound), "სასწავლო წელი ვერ მოიძებნა");

    public static Error CourseNotFound => Error.Problem(nameof(CourseNotFound), "საგანი ვერ მოიძებნა");

    public static Error GroupSizeNotFound => Error.Problem(nameof(GroupSizeNotFound), "ჯგუფის ზომა ვერ მოიძებნა");

    public static Error StudentStatusNotFound =>
        Error.Problem(nameof(StudentStatusNotFound), "მოსწავლის სტატუსი ვერ მოიძებნა");

    public static Error TeacherContractNotFound =>
        Error.Problem(nameof(TeacherContractNotFound), "მასწავლებლის კონტრაქტი ვერ მოიძებნა");

    public static Error SalarySchemeNotFound =>
        Error.Problem(nameof(SalarySchemeNotFound), "ხელფასის სქემა ვერ მოიძებნა");

    public static Error SalarySchemeIsRequired =>
        Error.Problem(nameof(SalarySchemeIsRequired),
            "ხელფასის სქემა მითითებული უნდა იყოს: მასწავლებლის კონტრაქტს ძირითადი სქემა არ აქვს");

    public static Error StudentContractNotFound =>
        Error.Problem(nameof(StudentContractNotFound), "მოსწავლის კონტრაქტი ვერ მოიძებნა");

    public static Error FourWeekHoursMustBePositive =>
        Error.Problem(nameof(FourWeekHoursMustBePositive), "4 კვირაში საათების რაოდენობა 0-ზე მეტი უნდა იყოს");

    public static Error FeeMustBePositive =>
        Error.Problem(nameof(FeeMustBePositive), "4 კვირის გადასახადი და საათის ღირებულება 0-ზე მეტი უნდა იყოს");

    public static Error HoursCoefficientMustBePositive =>
        Error.Problem(nameof(HoursCoefficientMustBePositive), "საათის კოეფიციენტი 0-ზე მეტი უნდა იყოს");

    public static Error NoteIsTooLong =>
        Error.Problem(nameof(NoteIsTooLong), "შენიშვნა 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error WeekDayNotFound => Error.Problem(nameof(WeekDayNotFound), "კვირის დღე ვერ მოიძებნა");

    public static Error LessonStartTimeNotFound =>
        Error.Problem(nameof(LessonStartTimeNotFound), "გაკვეთილის დაწყების დრო ვერ მოიძებნა");

    public static Error RoomNotFound => Error.Problem(nameof(RoomNotFound), "ოთახი ვერ მოიძებნა");

    public static Error HoursCountMustBePositive =>
        Error.Problem(nameof(HoursCountMustBePositive), "გაკვეთილის საათები 0-ზე მეტი უნდა იყოს");

    public static Error StartDateIsRequired =>
        Error.Problem(nameof(StartDateIsRequired), "დაწყების თარიღი შევსებული უნდა იყოს");

    public static Error EndDateMustBeAfterStartDate =>
        Error.Problem(nameof(EndDateMustBeAfterStartDate), "დასრულების თარიღი დაწყების თარიღზე გვიან უნდა იყოს");

    //გაკვეთილების გენერატორის შეცდომა 5
    public static Error TeacherPeriodsOverlap =>
        Error.Problem(nameof(TeacherPeriodsOverlap),
            "ერთ დღეს ჯგუფს ორი მასწავლებელი ვერ ეყოლება: მასწავლებლების პერიოდები ერთმანეთს ფარავს");

    //გაკვეთილების გენერატორის შეცდომა 7
    public static Error DayTimePlacePeriodsOverlap =>
        Error.Problem(nameof(DayTimePlacePeriodsOverlap),
            "ერთ კვირის დღეზე ჯგუფს ორი განრიგი ვერ ექნება: ერთი დღის განრიგების პერიოდები ერთმანეთს ფარავს");

    public static Error RowNotFound =>
        Error.Problem(nameof(RowNotFound), "მასწავლებლის, მოსწავლის ან განრიგის სტრიქონი ამ ჯგუფს არ ეკუთვნის");

    public static Error GroupStudentIsInUse =>
        Error.Conflict(nameof(GroupStudentIsInUse),
            "მოსწავლის ჯგუფიდან წაშლა შეუძლებელია: მას ამ ჯგუფში უკვე აქვს გაკვეთილები. წაშლის ნაცვლად მიუთითეთ დასრულების თარიღი");

    public static Error GroupIsInUse =>
        Error.Conflict(nameof(GroupIsInUse),
            "ჯგუფის წაშლა შეუძლებელია: მას უკვე აქვს გაკვეთილები ან ხელფასის ჩანაწერები. გასაუქმებლად მიუთითეთ გაუქმების თარიღი");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
