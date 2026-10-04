using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     უწყისის სტრიქონი (გამოთვლის შედეგი, მხოლოდ საჩვენებელი)
/// </summary>
public sealed record SalaryLineResponse(
    int SaId,
    int TeacherContractId,
    string EmployeeName,
    decimal SaNetAmountRound,
    decimal SaAmountGross,
    decimal SaPension2,
    decimal SaGrossMinusPension,
    decimal SaIncomeTax,
    decimal SaGamokvitva,
    decimal SaPension4,
    decimal SaAmountNet,
    DateTime SaMonthDate,
    int? RsQuoteTypeId,
    decimal SaIndividualIncomeTax);
