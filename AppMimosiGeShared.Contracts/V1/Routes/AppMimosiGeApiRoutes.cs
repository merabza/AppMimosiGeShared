namespace AppMimosiGeShared.Contracts.V1.Routes;

public static class AppMimosiGeApiRoutes
{
    private const string Api = "api";
    private const string Version = "v1";
    public const string ApiBase = Api + "/" + Version;

    public static class StudentContractsRoute
    {
        public const string StudentContractsBase = "/studentcontracts";

        // GET api/v1/studentcontracts/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/studentcontracts/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/studentcontracts/humans?search={text}
        public const string Humans = "/humans";

        // GET api/v1/studentcontracts/nextnumber?academicYearId={id}
        public const string NextNumber = "/nextnumber";

        // GET api/v1/studentcontracts/{scId:int}
        public const string GetOne = "/{scId:int}";

        // POST api/v1/studentcontracts
        public const string Create = "";

        // PUT api/v1/studentcontracts/{scId:int}
        public const string Update = "/{scId:int}";

        // DELETE api/v1/studentcontracts/{scId:int}
        public const string Delete = "/{scId:int}";
    }

    public static class TeacherContractsRoute
    {
        public const string TeacherContractsBase = "/teachercontracts";

        // GET api/v1/teachercontracts/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/teachercontracts/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/teachercontracts/humans?search={text}
        public const string Humans = "/humans";

        // GET api/v1/teachercontracts/{id:int}
        public const string GetOne = "/{id:int}";

        // POST api/v1/teachercontracts
        public const string Create = "";

        // PUT api/v1/teachercontracts/{id:int}
        public const string Update = "/{id:int}";

        // DELETE api/v1/teachercontracts/{id:int}
        public const string Delete = "/{id:int}";
    }

    public static class GroupsRoute
    {
        public const string GroupsBase = "/groups";

        // GET api/v1/groups/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/groups/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/groups/studentcontracts?academicYearId={id}
        public const string StudentContracts = "/studentcontracts";

        // GET api/v1/groups/{grpId:int}
        public const string GetOne = "/{grpId:int}";

        // POST api/v1/groups
        public const string Create = "";

        // PUT api/v1/groups/{grpId:int}
        public const string Update = "/{grpId:int}";

        // DELETE api/v1/groups/{grpId:int}
        public const string Delete = "/{grpId:int}";
    }

    public static class LessonGeneratorRoute
    {
        public const string LessonGeneratorBase = "/lessongenerator";

        // POST api/v1/lessongenerator/groups/{grpId:int}?dryRun={bool}
        public const string GroupLessons = "/groups/{grpId:int}";

        // POST api/v1/lessongenerator/groups/{grpId:int}/lastlesson
        public const string GroupLastLesson = "/groups/{grpId:int}/lastlesson";

        // POST api/v1/lessongenerator/dirtygroups?dryRun={bool}
        public const string DirtyGroups = "/dirtygroups";

        // POST api/v1/lessongenerator/allgroups?dryRun={bool}
        public const string AllGroups = "/allgroups";

        // GET api/v1/lessongenerator/log?grpId={id}
        public const string Log = "/log";
    }

    public static class LessonsRoute
    {
        public const string LessonsBase = "/lessons";

        // GET api/v1/lessons/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/lessons/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/lessons/{lessonId:int}
        public const string GetOne = "/{lessonId:int}";

        // PUT api/v1/lessons/{lessonId:int}
        public const string Update = "/{lessonId:int}";
    }

    public static class PaymentsRoute
    {
        public const string PaymentsBase = "/payments";

        // GET api/v1/payments/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/payments/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/payments/studentcontracts?academicYearId={id}
        public const string StudentContracts = "/studentcontracts";

        // GET api/v1/payments/{paymentId:int}
        public const string GetOne = "/{paymentId:int}";

        // POST api/v1/payments
        public const string Create = "";

        // PUT api/v1/payments/{paymentId:int}
        public const string Update = "/{paymentId:int}";

        // DELETE api/v1/payments/{paymentId:int}
        public const string Delete = "/{paymentId:int}";
    }

    public static class ChargesAndPaymentsRoute
    {
        public const string ChargesAndPaymentsBase = "/chargesandpayments";

        // GET api/v1/chargesandpayments/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/chargesandpayments/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/chargesandpayments/studentcontracts?academicYearId={id}
        public const string StudentContracts = "/studentcontracts";
    }

