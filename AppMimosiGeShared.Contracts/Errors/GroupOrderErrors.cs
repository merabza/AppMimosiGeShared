using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

//ჯგუფების ბრძანებების შეცდომები (GROUP_ORDERS.md). ჯგუფის სტრიქონების საერთო წესები (D55, D177–D179, D181)
//GroupErrors-შია: ბრძანების შედეგი იმავე წესებს გადის
public static class GroupOrderErrors
{
    public static Error GroupOrderNotFound => Error.NotFound(nameof(GroupOrderNotFound), "ბრძანება ვერ მოიძებნა");

    public static Error OrderTypeIsInvalid => Error.Problem(nameof(OrderTypeIsInvalid), "ბრძანების ტიპი არასწორია");

    public static Error OrderDateIsRequired =>
        Error.Problem(nameof(OrderDateIsRequired), "ბრძანების თარიღი შევსებული უნდა იყოს");

    //D196
    public static Error InitialOrderIsCreatedByTransitionOnly =>
        Error.Problem(nameof(InitialOrderIsCreatedByTransitionOnly),
            "საწყისი ბრძანება ხელით არ იქმნება: მას მხოლოდ ბრძანებებზე გადასვლა ქმნის");

    public static Error GroupIsRequired => Error.Problem(nameof(GroupIsRequired), "ჯგუფი არჩეული უნდა იყოს");

    public static Error GroupNotFound => Error.Problem(nameof(GroupNotFound), "ჯგუფი ვერ მოიძებნა");

    //D202: შექმნის ბრძანება მხოლოდ ახალ ჯგუფს ქმნის
    public static Error CreateOrderCannotHaveGroup =>
        Error.Problem(nameof(CreateOrderCannotHaveGroup),
            "ჯგუფის შექმნის ბრძანება ახალ ჯგუფს ქმნის: არსებული ჯგუფი მასში ვერ აირჩევა");

    public static Error TargetGroupIsRequired =>
        Error.Problem(nameof(TargetGroupIsRequired), "ჯგუფი, სადაც მოსწავლეები გადადიან, არჩეული უნდა იყოს");

    public static Error TargetGroupNotFound =>
        Error.Problem(nameof(TargetGroupNotFound), "ჯგუფი, სადაც მოსწავლეები გადადიან, ვერ მოიძებნა");

    public static Error TargetGroupIsSourceGroup =>
        Error.Problem(nameof(TargetGroupIsSourceGroup), "მოსწავლეები იმავე ჯგუფში ვერ გადავლენ");

    //შეცვლისას არსებული ხაზი თავის Id-ს ინარჩუნებს; სხვა ბრძანების ხაზი ამ ბრძანებაში ვერ მოხვდება
    public static Error LineNotFound =>
        Error.Problem(nameof(LineNotFound), "მასწავლებლის, მოსწავლის ან განრიგის ხაზი ამ ბრძანებას არ ეკუთვნის");

    //GROUP_ORDERS.md §4: ბრძანების ნაწილები მის ტიპზეა დამოკიდებული
    public static Error PartIsNotAllowedForOrderType =>
        Error.Problem(nameof(PartIsNotAllowedForOrderType),
            "ბრძანებაში ისეთი მონაცემია, რომელიც ამ ტიპის ბრძანებას არ ეკუთვნის");

    public static Error TeacherIsRequired => Error.Problem(nameof(TeacherIsRequired), "მასწავლებელი არჩეული უნდა იყოს");

    public static Error OnlyOneTeacherIsAllowed =>
        Error.Problem(nameof(OnlyOneTeacherIsAllowed), "ბრძანებაში მხოლოდ ერთი მასწავლებელი შეიძლება იყოს");

    //D186: მოსწავლის გარეშე შექმნის ბრძანებაც არ ინახება
    public static Error StudentsAreRequired =>
        Error.Problem(nameof(StudentsAreRequired), "ბრძანებაში ერთი მოსწავლე მაინც უნდა იყოს");

    public static Error StudentIsRepeated =>
        Error.Problem(nameof(StudentIsRepeated), "ერთი მოსწავლე ბრძანებაში ორჯერ ვერ იქნება");

    public static Error StudentTariffIsRequired =>
        Error.Problem(nameof(StudentTariffIsRequired),
            "მოსწავლის კოეფიციენტი, საათის ფასი და 4 კვირის გადასახადი შევსებული უნდა იყოს");

    public static Error DayTimePlacesAreRequired =>
        Error.Problem(nameof(DayTimePlacesAreRequired), "ბრძანებაში ახალი განრიგი უნდა იყოს");

