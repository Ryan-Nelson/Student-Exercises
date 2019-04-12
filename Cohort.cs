namespace NSS
{
    public class Cohort
    {
        public string cohortName {get; set;}
        public List<Student> student {get; set;} = new List<Student> ();
        public List<Instructor> instructor {get; set;} = new List<Instructor> ();
    }
}

// The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
// The collection of students in the cohort.
// The collection of instructors in the cohort.