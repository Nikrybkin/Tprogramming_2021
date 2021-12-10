namespace CourseApp
{
    using System;

    public class Mouse
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value  1  value  10)
                {
                    Console.WriteLine(Неправильно введён возраст);
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}