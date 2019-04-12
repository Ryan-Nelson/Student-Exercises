using System;

namespace NSS
{
 class Program {
        static void Main (string[] args) {
            
            Cohort c28 = new Cohort () {
                cohortName = "Cohort 28"
            };
            Cohort c29 = new Cohort () {
                cohortName = "Cohort 29"
            };
            Cohort c30 = new Cohort () {
                cohortName = "Cohort 30"
            };

            // Create three buildings
            Student ryanNelson = new Student () {
                firstName = "Ryan",
                lastName = "Nelson",
                slackHanle = "ryan@slack",
                cohort = c30

            };
            Student brianNeil = new Student () {
                firstName = "Brian",
                lastName = "Neil",
                slackHanle = "brian@slack",
                cohort = c30

            };
            Student gradyRobbins = new Student () {
                firstName = "Grady",
                lastName = "Robbins",
                slackHanle = "grady@slack",
                cohort = c29

            };
            Student jonhWoods = new Student () {
                firstName = "John",
                lastName = "Woods",
                slackHanle = "jonh@slack",
                cohort = c28

            };
            Student andyHerring = new Student () {
                firstName = "Andy",
                lastName = "Herring",
                slackHanle = "andy@slack",
                cohort = c28

            };
            Instructor steve = new Instructor (){
                firstName = "Steve",
                lastName = "Brownlee",
                slackHanle = "steve@slack", 
                instructorCohort = c30
            };
            Instructor andy = new Instructor (){
                firstName = "Andy",
                lastName = "Collins",
                slackHanle = "andy@slack", 
                instructorCohort = c29
            };
            Instructor joe = new Instructor (){
                firstName = "Joe",
                lastName = "Shepherd",
                slackHanle = "joe@slack", 
                instructorCohort = c28
            };
            Exercise urbanPlanner = new Exercise (){
                name = "urban planner",
                language = "C#"
            };
            Exercise reactKennels = new Exercise (){
                name = "react kennels",
                language = "C#"
            };
            Exercise theTernaryTraveler = new Exercise (){
                name = "The Ternary Traveler",
                language = "JavaScript"
            };
            Exercise gameOfThrones = new Exercise (){
                name = "Game of Thrones",
                language = "javaScript"
            };
            steve.addExercise(ryanNelson, urbanPlanner);
            steve.addExercise(brianNeil, urbanPlanner);
            steve.addExercise(ryanNelson, reactKennels);
            steve.addExercise(brianNeil, reactKennels);
            andy.addExercise(gradyRobbins, theTernaryTraveler);
            andy.addExercise(gradyRobbins, gameOfThrones);
            joe.addExercise(andyHerring, gameOfThrones);
            joe.addExercise(jonhWoods, gameOfThrones);
            joe.addExercise(andyHerring, reactKennels);
            joe.addExercise(jonhWoods, reactKennels);
// Create 4, or more, exercises.
// Create 3, or more, cohorts.
// Create 4, or more, students and assign them to one of the cohorts.
// Create 3, or more, instructors and assign them to one of the cohorts.
// Have each instructor assign 2 exercises to each of the students.
        }
    }
}
