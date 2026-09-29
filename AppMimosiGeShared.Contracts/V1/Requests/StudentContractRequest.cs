using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     მოსწავლის კონტრაქტის შექმნის ან შეცვლის მოთხოვნა (დეტალებთან ერთად)
/// </summary>
public sealed class StudentContractRequest
{
    public string? ContractNumber { get; init; }
    public DateTime ContractDate { get; init; }
    public int StudentHumanId { get; init; }

    /// <summary>
    ///     გადამხდელი: მშობელი ან თვითონ მოსწავლე
    /// </summary>
    public int PayerHumanId { get; init; }

    public int AcademicYearId { get; init; }
    public int? StudentStatusId { get; init; }
    public int? DesiredMonthlyPaymentDay { get; init; }
    public List<StudentContractDetailRequest> Details { get; init; } = [];
}
