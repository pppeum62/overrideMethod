using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideMethod
{
    class Program
    {
        // 매개변수 input을 제곱해서 반환하는 메서드
        int Power(int input)
        {
            return input * input;
        }

        // 매개변수 input을 count만큼 제곱해서 반환하는 메서드
        int Power(int input, int count)
        {
            int result = input;

            for(int i = 0; i < count; i++)
            {
                result = result * input;
            }

            return result;
        }

        // 0부터 end 사이의 모든 정수를 더하는 메서드
        int SumAll(int end)
        {
            int sum = 0;

            for(int i = 1; i <= end; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        // start부터 end 사이의 모든 정수를 더하는 메서드
        int SumAll(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
        }
    }
}
