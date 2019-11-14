using System;
using System.Windows.Forms;

namespace RobonetControlApplication
{
	public class MJmenu : MenuItem	
	{
		string[] jobnames;
		int counter;
		public string[] calljobs 
		{
			get {return jobnames;}
		}

		public void Initialize(string[] jobs) 
		{
			jobnames=jobs;
			counter=jobnames.Length;
			for (int i=0;i<counter;i++) 
			{
				if (""!=jobnames[i]) 
				{
					MenuItem submenu = new MenuItem(jobnames[i], new EventHandler(OnMenuClick));
					this.MenuItems.Add(submenu);
				}
			}
		}
		public event EventHandler MenuClicked; 
		protected virtual void OnMenuClick(object o, EventArgs e) 
		{
			if (MenuClicked != null) 
			{
				MenuClicked(o, e); 
			}
		}
	}
}
