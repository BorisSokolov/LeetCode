using System;

namespace Student_Attendance_Record_I
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.CheckRecord("PPALLP"));
        }
    }

    public class Solution
    {
        public bool CheckRecord(string s)
        {
            int absent = 0;
            int late = 0;

            foreach (char c in s)
            {
                if (c == 'L')
                {
                    if (late < 3)
                    {
                        late++;
                        continue;
                    }
                    else
                        return false;
                }
                if (c == 'A')
                {
                    if (absent == 0)
                        absent++;
                    else
                        return false;
                }
                late = 0;
            }

            return true;
        }
    }
}
