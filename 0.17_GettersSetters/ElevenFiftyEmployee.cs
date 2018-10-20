using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_GettersSetters
{
    class ElevenFiftyEmployee
    {
        //Fields
        private int _id;      //ID can't be negative
        private int _yearsExperience;  //An employee has some experience.
        private string _jobTitle;
        private string _employeeName; //Name can't be null
        private string _commonWorkQuote;
        private string _company;

        //Dealing with the Id problem. Without the getter and setter, it can be negative.
        public int Id
        {
            get => _id;

            set
            {
                if (value < 0)
                    throw new Exception("The Employee Id is not valid");
                this._id = value;
            }
 
        }


        //Dealing with the Id problem. Without the getter and setter, it can be negative.

        public string Name
        {
            get => _employeeName;
          
            set
            {
                try
                {
                    this._employeeName = value;
                }
                catch (Exception)
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("The Employee name is not valid");
                }
            }
        }

        public void SetCommonWorkQuote(string quote)
        {
            _commonWorkQuote = quote;
        }

        public string GetQuote()
        {
            return _commonWorkQuote;
        }

        //Use this if you don't have conditions to deal with.
        public string CommonWorkQuote { get; set; }
        public string CompanyName { get; set; }
    }
}
