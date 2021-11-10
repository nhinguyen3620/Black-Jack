using System;


namespace Project_1
{
	/// <summary>
	/// The aDie class includes all methods and required constructors to simulate an actual die
	/// Benefits of inheriting aDie from an intermediate class (aRandomVariable)
	///		+ The aDie class can easily use a static random variable which is created in the 
	///		  intermediate class without rewriting the same
	///		+ This kind of inheritance makes code more flexible to change, resulting in a better
	///		  organization of code and simpler compilation unit
	///		+ With this inheritance, we will be able to override methods of the base class
	///		  to design meaningful implementation in the aDie class
	///		+ We can also extend the base class logic as per the logic of the aDie class
	/// </summary>
	public class aDie : aRandomVariable
	{
		// <summary>
		// default constructor
		// </summary>
	
		public aDie()
		{
			//use default seed
			rand = new Random(); 
		}

		/// <summary>
		/// constructor that takes in a seed
		/// </summary>
		/// <param name="seed"></param>
		public aDie(int seed)
		{ 
			//use specified seed  
			rand = new Random(seed);
        }

		// <summary>
		// this method turns a random integer from 1 to 6 inclusive
		// </summary>
		public int roll()
        {
			return rand.Next(1, 7);
        }
	}

}
