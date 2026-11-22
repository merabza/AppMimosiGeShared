using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

    //რეპორტი r22 (D181): გაკვეთილის თეორიული თარიღები განრიგის დღე + დაწყების დროა
    public static Error LessonStartTimeIsMidnight =>
        Error.Problem(nameof(LessonStartTimeIsMidnight),
            "გაკვეთილი 00:00-ზე ვერ დაიწყება: ასეთი განრიგით გაკვეთილების თეორიული თარიღები 00:00:00 გამოვა " +
            "(რეპორტი „კვირის დღეების არასწორი ცვლილებები\"). აირჩიეთ სხვა დაწყების დრო");

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

    public static Error StudentPeriodsOverlap =>
        Error.Problem(nameof(StudentPeriodsOverlap),
            "ერთი მოსწავლე ჯგუფში ერთ დღეს ორჯერ ვერ იქნება: ერთი კონტრაქტის სტრიქონების პერიოდები ერთმანეთს ფარავს");

    public static Error RowNotFound =>
        Error.Problem(nameof(RowNotFound), "მასწავლებლის, მოსწავლის ან განრიგის სტრიქონი ამ ჯგუფს არ ეკუთვნის");

    public static Error GroupStudentIsInUse =>
        Error.Conflict(nameof(GroupStudentIsInUse),
            "მოსწავლის ჯგუფიდან წაშლა შეუძლებელია: მას ამ ჯგუფში უკვე აქვს გაკვეთილები. წაშლის ნაცვლად მიუთითეთ დასრულების თარიღი");

    //D181: დღემდე დაწყებული განრიგის სტრიქონის კვირის დღე ადგილზე არ იცვლება
    public static Error StartedDayTimePlaceWeekDayCannotChange =>
        Error.Conflict(nameof(StartedDayTimePlaceWeekDayCannotChange),
            "განრიგის სტრიქონის კვირის დღის შეცვლა შეუძლებელია: სტრიქონი დღემდე დაიწყო და ცვლილება მის წარსულ " +
            "გაკვეთილებსაც სხვა დღეზე გადაიტანდა. შეცვლის ნაცვლად სტრიქონს მიუთითეთ დასრულების თარიღი და ახალი " +
            "კვირის დღე ახალ სტრიქონად დაამატეთ");

    //D181: დღემდე დაწყებული განრიგის სტრიქონი არ იშლება
    public static Error StartedDayTimePlaceCannotBeRemoved =>
        Error.Conflict(nameof(StartedDayTimePlaceCannotBeRemoved),
            "განრიგის სტრიქონის წაშლა შეუძლებელია: სტრიქონი დღემდე დაიწყო და წაშლა მის წარსულ გაკვეთილებსაც " +
            "წაშლიდა. წაშლის ნაცვლად მიუთითეთ დასრულების თარიღი");

    public static Error GroupIsInUse =>
        Error.Conflict(nameof(GroupIsInUse),
            "ჯგუფის წაშლა შეუძლებელია: მას უკვე აქვს გაკვეთილები ან ხელფასის ჩანაწერები. გასაუქმებლად მიუთითეთ გაუქმების თარიღი");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");

    //D183: ბრძანებების რეჟიმში ჯგუფის შექმნა, შეცვლა და წაშლა მხოლოდ ბრძანებით
    public static Error GroupsAreManagedByOrders =>
        Error.Conflict(nameof(GroupsAreManagedByOrders),
            "ჯგუფი ჯგუფის ფორმით აღარ იქმნება, არ იცვლება და არ იშლება: ჯგუფის ყოველი ცვლილება ბრძანებით კეთდება");

    //გაკვეთილების გენერატორის შეცდომები 11 და 14 (რეპორტი r13, D177). lessonDates: დალაგებული, პირველი 10 ჩამოითვლება
    public static Error ChangeCreatesLessonsWithErrors(IReadOnlyCollection<DateTime> lessonDates)
    {
        const int shownDatesCount = 10;
        string dates = string.Join(", ",
            lessonDates.Take(shownDatesCount)
                .Select(date => date.ToString("dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)));
        if (lessonDates.Count > shownDatesCount)
        {
            dates += string.Create(CultureInfo.InvariantCulture, $" და სხვა, სულ {lessonDates.Count}");
        }

        return Error.Conflict(nameof(ChangeCreatesLessonsWithErrors),
            "ცვლილება შეცდომიან გაკვეთილებს შექმნიდა (რეპორტი „შეცდომიანი გაკვეთილები\"): ეს გაკვეთილები ან მათი " +
            "ზოგიერთი მოსწავლე ზედმეტი გახდებოდა, ჟურნალში კი დასწრება, თემა, შეფასება ან კომენტარი აქვთ შეტანილი, " +
            $"ამიტომ გენერატორი მათ ვეღარ წაშლის: {dates}. შეასწორეთ თარიღები ან ჯერ ჟურნალში გაასუფთავეთ ამ " +
            "გაკვეთილების მონაცემები");
    }

    //მასწავლებლის დროების გადაფარვა სხვა ჯგუფთან (რეპორტი r18, D178). overlaps: გადაფარვების აღწერები რიგით, პირველი
    //10 ჩამოითვლება
    public static Error TeacherTimesOverlap(IReadOnlyCollection<string> overlaps)
    {
        return Error.Conflict(nameof(TeacherTimesOverlap),
            "ჯგუფი არ შეინახება: მის მასწავლებელს იმავე დროს სხვა ჯგუფშიც აქვს გაკვეთილი (რეპორტი „მასწავლებლების " +
            $"დროების გადაფარვა\"): {OverlapsList(overlaps)}. შეასწორეთ მასწავლებლების ან განრიგის თარიღები, დრო ან " +
            "კვირის დღე");
    }

    //მოსწავლის დროების გადაფარვა სხვა ჯგუფთან (რეპორტი r19, D179). overlaps: გადაფარვების აღწერები რიგით, პირველი
    //10 ჩამოითვლება
    public static Error StudentTimesOverlap(IReadOnlyCollection<string> overlaps)
    {
        return Error.Conflict(nameof(StudentTimesOverlap),
            "ჯგუფი არ შეინახება: მის მოსწავლეს იმავე დროს სხვა ჯგუფშიც აქვს გაკვეთილი (რეპორტი „მოსწავლეების " +
            $"დროების გადაფარვა\"): {OverlapsList(overlaps)}. შეასწორეთ მოსწავლეების ან განრიგის თარიღები, დრო ან " +
            "კვირის დღე");
    }

    //პირველი 10 გადაფარვა "; "-ით, მეტისას საერთო რაოდენობაც
    private static string OverlapsList(IReadOnlyCollection<string> overlaps)
    {
        const int shownOverlapsCount = 10;
        string list = string.Join("; ", overlaps.Take(shownOverlapsCount));
        if (overlaps.Count > shownOverlapsCount)
        {
            list += string.Create(CultureInfo.InvariantCulture, $" და სხვა, სულ {overlaps.Count}");
        }

        return list;
    }
}
