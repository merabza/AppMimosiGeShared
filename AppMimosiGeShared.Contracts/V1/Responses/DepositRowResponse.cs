using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბალანსების (Access-ის vFrmDeposites) ერთი კონტრაქტი. StudentName და PayerName "გვარი სახელი"-ა.
///     Balance: ოპერაციების ჯამი "თარიღამდე" ჩათვლით (null, თუ ოპერაცია არ არის). NextLessonDate: დღეიდან პირველი
///     გაუქმებელი გაკვეთილი. CrmMustPayDate: ბოლო ზარის "უნდა გადაიხადოს თარიღამდე". FourWeekFee: ჯგუფების ოთხკვირიანი
///     გადასახადების ჯამი, რომლებიც "თარიღამდე" არ დასრულებულა. DesiredNextPayDate / DesiredAfterNextPayDate: გადახდის
///     სასურველი დღის შემდეგი და მომდევნო თარიღი, DesiredDayAmount: გადასახდელი მომდევნო თარიღის შემდეგ დღემდე.
///     StopDate: კონტრაქტის შემდეგი გადახდის თარიღი. MustPayToEnd: გადასახდელი სწავლის დასრულებამდე, EndDate დასრულების
///     სავარაუდო თარიღი
/// </summary>
public sealed record DepositRowResponse(
    int StudentContractId,
    int AcademicYearId,
    string StudentName,
    string ContractNumber,
    decimal? Balance,
    string? StudentPhone,
    string PayerName,
    string? PayerPhone,
    DateTime? NextLessonDate,
    DateTime? CrmMustPayDate,
    decimal? FourWeekFee,
    int? DesiredMonthlyPaymentDay,
    DateTime? DesiredNextPayDate,
    DateTime? DesiredAfterNextPayDate,
    decimal? DesiredDayAmount,
    DateTime? StopDate,
    decimal? MustPayToEnd,
    DateTime? EndDate);
