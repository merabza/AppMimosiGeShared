using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

public sealed record GroupTeacherResponse(
    int Id,
    int TeacherContractId,
    int SalarySchemaId,
    DateTime StartDate,
    DateTime? EndDate);
