namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ხელით შეტანილი ხელფასის მდგენელის შექმნის ან შეცვლის მოთხოვნა: თანამშრომლის კონტრაქტი, მდგენელის ტიპი და თანხა.
///     გამოქვითვა (ტიპი, რომლის გამოთვლის ადგილი 2-ია) დადებითი თანხით იწერება; ტიპი 1 (ჩატარებული გაკვეთილების
///     ხელფასი) მხოლოდ გამოთვლით იქმნება
/// </summary>
public sealed class SalaryPartRequest
{
    public int TeacherContractId { get; init; }
    public int? SalaryPartTypeId { get; init; }
    public decimal SpAmount { get; init; }
}
