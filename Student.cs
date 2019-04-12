using System.Collections.Generic;

namespace NSS
{
    public class Student
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string slackHanle {get; set;}
        public Cohort cohort {get; set;}
        public List<Exercise> exercisezzz {get; set;} = new List<Exercise> ();



    }
}


