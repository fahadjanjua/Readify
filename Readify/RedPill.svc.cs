using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Readify.RedPillService;

namespace Readify
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        private const int MaxFibIndex = 92;
        public const int MinFibIndex = -92;
        private readonly List<long> _fibSequence = new List<long>();
        public RedPill()
        {
            //Generating Fibonacci Sequence
            _fibSequence.Add(0);
            _fibSequence.Add(1);
            int index = 1;
            while (index < MaxFibIndex)
            {
                var fibNumber = _fibSequence[index] + _fibSequence[index - 1];
                _fibSequence.Add(fibNumber);
                index++;
            }
        }
        public Guid WhatIsYourToken()
        {
            return new Guid("d6323654-dff1-4e81-9dac-81b6934ec66e");
        }

        public IAsyncResult BeginWhatIsYourToken(AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public Guid EndWhatIsYourToken(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public long FibonacciNumber(long n)
        {
            if(n > MaxFibIndex || n < MinFibIndex)
                throw new ArgumentOutOfRangeException(nameof(n), "Index values greater than 92 or lesser than -92 will result in overflow for long data type.");
            var absIndex = (int)Math.Abs(n);
            return n < 0 && absIndex % 2 == 0 ? -_fibSequence[absIndex] : _fibSequence[absIndex];
        }

        public IAsyncResult BeginFibonacciNumber(long n, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public long EndFibonacciNumber(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.Error;

            if (((b + c) < a) || ((a + c) < b) || ((a + b) < c)) //Checking for inequality theorem
                return TriangleType.Error;

            /*int[] values = new int[3] { a, b, c };

            if(values.Distinct().Count() == 1)*/


            if (a == b && b == c) //Equilateral Traingle: All 3 equal sides
                return TriangleType.Equilateral;

            if (a == b || a == c || b == c) //Isoceles Traingle: 2 equal sides
                return TriangleType.Isosceles;

            return TriangleType.Scalene; //Scalene Traingle: No equal side
        }

        public IAsyncResult BeginWhatShapeIsThis(int a, int b, int c, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public TriangleType EndWhatShapeIsThis(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentNullException(nameof(s), "input string was either null or empty.");

            var sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        public IAsyncResult BeginReverseWords(string s, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public string EndReverseWords(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }
}
