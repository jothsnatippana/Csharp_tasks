namespace assignment_medium
{
    class Calculator
	{
		private object _result;
		public object Result
		{
			get{return _result;}
			set{_result = value;}
		}
		public void Add(int a, int b)
		{
			Result=(a+b);
		}
		public void Add(int a, int b,int c)
		{
			Result = (a+b+c);
		}
		public void Add(float a, float b)
		{
			Result = (a+b);
		}
		public virtual object GetResult()
        {
			return Result;
        }
	}
}
