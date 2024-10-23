namespace omg.models
{
    public class assessmentka
    {
        public int Id { get; set; }
        public int assessment { get; set; }
        public int subject_taught_id { get; set; }
        public int student_id { get; set; }
        public string date { get; set; }
    }
}
