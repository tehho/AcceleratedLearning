using System;

namespace Modul6
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthdate { get; }

        public Gender Gender { get; }

        public Sport FavoritSport { get; set; }

        public Person()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Birthdate = DateTime.Now;
            Gender = Gender.Unknown;
            FavoritSport = Sport.Hurling;

        }

        public Person(string firstName, string lastName, DateTime birthdate, Gender gender, Sport favoritSport)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Gender = gender;
            FavoritSport = favoritSport;
        }

        public Person(string firstName, string lastName, DateTime birthdate, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Gender = gender;
            FavoritSport = Sport.Hurling;
        }

        public override string ToString()
        {
            return $"My name is {FirstName} {LastName}, im a {Gender}.\nI was born on {Birthdate.ToShortDateString()}\nI like to play {FavoritSport}";
        }

    }
}