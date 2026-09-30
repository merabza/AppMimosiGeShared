using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჯგუფის მასწავლებელი პერიოდით [StartDate, EndDate). Id 0 ახალ სტრიქონს ნიშნავს.
///     თუ SalarySchemaId არ არის მითითებული, ეწერება მასწავლებლის კონტრაქტის ძირითადი სქემა (SalarySchemaByHours)
/// </summary>
public sealed class GroupTeacherRequest
{
    public int Id { get; init; }
    public int TeacherContractId { get; init; }
    public int? SalarySchemaId { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}
