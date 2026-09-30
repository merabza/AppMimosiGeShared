using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     თანამშრომლების კონტრაქტების სიის ერთი სტრიქონი
/// </summary>
public sealed record TeacherContractRowResponse(
    int Id,
    string ContractNumber,
    DateTime ContractDate,
    int TeacherHumanId,
    string TeacherName,
    string? SalarySchemeName,
    bool PensionScheme,
    bool IndEnt,
    decimal FixedAmount,
    DateTime? ContractEndDate);
