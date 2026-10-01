using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     CRM ზარების სიის ერთი სტრიქონი. StudentName "გვარი სახელი / ნომერი"-ა, როგორც Access-ის ფორმის ჩამოსაშლელ სიაში.
///     CallConversation სრული ტექსტია; სია მას შემოკლებით აჩვენებს
/// </summary>
public sealed record CrmCallRowResponse(
    int Id,
    int StudentContractId,
    string StudentName,
    DateTime CallDate,
    int CallTypeId,
    string CallTypeName,
    int AnswerTypeId,
    string AnswerTypeName,
    string? CallConversation,
    DateTime? MustPayDate);
