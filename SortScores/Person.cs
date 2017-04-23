using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortScores
{
    public class Person
    {
        private String firstName = "dum";
        private String lastName = "dum";
        private float score = 0;

        public Person(String firstName, String lastName, float score)
        {
            setFirstName(firstName);
            setLastName(lastName);
            setScore(score);
        }

        public String getFirstName() {
            return this.firstName;
        }

        public bool setFirstName(String firstName) {
            this.firstName = firstName;
            return true;
        }

        public bool setLastName(String lastName) {
            this.lastName = lastName;
            return true;
        }

        public String getLastName() {
            return this.lastName;
        }

        public bool setScore(float score) {
            this.score = score;
            return true;
        }

        public float getScore() {
            return this.score;
        }
    }
}
