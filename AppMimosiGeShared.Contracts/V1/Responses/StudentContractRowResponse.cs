using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     კონტრაქტების სიის ერთი სტრიქონი
/// </summary>
public sealed record StudentContractRowResponse(
    int ScId,
    string ContractNumber,
    DateTime ContractDate,
    int StudentHumanId,
    string StudentName,
    int PayerHumanId,
    string PayerName,
    int AcademicYearId,
    string AcademicYearName,
    int? StudentStatusId,
    string? StudentStatusName,
    int? DesiredMonthlyPaymentDay);
