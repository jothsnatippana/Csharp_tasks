using System;

namespace assignment_medium
{
    class Advanced_Caculator:Calculator
    {
		public void power(int bas,int exp)
        {
			Result = Math.Pow(bas, exp);
        }
        public override object GetResult()
        {
            double res = (double)Result;
            res = res * Math.Pow(10, 6);
            Result = res;
            return Result;
        }
    }
}
