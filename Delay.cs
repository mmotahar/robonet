using System;

namespace RobonetControlApplication
{
	 
	using System.Windows.Forms;

	public class Delay
	{
		private Ticker  pulsed = new Ticker();
		private TextBox time;
		//private dpi.robonet.www.Service1 websrv = new whileStatement.dpi.robonet.www.Service1();
		private long interval = 1000;

		public Delay(TextBox target)
		{
			time = target;
			Start(interval);
		}

		public void Start(long interval)
		{
			pulsed.Attach(new Tick(this.RefreshTime),interval);
		}

		public void Stop()
		{
			pulsed.Detach(new Tick(this.RefreshTime));
		}

		public void RefreshTime(int hh, int mm, int ss)
		{
			time.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss);
		}
	}
}
