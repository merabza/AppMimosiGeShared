using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ბრძანების მასწავლებლის ხაზი. Id 0 ახალ ხაზს ნიშნავს; შეცვლისას არსებული ხაზი თავის Id-ს ინარჩუნებს, რომ მისმა
///     სტრიქონმაც შეინარჩუნოს. თუ SalarySchemaId არ არის მითითებული, ეწერება მასწავლებლის კონტრაქტის ძირითადი სქემა
///     (D187). ბრძანება 9-ში ეს ჯგუფის მოქმედი მასწავლებელია ახალი სქემით. StartDate და EndDate მხოლოდ საწყის
///     ბრძანებაშია: სხვა ბრძანების სტრიქონი მისი თარიღიდან იწყება
/// </summary>
public sealed class GroupOrderTeacherRequest
{
    public int Id { get; init; }
    public int TeacherContractId { get; init; }
    public int? SalarySchemaId { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}
