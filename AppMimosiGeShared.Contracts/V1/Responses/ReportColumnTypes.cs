namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტის სვეტის ტიპები: ტექსტი, მთელი რიცხვი, თანხა/რიცხვი, დრო (HH:mm), თარიღი, თარიღი და დრო
/// </summary>
public static class ReportColumnTypes
{
    public const string Text = "text";
    public const string WholeNumber = "wholeNumber";
    public const string Number = "number";
    public const string Time = "time";
    public const string Date = "date";
    public const string DateTime = "dateTime";
}
