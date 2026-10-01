using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გენერატორის ერთი ცვლილება გაკვეთილზე. Action: "create", "update" ან "delete". ახალი გაკვეთილის LessonId dry-run-ში
///     ცარიელია. update-ში ChangedFields გაკვეთილის შეცვლილი ველებია (lessonDt, teacherContractId, salarySchemaId,
///     fourWeekHours, teoMinDate, teoMaxDate; ცარიელია, თუ მხოლოდ მოსწავლეები შეიცვალა), PreviousLessonDt კი ძველი დრო,
///     თუ ის შეიცვალა. მოსწავლეების რაოდენობები არსებული გაკვეთილის მოსწავლეების სტრიქონებს ითვლის
/// </summary>
public sealed record LessonChangeResponse(
    string Action,
    int? LessonId,
    DateTime LessonDt,
    DateTime? PreviousLessonDt,
    List<string> ChangedFields,
    int AddedStudentsCount,
    int UpdatedStudentsCount,
    int DeletedStudentsCount);