    //D188 (6, 10)
    public static Error OrderDateWeekDayIsNotInSchedule =>
        Error.Problem(nameof(OrderDateWeekDayIsNotInSchedule),
            "ბრძანების თარიღის კვირის დღე ახალი განრიგის ერთ-ერთი დღე უნდა იყოს");

    public static Error FilterSortRequestIsInvalid =>
        Error.Problem(nameof(FilterSortRequestIsInvalid), "სიის ფილტრის ან დალაგების პარამეტრები არასწორია");

    //D183: ბრძანებების რეჟიმი ჯერ არ არის ჩართული
    public static Error GroupOrdersAreNotEnabled =>
        Error.Conflict(nameof(GroupOrdersAreNotEnabled),
            "ბრძანებები ჯერ არ მოქმედებს: ჯგუფები ჯერჯერობით ჯგუფის ფორმით იცვლება");

    //D202
    public static Error GroupCannotHaveOrders =>
        Error.Conflict(nameof(GroupCannotHaveOrders),
            "ამ ჯგუფს ბრძანება ვერ შეექმნება: მას არც საწყისი ბრძანება აქვს და არც გააქტიურებული შექმნის ბრძანება");

    //D202: გადაყვანის სამიზნესაც სჭირდება
    public static Error TargetGroupCannotHaveOrders =>
        Error.Conflict(nameof(TargetGroupCannotHaveOrders),
            "ჯგუფს, სადაც მოსწავლეები გადადიან, არც საწყისი ბრძანება აქვს და არც გააქტიურებული შექმნის ბრძანება");

    //D184: AppClaim ChangePastGroupOrders
    public static Error PastOrderNeedsRight =>
        Error.Conflict(nameof(PastOrderNeedsRight),
            "ბრძანების თარიღი დღევანდელზე ადრეა: წარსული თარიღის ბრძანების შექმნა, შეცვლა და წაშლა მხოლოდ " +
            "სპეციალური უფლებით შეიძლება");

    //D196: AppClaim ChangePastGroupOrders
    public static Error InitialOrderNeedsRight =>
        Error.Conflict(nameof(InitialOrderNeedsRight), "საწყისი ბრძანების შეცვლა მხოლოდ სპეციალური უფლებით შეიძლება");

    //D196
    public static Error InitialOrderCannotBeDeleted =>
        Error.Conflict(nameof(InitialOrderCannotBeDeleted), "საწყისი ბრძანება არ იშლება");

    //D193
    public static Error InitialOrderIsNotPrinted =>
        Error.Conflict(nameof(InitialOrderIsNotPrinted), "საწყისი ბრძანება არ იბეჭდება");

    //D215: დაპაუზებული შექმნის ბრძანება გააქტიურებამდე არ იბეჭდება
    public static Error PausedOrderIsNotPrinted =>
        Error.Conflict(nameof(PausedOrderIsNotPrinted),
            "დაპაუზებული ბრძანება არ იბეჭდება, რადგან ჯერ არ მოქმედებს: მასწავლებლისა და განრიგის შევსების შემდეგ " +
            "ის იმავე ნომრით დაიბეჭდება");

    //D184: დაპაუზებული ბრძანება ძველი თარიღით არ ინახება
    public static Error PausedOrderDateIsInPast =>
        Error.Conflict(nameof(PausedOrderDateIsInPast),
            "დაპაუზებული ბრძანება მხოლოდ დღევანდელი ან მომავალი თარიღით ინახება");

    //D186: კოდი უნიკალურია წელში, დაპაუზებული შექმნის ბრძანებების კოდების ჩათვლით
    public static Error GroupCodeIsTaken =>
        Error.Conflict(nameof(GroupCodeIsTaken),
            "ამ სასწავლო წელში ეს კოდი უკვე აქვს ჯგუფს ან დაპაუზებულ შექმნის ბრძანებას");

    //D190: ბრძანებები 2–10 ჯგუფის დაწყებამდე (საწყისი ან შექმნის ბრძანების თარიღამდე) არ ინახება
    public static Error OrderIsBeforeGroupStart =>
        Error.Conflict(nameof(OrderIsBeforeGroupStart),
            "ბრძანების თარიღი ჯგუფის დაწყებაზე ადრეა: დაწყებამდე ცვლილება ჯგუფის შექმნის ბრძანებაში კეთდება");

