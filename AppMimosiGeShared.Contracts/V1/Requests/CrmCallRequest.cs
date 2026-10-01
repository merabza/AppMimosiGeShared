using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     CRM ზარის შექმნის ან შეცვლის მოთხოვნა. CallDate თარიღი და დროა, MustPayDate ("უნდა გადაიხადოს თარიღამდე")
///     მხოლოდ თარიღი. AnswerTypeId (შედეგი) სავალდებულოა; null ნიშნავს, რომ არ აურჩევიათ
/// </summary>
public sealed class CrmCallRequest
{
    public int StudentContractId { get; init; }
    public int CallTypeId { get; init; }
    public DateTime CallDate { get; init; }
    public int? AnswerTypeId { get; init; }
    public string? CallConversation { get; init; }
    public DateTime? MustPayDate { get; init; }
}
