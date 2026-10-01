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
}
