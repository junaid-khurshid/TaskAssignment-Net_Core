using System;

namespace TaskAssignmentApplication.Common.Helpers
{
    public static class RandomNumberGenerator
    {
        static Random rd = new Random();
        public static string CreateRandomNumber(int stringLength)
        {
            const string allowedChars = "0123456789";
            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
