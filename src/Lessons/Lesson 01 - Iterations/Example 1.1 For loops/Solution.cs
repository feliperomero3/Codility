// Example: We are given some positive integer n. 
// Let’s compute the factorial of n and assign it to the variable factorial. 
// The factorial of n is n! = 1·2·. . .·n. We can obtain it by 
// starting with 1 and multiplying it by all the integers from 1 to n. 
// 1    factorial = 1
// 2    for i in range (1, n + 1):
// 3        factorial *= i

namespace Lessons.Iterations
{
    public class Solution
    {
        public int Run(int n)
        {
            int factorial = 1;

            for (int i = 1; i < n + 1; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
