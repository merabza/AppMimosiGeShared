using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანების მოსწავლის ხაზი. StudentContractName: „გვარი სახელი / კონტრაქტის ნომერი", როგორც ჯგუფის ფორმაში.
///     ტარიფი გაყვანის ბრძანებაში ცარიელია, StartDate და EndDate კი მხოლოდ საწყის ბრძანებას აქვს
/// </summary>
public sealed record GroupOrderStudentResponse(
    int Id,
    int StudentContractId,
    string StudentContractName,
    float? FourWeekHours,
    decimal? FourWeekFee,
    decimal? OneHourFee,
    float? HoursCoefficient,
    string? Note,
    DateTime? StartDate,
    DateTime? EndDate);
