using System;

namespace RobonetControlApplication
{
	
	using System.Collections;
	using System.Timers;

	public delegate void Tick(int hh, int mm, int ss);

	public class Ticker
	{
		private ArrayList subscribers = new ArrayList();
		private System.Timers.Timer ticking = new System.Timers.Timer();

		public Ticker()
		{
			ticking.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
			ticking.Interval = 1000;
			ticking.Enabled = true;
		}
		public void Attach(Tick newSubscriber,long interval)
		{
			subscribers.Add(newSubscriber);
			ticking.Interval=interval;
		}
		
		public void Detach(Tick exSubscriber)
		{
			subscribers.Remove(exSubscriber);
		}

		private void Notify(int hours, int minutes, int seconds)
		{
			foreach (Tick method in subscribers)
			{

				method(hours, minutes, seconds);
			}
		}
	
		private void OnTimedEvent(object source, ElapsedEventArgs args)
		{
			int hh = args.SignalTime.Hour;
			int mm = args.SignalTime.Minute;
			int ss = args.SignalTime.Second;
			Notify(hh, mm, ss);
		}
	}
}
