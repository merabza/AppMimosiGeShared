using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფის მოსწავლე. StudentContractName: "გვარი სახელი / კონტრაქტის ნომერი", როგორც Access-ის ფორმაში
/// </summary>
public sealed record GroupStudentResponse(
    int Id,
    int StudentContractId,
    string StudentContractName,
    float FourWeekHours,
    decimal FourWeekFee,
    decimal OneHourFee,
    float HoursCoefficient,
    DateTime StartDate,
    DateTime? EndDate,
    string? Note);
