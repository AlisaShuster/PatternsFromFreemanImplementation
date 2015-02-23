using System;

namespace State
{
	public class GumballMachine
	{
		public SoldState soldState;
		public NoQuarterState noQuarterState;
		public HasQuarterState hasQuarterState;
		private int count;
		private IState State { get; set; }

		public GumballMachine(int numberGumballs)
		{
			soldOutState = new SoldOutState(this);
			noQuarterState = new NoQuarterState(this);

			hasQuarterState = new HasQuarterState(this);
			soldState = new SoldState(this);

			this.count = numberGumballs;

			if (numberGumballs > 0)
				State = noQuarterState;
		}

		public void InsertQuarter()
		{
			State.InsertQuarter();
		}

		public void EjectQuarter()
		{
			State.EjectQuarter();
		}

		public void TurnCrank()
		{
			State.TurnCrank();
			State.Dispence();
		}

		public void Dispence()
		{
			State.Dispence();
		}

		private void ReleaseBall()
		{
			Console.WriteLine("A gumball comes rolling out the slot...");
			if (count != 0)
				count--;
		}

		
	}
}
