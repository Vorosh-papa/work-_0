namespace omg.models
{
    public class subject_taught
    {
        public int Id { get; set; }
        public string name_of_subject_taughts { get; set; }
        public int teacher_id { get; set; }
        public string classroom { get; set; }
        public int number_of_hours_per_1_course { get; set; }
        public int number_of_hours_per_2_course { get; set; }
        public int number_of_hours_per_3_course { get; set; }
        public int number_of_hours_per_4_course { get; set; }
    }
}
