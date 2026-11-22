using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანების მასწავლებლის ხაზი. StartDate და EndDate მხოლოდ საწყის ბრძანებას აქვს
/// </summary>
public sealed record GroupOrderTeacherResponse(
    int Id,
    int TeacherContractId,
    int SalarySchemaId,
    DateTime? StartDate,
    DateTime? EndDate);