    //D190: დახურვის თარიღზე ან მის შემდეგ ჯგუფის ბრძანება არ ინახება
    public static Error GroupIsClosedOnOrderDate =>
        Error.Conflict(nameof(GroupIsClosedOnOrderDate),
            "ჯგუფი ბრძანების თარიღზე უკვე დახურულია: დახურვის შემდეგ ჯგუფი ბრძანებით აღარ იცვლება");

    //D190 (7)
    public static Error GroupHasLaterOrders =>
        Error.Conflict(nameof(GroupHasLaterOrders),
            "ჯგუფი ამ თარიღით ვერ დაიხურება: მას ამ თარიღზე ან მის შემდეგ სხვა ბრძანებები აქვს");

    //D190 (2)
    public static Error TeacherIsAlreadyCurrent =>
        Error.Conflict(nameof(TeacherIsAlreadyCurrent), "ჯგუფს ბრძანების თარიღზე ეს მასწავლებელი უკვე ჰყავს");

    //9: სქემა იცვლება ჯგუფის მოქმედ მასწავლებელს
    public static Error TeacherIsNotCurrent =>
        Error.Conflict(nameof(TeacherIsNotCurrent), "ჯგუფს ბრძანების თარიღზე ეს მასწავლებელი არ ჰყავს");

    //9
    public static Error SalarySchemeIsAlreadyCurrent =>
        Error.Conflict(nameof(SalarySchemeIsAlreadyCurrent), "მასწავლებელს ამ ჯგუფში ეს ხელფასის სქემა უკვე აქვს");

    //D190 (3)
    public static Error StudentIsAlreadyInGroup =>
        Error.Conflict(nameof(StudentIsAlreadyInGroup), "მოსწავლე ბრძანების თარიღზე ამ ჯგუფში უკვე არის");

    //4, 5, 8, 10
    public static Error StudentIsNotInGroup =>
        Error.Conflict(nameof(StudentIsNotInGroup), "მოსწავლე ბრძანების თარიღზე ამ ჯგუფში არ არის");

    //D188 (10): ყოველი მოქმედი მოსწავლის სტრიქონი ახალი საათებით იწყება
    public static Error StudentsMustBeAllCurrent =>
        Error.Conflict(nameof(StudentsMustBeAllCurrent),
            "კვირის საათების შეცვლის ბრძანებაში ჯგუფის ყველა მოსწავლე უნდა იყოს, ვინც ბრძანების თარიღზე ჯგუფშია");

    //D206, D207: ბრძანება a-თი ასრულებს მხოლოდ a-მდე დაწყებულ სტრიქონს
    public static Error RowStartsOnOrderDate =>
        Error.Conflict(nameof(RowStartsOnOrderDate),
            "მასწავლებლის, მოსწავლის ან განრიგის სტრიქონი ბრძანების თარიღზე იწყება: ამ დღის ცვლილება იმ ბრძანების " +
            "შეცვლით კეთდება, რომლითაც სტრიქონი დაიწყო");

    //D190 (5)
    public static Error TargetGroupDoesNotMatch =>
        Error.Conflict(nameof(TargetGroupDoesNotMatch),
            "მოსწავლეები მხოლოდ იმავე სასწავლო წლისა და საგნის ჯგუფში გადადიან");

    //D190 (5)
    public static Error TargetGroupIsNotOpen =>
        Error.Conflict(nameof(TargetGroupIsNotOpen),
            "ჯგუფი, სადაც მოსწავლეები გადადიან, ბრძანების თარიღზე ჯერ არ დაწყებულა ან უკვე დახურულია");

    //D188 (6, 10)
    public static Error ScheduleIsAlreadyCurrent =>
        Error.Conflict(nameof(ScheduleIsAlreadyCurrent), "ახალი განრიგი ჯგუფის მოქმედ განრიგს ემთხვევა");

    //D188 (6)
    public static Error WeeklyHoursMustNotChange =>
        Error.Conflict(nameof(WeeklyHoursMustNotChange),
            "განრიგის შეცვლისას კვირის საათების ჯამი უცვლელი უნდა დარჩეს: საათები კვირის საათების შეცვლის " +
            "ბრძანებით იცვლება");

    //D191
    public static Error CreateOrderHasTransfers =>
        Error.Conflict(nameof(CreateOrderHasTransfers),
            "ჯგუფის შექმნის ბრძანება ვერ წაიშლება: ჯგუფს სხვა ჯგუფთან გადაყვანის ბრძანება აკავშირებს. ჯერ ის ბრძანება " +
            "წაშალეთ");

    //D191
    public static Error CreateOrderHasSalary =>
        Error.Conflict(nameof(CreateOrderHasSalary),
            "ჯგუფის შექმნის ბრძანება ვერ წაიშლება: ჯგუფის გაკვეთილები ხელფასის დათვლაშია");

