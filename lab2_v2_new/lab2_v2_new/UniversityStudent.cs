using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_v2_new
{

    abstract class Mark
    {
        public static void CheckIsValid(int _value)
        {
            if (_value < 0)
            {
                throw new ArgumentOutOfRangeException("Mark can't be negative", "_value");
            }
            else if (_value > 5)
            {
                throw new ArgumentOutOfRangeException("Mark can't be bigger than 5", "_value");
            }
        }
    }

    abstract class Scholarship
    {
        public static bool IsAvailable(int[] marks) {
            return (marks.Average() >= 4);
        }

    }

    class UniversityStudent
    {
        /************************************************/

        public const ushort N_OF_SUBJECTS = 10;

        /************************************************/

        public string name { get; private set; }

        public string surname { get; private set; }

        public string patronymic { get; private set; }

        public uint course { get; private set; }

        public DateTime birthday { get; private set; }

        private double m_scholarship;

        public double scholarship
        {
            get
            {
                return m_scholarship;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Scholarship value cant't be negative", "value");
                }
                m_scholarship = value;
            }
        }

        public double balance { get; private set; }

        // Тут так и просится ushort. Но ushort и short не поддерживаются в LINQ
        private int[] marks;

        /************************************************/

        public UniversityStudent(
            string _name, string _surname, string _patronymic, 
            uint _course, DateTime _birthday, double _scholarship, 
            double _balance)
        {
            name = _name;
            surname = _surname;
            patronymic = _patronymic;
            course = _course;
            birthday = _birthday;
            scholarship = _scholarship;
            balance = _balance;

            marks = new int[N_OF_SUBJECTS];
        }

        /************************************************/

        public void AddScholarship()
        {
            if (Scholarship.IsAvailable(marks))
            {
                balance += scholarship;
            }
            else
            {
                throw new ArgumentException("Unable to add scholarship: average mark is smaller than 4");
            }
        }

        public double Withdraw(double _sum)
        {
            if (balance < _sum)
            {
                throw new ArgumentOutOfRangeException("Specified sum is exceeds balance", "_sum");
            }
            else
            {
                balance -= _sum;
                return _sum;
            }
        }

        public void SetMark(int _subject_id, int _value)
        {
            Mark.CheckIsValid(_value);

            try
            {
                marks[_subject_id] = _value;
            }
            catch (IndexOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int GetMark(int _subject_id)
        {
            try {
                return marks[_subject_id];
            }
            catch (IndexOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void RaiseCourse()
        {
            ++ course;
        }

        public void Deduct()
        {
            course = 0;
            Array.Clear(marks, 0, marks.Length);
        }

        /************************************************/

        public static bool operator == (UniversityStudent _obj1, UniversityStudent _obj2)
        {
            return (
                   _obj1.name       == _obj2.name
                && _obj1.surname    == _obj2.surname
                && _obj1.patronymic == _obj2.patronymic
                && _obj1.marks.SequenceEqual(_obj2.marks)
                );
        }

        public static bool operator != (UniversityStudent _obj1, UniversityStudent _obj2)
        {
            return !(_obj1 == _obj2);
        }

        
        /************************************************/
    }
}
