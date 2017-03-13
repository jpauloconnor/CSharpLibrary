using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_GettersSetters
{
    class ElevenFiftyEmployee
    {
        //Variables
        private int _id;      //ID can't be negative
        private int _yearsExperience;  //An employee has some experience.
        private string _jobTitle;
        private string _employeeName; //Name can't be null
        private string _commonWorkQuote;
        private string _company;

        //Dealing with the Id problem. Without the getter and setter, it can be negative.

        public int Id
        {
            set
            {
                if (Id < 0)
                    throw new Exception("The Employee Id is not valid");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }


        //Dealing with the Id problem. Without the getter and setter, it can be negative.

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The Employee name is not valid");
                this._employeeName = value;
            }
            get
            {
                return this._employeeName;
            }
        }



        public void SetCommonWorkQuote(string quote)
        {
            this._commonWorkQuote = quote;
        }

        public string GetQuote()
        {
            return this._commonWorkQuote;
        }

        //Use this if you don't have conditions to deal with.
        public string CommonWorkQuote { get; set; }
        public string CompanyName { get; set; }
    }
}