    public static class DepositsRoute
    {
        public const string DepositsBase = "/deposits";

        // GET api/v1/deposits/rows?academicYearId={id}&maximum={number}&dateTo={yyyy-MM-dd}&filter={filter|call}
        public const string Rows = "/rows";

        // GET api/v1/deposits/formlookups
        public const string FormLookups = "/formlookups";

        // POST api/v1/deposits/recount
        public const string Recount = "/recount";

        // POST api/v1/deposits/fullrecount
        public const string FullRecount = "/fullrecount";
    }

    public static class CrmCallsRoute
    {
        public const string CrmCallsBase = "/crmcalls";

        // GET api/v1/crmcalls/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/crmcalls/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/crmcalls/studentcontracts?academicYearId={id}
        public const string StudentContracts = "/studentcontracts";

        // GET api/v1/crmcalls/{crmCallId:int}
        public const string GetOne = "/{crmCallId:int}";

        // POST api/v1/crmcalls
        public const string Create = "";

        // PUT api/v1/crmcalls/{crmCallId:int}
        public const string Update = "/{crmCallId:int}";

        // DELETE api/v1/crmcalls/{crmCallId:int}
        public const string Delete = "/{crmCallId:int}";
    }

    public static class WorkHoursRoute
    {
        public const string WorkHoursBase = "/workhours";

        // GET api/v1/workhours/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/workhours/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/workhours/{whId:int}
        public const string GetOne = "/{whId:int}";

        // POST api/v1/workhours
        public const string Create = "";

        // PUT api/v1/workhours/{whId:int}
        public const string Update = "/{whId:int}";

        // DELETE api/v1/workhours/{whId:int}
        public const string Delete = "/{whId:int}";

        // POST api/v1/workhours/start
        public const string Start = "/start";

        // POST api/v1/workhours/end
        public const string End = "/end";

        // POST api/v1/workhours/autogenerate
        public const string AutoGenerate = "/autogenerate";
    }

    public static class SalaryRoute
    {
        public const string SalaryBase = "/salary";

        // GET api/v1/salary/headers
        public const string Headers = "/headers";

        // GET api/v1/salary/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/salary/{shId:int}
        public const string GetOne = "/{shId:int}";

        // POST api/v1/salary
        public const string Create = "";

        // PUT api/v1/salary/{shId:int}
        public const string Update = "/{shId:int}";

        // DELETE api/v1/salary/{shId:int}
        public const string Delete = "/{shId:int}";

        // POST api/v1/salary/{shId:int}/parts
        public const string CreatePart = "/{shId:int}/parts";

        // PUT api/v1/salary/parts/{spId:int}
        public const string UpdatePart = "/parts/{spId:int}";

        // DELETE api/v1/salary/parts/{spId:int}
        public const string DeletePart = "/parts/{spId:int}";

        // POST api/v1/salary/{shId:int}/count
        public const string Count = "/{shId:int}/count";

        // GET api/v1/salary/{shId:int}/transferfile
        public const string TransferFile = "/{shId:int}/transferfile";

        // GET api/v1/salary/declarationfile?month=yyyy-MM-dd
        public const string DeclarationFile = "/declarationfile";
    }

    public static class AcademicYearsRoute
    {
        // GET api/v1/academicyears
        public const string AcademicYearsBase = "/academicyears";

        public const string List = "";
    }

    public static class AcademicYearRoute
    {
        public const string AcademicYearBase = "/academicyear";

        // GET api/v1/academicyear/info
        public const string Info = "/info";

        // POST api/v1/academicyear/create?dryRun={bool}
        public const string Create = "/create";

        // POST api/v1/academicyear/{ayId:int}/closegroups?closeDate=yyyy-MM-dd&dryRun={bool}
        public const string CloseGroups = "/{ayId:int}/closegroups";
    }

    public static class ReportsRoute
    {
        public const string ReportsBase = "/reports";

        // GET api/v1/reports/catalog
        public const string Catalog = "/catalog";

        // GET api/v1/reports/lookups
        public const string Lookups = "/lookups";

        // GET api/v1/reports/{key}?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&teacherId=&courseId=&studentId=
        public const string Run = "/{key}";

        // GET api/v1/reports/{key}/excel?startDate=…&endDate=…
        public const string Excel = "/{key}/excel";
    }
}
