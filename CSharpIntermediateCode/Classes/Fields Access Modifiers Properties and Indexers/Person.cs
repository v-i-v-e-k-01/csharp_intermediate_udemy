
using System;
using System.Globalization;

namespace Fields
{
    // Access Modifiers
    
    public class Person
    {
        //// private -- (Encapsulation in practice)
        //private string _name;

        ////Setters and Getters provide manipulation of private fields

        ////Setter -- Stores input value into private field 

        //public void SetName(string name)
        //{
        //    if (!String.IsNullOrEmpty(name))
        //    {
        //        this._name = name;

        //    }
        //}


        ////Getter -- Returns private field value stored in  object 
        //public string GetName()
        //{
        //    //return this.Name;
        //    //OR
        //    return _name;
        //}


        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    this._birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}

        /////////////////////////////////

        //Properties

        //private DateTime _birthdate;


        //get, set and value are all predefined keywords

        //public DateTime Birthdate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }
        //}

        ////OR 
        // Auto Implement
        public string Name { get; set; }
        public string UserName { get; set; }

        //constructor
        public Person( DateTime birthdate)
        {
            Birthdate = birthdate; //setting birthdate while creating object itself and blocking change/set using private keyword in property 
        }

        public DateTime Birthdate
        {
            get; private set; //blocking change setting using private keyword
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                
                return (int)timeSpan.TotalDays / 365;
            }
            
            //set is not used as age is calculated by using birthdate
        }



    }
}
