using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ამონაწერის ერთი ოპერაცია (Access-ის vFrmChargesAndPayments). დარიცხვა (IsPayment = false) LessonsByStudents-ის
///     სტრიქონია: Id მისია, თარიღი გაკვეთილისა, დოკუმენტი საგნის სახელი, თანხა უარყოფითი. გადახდის Id გადახდისაა.
///     ორი სახის Id შეიძლება დაემთხვეს. StudentName "გვარი სახელი / ნომერი"-ა. RunningTotal ნაშთია ამ ოპერაციის შემდეგ:
///     ყველა ოპერაციის ჯამი თავიდან (ფილტრის "თარიღიდან"-ის მიუხედავად) ამონაწერის რიგით
/// </summary>
public sealed record StatementRowResponse(
    bool IsPayment,
    int Id,
    int StudentContractId,
    string StudentName,
    DateTime OperationDate,
    string? Document,
    decimal Amount,
    decimal RunningTotal);
