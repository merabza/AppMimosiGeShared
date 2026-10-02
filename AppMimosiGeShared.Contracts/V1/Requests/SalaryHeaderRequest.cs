using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ხელფასის უწყისის შექმნის ან შეცვლის მოთხოვნა. დარიცხვის თარიღით პოულობს გამოთვლა ჩატარებული გაკვეთილების
///     ხელფასს (თვის 1-ლი + 1 თვე + 4 დღე, ანუ ჩვეულებრივ შემდეგი თვის 5 რიცხვი); დროის ნაწილი არ ინახება
/// </summary>
public sealed class SalaryHeaderRequest
{
    public DateTime ShChargeDate { get; init; }
    public DateTime ShTransferDate { get; init; }
}
