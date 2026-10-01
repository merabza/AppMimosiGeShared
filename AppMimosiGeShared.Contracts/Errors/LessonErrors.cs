using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class LessonErrors
{
    public static Error LessonNotFound => Error.NotFound(nameof(LessonNotFound), "გაკვეთილი ვერ მოიძებნა");

    public static Error LessonStatusNotFound =>
        Error.Problem(nameof(LessonStatusNotFound), "გაკვეთილის სტატუსი ვერ მოიძებნა");

    public static Error SubstituteTeacherContractNotFound =>
        Error.Problem(nameof(SubstituteTeacherContractNotFound), "შემცვლელი მასწავლებლის კონტრაქტი ვერ მოიძებნა");

    public static Error TeacherLateMinutesMustNotBeNegative =>
        Error.Problem(nameof(TeacherLateMinutesMustNotBeNegative),
            "მასწავლებლის დაგვიანების წუთები უარყოფითი ვერ იქნება");

    public static Error StudentLateMinutesMustNotBeNegative =>
        Error.Problem(nameof(StudentLateMinutesMustNotBeNegative), "მოსწავლის დაგვიანების წუთები უარყოფითი ვერ იქნება");

    public static Error NoteIsTooLong =>
        Error.Problem(nameof(NoteIsTooLong), "შენიშვნა 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error ThemeIsTooLong => Error.Problem(nameof(ThemeIsTooLong), "თემა 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error TeacherCommentIsTooLong =>
        Error.Problem(nameof(TeacherCommentIsTooLong), "მასწავლებლის კომენტარი 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error StudentCommentIsTooLong =>
        Error.Problem(nameof(StudentCommentIsTooLong), "მოსწავლის კომენტარი 255 სიმბოლოზე გრძელი ვერ იქნება");

    public static Error StudentRowIsDuplicated =>
        Error.Problem(nameof(StudentRowIsDuplicated), "მოსწავლის სტრიქონი მოთხოვნაში ორჯერ არის");

    public static Error StudentRowNotFound =>
        Error.Problem(nameof(StudentRowNotFound), "მოსწავლის სტრიქონი ამ გაკვეთილს არ ეკუთვნის");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");
}
