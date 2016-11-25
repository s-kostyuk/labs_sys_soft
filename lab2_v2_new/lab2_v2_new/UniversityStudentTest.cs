using System;
using NUnit.Framework;

namespace lab2_v2_new
{
    [TestFixture]
    public class UniversityStudentTest
    {
        public const string name = "Ivan";
        public const string patronymic = "Ivanovich";
        public const string surname = "Ivanov";
        public const uint course = 1;
        public DateTime birthday = new DateTime(1998, 1, 1);
        public const double scholarship = 998.88;
        public const double balance = 0.0;

        private void FillAllMarks(ref UniversityStudent _student, int _value)
        {
            for (int i = 0; i < UniversityStudent.N_OF_SUBJECTS; i++)
            {
                _student.SetMark(i, _value);
            }
        }

        private void FillAllMarksDifferent(ref UniversityStudent _student)
        {
            for (int i = 0; i < UniversityStudent.N_OF_SUBJECTS; i++)
            {
                _student.SetMark(i, i % 6);
            }
        }

        private void CheckAllMarksDifferentWritten(ref UniversityStudent _student)
        {
            for (int i = 0; i < UniversityStudent.N_OF_SUBJECTS; i++)
            {
                Assert.AreEqual(_student.GetMark(i), i % 6);
            }
        }

        [Test]
        public void InitNormal()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );
        }

        [Test]
        public void InitNegativeScholarship()
        {
            UniversityStudent student;

            Assert.That(() =>
            {
                student = new UniversityStudent(
                    name, surname, patronymic, course, birthday, -100, balance
                );
            }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void SetValidMark()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            const int pos = 0, value = 5;

            student.SetMark(pos, value);

            Assert.AreEqual(student.GetMark(pos), value);
        }

        [Test]
        public void SetAllValidMarks()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarksDifferent(ref student);

            CheckAllMarksDifferentWritten(ref student);
        }

        [Test]
        public void SetNegativeMark()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );


            Assert.That(() =>
            {
                student.SetMark(0, -1);
            }, Throws.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void SetBigMark()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            Assert.That(() =>
            {
                student.SetMark(0, 6);
            }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void SetNegativeMarkIndex()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            Assert.That(() =>
            {
                student.SetMark(-1, 5);
            }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void SetBigMarkIndex()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            Assert.That(() =>
            {
                student.SetMark(UniversityStudent.N_OF_SUBJECTS, 5);
            }, Throws.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void GetNegativeMarkIndex()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            Assert.That(() =>
            {
                student.GetMark(-1);
            }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GetBigMarkIndex()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            Assert.That(() =>
            {
                student.GetMark(UniversityStudent.N_OF_SUBJECTS);
            }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void AddScholarship()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarks(ref student, 4);

            student.AddScholarship();

            Assert.AreEqual(balance + scholarship, student.scholarship);
        }

        [Test]
        public void AddScholarshipWithBadMarks()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarks(ref student, 3);

            Assert.That(() =>
            {
                student.AddScholarship();
            }, Throws.TypeOf<ArgumentException>());
        }


        [Test]
        public void WithdrawAllMoney()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarks(ref student, 4);

            student.AddScholarship();

            double prev_balance = student.balance;

            double got = student.Withdraw(scholarship);

            Assert.AreEqual(got, scholarship);

            Assert.AreEqual(student.balance, prev_balance - scholarship);
        }

        [Test]
        public void WithdrawTooMuchMoney()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarks(ref student, 4);

            student.AddScholarship();

            Assert.That(
                () =>
                {
                    student.Withdraw(scholarship + 1);
                }, Throws.TypeOf<ArgumentOutOfRangeException>());


        }

        [Test]
        public void RaiseCourse()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            student.RaiseCourse();

            Assert.AreEqual(student.course, course + 1);
        }

        [Test]
        public void Deduct()
        {
            UniversityStudent student;

            student = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            student.RaiseCourse();

            FillAllMarks(ref student, 4);

            Assert.AreNotEqual(student.course, 0);

            for (int i = 0; i < UniversityStudent.N_OF_SUBJECTS; i++)
            {
                Assert.AreNotEqual(student.GetMark(i), 0);
            }

            student.Deduct();

            Assert.AreEqual(student.course, 0);

            for (int i = 0; i < UniversityStudent.N_OF_SUBJECTS; i++)
            {
                Assert.AreEqual(student.GetMark(i), 0);
            }

        }

        [Test]
        public void Equality()
        {
            UniversityStudent student1;

            student1 = new UniversityStudent(
                name, surname, patronymic, course, birthday, 0, 0
            );

            FillAllMarks(ref student1, 4);

            UniversityStudent student2;

            student2 = new UniversityStudent(
                name, surname, patronymic, course, new DateTime(10, 10, 10), 10.0, 10.0
            );

            FillAllMarks(ref student2, 4);

            Assert.IsTrue(student1 == student2);

        }

        [Test]
        public void EqualityNotEqualMarks()
        {
            UniversityStudent student1;

            student1 = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarks(ref student1, 4);

            UniversityStudent student2;

            student2 = new UniversityStudent(
                name, surname, patronymic, course, birthday, scholarship, balance
            );

            FillAllMarks(ref student2, 4);

            student2.SetMark(0, 5);

            Assert.IsFalse(student1 == student2);
            Assert.IsTrue(student1 != student2);

        }

    }
}