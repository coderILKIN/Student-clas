using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Student
    {
        public string FullName;
        private string _groupNo;
        public byte Age;


        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public Student(string fullName, string groupNo, byte age)
        {
            FullName = fullName;
            GroupNo = groupNo;
            Age = age;
        }
        public static bool CheckFullname(string fullName)
        {
            bool rightFormat = false;
            foreach (char lett in fullName)
            {
                if (char.IsWhiteSpace(lett))
                {
                    rightFormat = true;
                }
                if (char.IsDigit(lett))
                {
                    rightFormat = false;
                }
            }
            return rightFormat;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            bool check = false;
            bool hasDigit = false;
            int count = 0;

            for (int i = 0; i < groupNo.Length; i++)
            {

                if (char.IsUpper(groupNo[0]))
                {
                    check = true;
                }
                if (char.IsDigit(groupNo[i]))
                {
                    count++;
                    if (count == 3)
                    {
                        hasDigit = true;
                    }
                    else
                    {
                        hasDigit = false;
                    }
                }

            }

            bool result = check && hasDigit;

            return result;
        }

        public void Info()
        {
            Console.WriteLine($"Fullname: {FullName}\nGroup: {GroupNo}\nAge: {Age}");
        }
    }


}














    

