using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ViewNumberSeq.Models
{
    public class Number
    {
        /// <summary>
        /// integer value of a input number
        /// </summary>
        [Required(AllowEmptyStrings =false,ErrorMessage ="Pleae input a integer number")]
        [Range(1,Int32.MaxValue,ErrorMessage ="Please input a integer value larger than zero.")]
        public int number { get; set; }

        public List<int> Numbers { get; set; }

        public string AllNumberstring { get; set; }
        public string OddNumberstring { get; set; }
        public string EvenNumberstring { get; set; }
        public string SpecialNumberstring { get; set; }
        public string FibonacciNumberstring { get; set; }

        public Number()
        {
            Numbers = new List<int>();
        }
        /// <summary>
        /// Build display strings
        /// </summary>
        public void buildSeq()
        {
            for (int i = 1; i <= number; i++)
            {
                Numbers.Add(i);
            }
            foreach (int n in Numbers)
            {
                AllNumberstring += n.ToString() + ",";
                if (n % 2 == 0)
                    EvenNumberstring += n.ToString() + ",";
                else
                    OddNumberstring += n.ToString() + ",";
            }
            // return special charactors
            foreach (int n in Numbers)
            {
                if (n % 3 == 0)
                    SpecialNumberstring += "C,";
                else if (n % 5 == 0)
                    SpecialNumberstring += "E,";
                else if (n % 15 == 0)
                    SpecialNumberstring += "z,";
                else
                    SpecialNumberstring += n.ToString() + ",";
            }
            // return fibonacci numbers
            int oldNumber = 1;
            int currentNumber = 1;
            int nextNumber;

            while (currentNumber <=number)
            {
                FibonacciNumberstring += currentNumber.ToString() + ",";
                nextNumber = currentNumber + oldNumber;
                oldNumber = currentNumber;
                currentNumber = nextNumber;
            }
        }
    }
}