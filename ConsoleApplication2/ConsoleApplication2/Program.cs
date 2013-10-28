using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<DoSomething> liste = new List<DoSomething>();
			liste.Add(new DoSomething(134));
			liste.Add(new DoSomething(579, () => { return "dos werd isse: 579"; }));

			foreach(DoSomething dos in liste)
			{
				dos.ReturnValue();
			}
		}
	}

	public class DoSomething
	{
		private int _value;

		private Func<string> _returnValue;

		public DoSomething(int value, Func<string> newFunc = null)
		{
			_value = value;

			if (newFunc == null)
				_returnValue = () => { return "The value is: " + _value; };
			else
				_returnValue = newFunc;
		}

		public string ReturnValue()
		{
			return _returnValue();
		}
	}
}
