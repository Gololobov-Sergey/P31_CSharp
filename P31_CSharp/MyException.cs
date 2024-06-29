using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_CSharp
{

	public enum CreditCardError
    {
        InvalidCardNumber,
        InvalidCardHolder,
        InvalidCardDate,
        InvalidCardCVC
    }


	[Serializable]
	public class MyException : Exception
	{
	
		public MyException() 
		{ 
			//time = DateTime.Now; 
		}
        public MyException(CreditCardError err, string arg)
        {
            Data.Add("Time", DateTime.Now);
            switch (err)
			{
				case CreditCardError.InvalidCardNumber:
					Data.Add("CardNumber", arg);
					break;
				case CreditCardError.InvalidCardHolder:
					break;
				case CreditCardError.InvalidCardDate:
					break;
				case CreditCardError.InvalidCardCVC:
					break;
				default:
					break;
			}
			//SaveToFile();
		}

		public void SaveToFile()
		{
			// save to file
		}

        public MyException(string message) : base(message) { }
		public MyException(string message, Exception inner) : base(message, inner) { }
		protected MyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
