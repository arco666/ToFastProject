using ToFast.Data;

namespace ToFast.Data
{
    public class DataRepository
    {
        public static FromLocationData FromLocation { get; } = new FromLocationData();
        public static QuestionIndexData QuestionIndex { get; } = new QuestionIndexData();
        public static SettingData Setting { get; } = new SettingData();
        public static StudentData Student { get; } = new StudentData();
        public static SubjectData Subject { get; } = new SubjectData();
        public static TeacherData Teacher { get; } = new TeacherData(); 
        public static TimeCountData TimeCount { get; } = new TimeCountData();

        public static Teacher ProfessorUser { get; set; } = new Teacher();
    }
}