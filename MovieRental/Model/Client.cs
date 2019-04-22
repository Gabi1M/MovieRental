using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    class Client : BaseEntity
    {
        private string name;
        private string gender;
        private int age;

        public Client()
        {

        }

        public Client(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return base.ToString() + "Client { Name = " + this.name + ", Gender = " + this.gender + ", Age = " + this.age + " }";
        }
    }
}
