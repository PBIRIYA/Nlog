using System;
namespace NlogDemo
{
    public class AddNumbers
    {
        private readonly Nlog nlog = new Nlog();
        public int Sum(int firstNumber, int secondNumber)
        {
            ///Checking values equal to 0 
            if (firstNumber == 0 || secondNumber == 0)
                {
                nlog.LogDebug("Debug Uncessfull : Sum()");
                nlog.LogError("Input Numbers cannot be zero");
                nlog.LogWarn("firstNumber or secondNumber should not equal to 0");
            }
            int result = firstNumber + secondNumber;
            nlog.LogDebug("Debug Uncessfull : Sum()");
            nlog.LogInfo("Sum Method passed, Result :" + result);
            return result;
        }
    }
}
