using System;

namespace State
{
	public class GumballMachine
	{
		private SoldState soldState;
		private NoQuarterState noQuarterState;
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

		public class SoldState : IState
		{
			public SoldState(GumballMachine gumballMachine)
			{
				GumballMachine = gumballMachine;
			}

			#region Implementation of IState

			public void InsertQuarter()
			{
				throw new System.NotImplementedException();
			}

			public void EjectQuarter()
			{
				throw new System.NotImplementedException();
			}

			public void TurnCrank()
			{
				throw new System.NotImplementedException();
			}

			public void Dispence()
			{
				throw new System.NotImplementedException();
			}

			public GumballMachine GumballMachine { get; private set; }

			#endregion
		}

		public class NoQuarterState : IState
		{
			public NoQuarterState(GumballMachine gumballMachine)
			{
				GumballMachine = gumballMachine;
			}

			#region Implementation of IState

			public void InsertQuarter()
			{
				throw new System.NotImplementedException();
			}

			public void EjectQuarter()
			{
				throw new System.NotImplementedException();
			}

			public void TurnCrank()
			{
				throw new System.NotImplementedException();
			}

			public void Dispence()
			{
				throw new System.NotImplementedException();
			}

			public GumballMachine GumballMachine { get; private set; }

			#endregion
		}
	}
}