    //D214: ერთდროული შენახვისას მეორე შენახვა მთლიანად უარყოფილია (ნომრის მთვლელი, წაშლილი ბრძანება)
    public static Error OrderSavedConcurrently =>
        Error.Conflict(nameof(OrderSavedConcurrently),
            "ცვლილება არ შეინახა: ამავე დროს სხვა ბრძანება შეინახა ან წაიშალა. სცადეთ ხელახლა");

    //D194, ვიზარდი 1
    public static Error GroupOrdersAreAlreadyEnabled =>
        Error.Conflict(nameof(GroupOrdersAreAlreadyEnabled), "ბრძანებებზე გადასვლა უკვე გაკეთებულია");

    //D194, ვიზარდი 1: დარღვევები შემოწმების რეპორტშია
    public static Error SwitchHasViolations =>
        Error.Conflict(nameof(SwitchHasViolations),
            "ბრძანებებზე გადასვლა შეუძლებელია: ჯგუფებში დარღვევებია. გაასწორეთ შემოწმების რეპორტის დარღვევები და " +
            "გაიმეორეთ");

    //D195, ვიზარდი 2
    public static Error GroupOrdersAreAlreadyDisabled =>
        Error.Conflict(nameof(GroupOrdersAreAlreadyDisabled),
            "ბრძანებები ჩართული არ არის: ჯგუფების რედაქტირებაზე დასაბრუნებელი არაფერია");

    //D195, ვიზარდი 2
    public static Error ExportFolderIsNotConfigured =>
        Error.Problem(nameof(ExportFolderIsNotConfigured),
            "ბრძანებების ფაილის საქაღალდე (GroupOrders:ExportFolder) კონფიგურაციაში მითითებული არ არის");

    //D195, ვიზარდი 2: ფაილის გარეშე არაფერი იშლება
    public static Error ExportFileWriteFailed =>
        Error.Failure(nameof(ExportFileWriteFailed), "ბრძანებების ფაილი ვერ ჩაიწერა, ამიტომ არაფერი წაშლილა");

    public static Error ExportFileNotFound => Error.NotFound(nameof(ExportFileNotFound), "ბრძანებების ფაილი ვერ მოიძებნა");

    //D185: გადათამაშებისას გვიანდელი ბრძანება აღარ ესადაგება. orderNumber: ამ ბრძანების ნომერი („26.15")
    public static Error OrderNoLongerFits(string orderNumber)
    {
        return Error.Conflict(nameof(OrderNoLongerFits),
            $"ცვლილება შეუძლებელია: მის შემდეგ ბრძანება № {orderNumber} ჯგუფის მდგომარეობას აღარ ესადაგება " +
            "(მაგალითად, მის თარიღზე მოსწავლე ჯგუფში აღარ იქნებოდა). ჯერ ის ბრძანება შეცვალეთ ან წაშალეთ");
    }

    //D187, D194: საათების ფორმულა გადასვლის დღიდან. rows: დარღვეული სტრიქონების აღწერები რიგით, პირველი 10 ჩამოითვლება
    public static Error StudentHoursDoNotMatchSchedule(IReadOnlyCollection<string> rows)
    {
        return Error.Conflict(nameof(StudentHoursDoNotMatchSchedule),
            "მოსწავლის 4 კვირის საათები განრიგს არ შეესაბამება (4 × კოეფიციენტი × განრიგის კვირის საათები): " +
            RowsList(rows));
    }

    //D187, D194: ფასის ფორმულა გადასვლის დღიდან (სხვაობა 0.01-მდე, როგორც r30). rows: როგორც ზემოთ
    public static Error StudentFeeDoesNotMatchHours(IReadOnlyCollection<string> rows)
    {
        return Error.Conflict(nameof(StudentFeeDoesNotMatchHours),
            "მოსწავლის 4 კვირის გადასახადი საათის ფასისა და 4 კვირის საათების ნამრავლს არ უდრის: " + RowsList(rows));
    }

    //პირველი 10 სტრიქონი "; "-ით, მეტისას საერთო რაოდენობაც
    private static string RowsList(IReadOnlyCollection<string> rows)
    {
        const int shownRowsCount = 10;
        string list = string.Join("; ", rows.Take(shownRowsCount));
        if (rows.Count > shownRowsCount)
        {
            list += string.Create(CultureInfo.InvariantCulture, $" და სხვა, სულ {rows.Count}");
        }

        return list;
    }
}
