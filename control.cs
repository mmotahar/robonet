using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Threading;

namespace RobonetControlApplication
{

	public class control : System.Windows.Forms.Form
	{

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.groupBox1.Enabled = false;
			this.button1.Visible = false;
			this.label9.Visible = false;
			this.label10.Visible = false;
			this.pictureBox1.Visible = false;
			this.label6.Text = "  Capturing ...";
			this.label7.Text = "  ON";
			this.label8.Text = "To Disconnecting Press ";
			this.label12.Text = " \"Ctrl+X\" ";
			ok = 1;
			this.Focus();
		}

		private void keygenerate()
		{
			nextkey = random.Next(99999);
		}

		private void control_Deactivate(object sender, System.EventArgs e)
		{
			sPort = "s";
			keyStatus = 0;
			this.pictureBox2.Visible = true;
			this.pictureBox3.Visible = false;
			this.pictureBox4.Visible = false;
			this.pictureBox5.Visible = false;
			this.pictureBox6.Visible = false;
			this.pictureBox7.Visible = false;
			this.pictureBox8.Visible = false;
			this.pictureBox9.Visible = false;
			this.pictureBox10.Visible = false;
		}

		private void control_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (ok == 1)
			{
				switch (e.KeyValue)
				{
					case 38:
					switch (keyStatus)
					{
						case 0:
							sPort = "f";
							keyStatus = 1;
							this.pictureBox3.Visible = true;
							break;
						case 4:
							sPort = "fr";
							keyStatus = 5;
							this.pictureBox5.Visible = true;
							this.pictureBox6.Visible = false;
							break;
						case 8:
							sPort = "fl";  
							keyStatus = 9;
							this.pictureBox2.Visible = false;
							this.pictureBox7.Visible = false;
							this.pictureBox4.Visible = true;
							break;
					} 
						break;
					case 40:
					switch (keyStatus)
					{
						case 0:
							sPort = "b";
							keyStatus = 2;
							this.pictureBox2.Visible = false;
							this.pictureBox6.Visible = false;
							this.pictureBox8.Visible = true;
							break;
						case 4:
							sPort = "br"; 
							keyStatus = 6;
							this.pictureBox6.Visible = false;
							this.pictureBox9.Visible = true;
							break;
						case 8:
							sPort = "bl";
							keyStatus = 10;
							this.pictureBox10.Visible = true;
							this.pictureBox2.Visible = false;
							this.pictureBox7.Visible = false;
							this.pictureBox8.Visible = false;
							break;
					}
						break;

					case 39:
					switch (keyStatus)
					{
						case 0:
							sPort = "r";
							keyStatus = 4;
							this.pictureBox2.Visible = false;
							this.pictureBox6.Visible = true;
							break;
						case 1:
							sPort = "fr";
							keyStatus = 5;
							this.pictureBox5.Visible = true;
							this.pictureBox3.Visible = false;
							break;
						case 2:
							sPort = "br"; 
							keyStatus = 6;
							this.pictureBox2.Visible = false;
							this.pictureBox8.Visible = false;
							this.pictureBox9.Visible = true;
							break;
					}
						break;

					case 37:
					switch (keyStatus)
					{
						case 0:
							sPort = "l";
							keyStatus = 8;
							this.pictureBox7.Visible = true;
							this.pictureBox2.Visible = false;
							break;
						case 1:
							sPort = "fl"; 
							keyStatus = 9;
							this.pictureBox4.Visible = true;
							this.pictureBox3.Visible = false;
							break;
						case 2:
							sPort = "bl";
							keyStatus = 10;
							this.pictureBox10.Visible = true;
							this.pictureBox2.Visible = false;
							this.pictureBox7.Visible = false;
							this.pictureBox8.Visible = false;
							break;
					}
						break;

					default:
						sPort = "s";
						break;
				}
				keygenerate();
				websrv.Command(currentkey,nextkey,sPort);
				currentkey = nextkey;
			}
		}

		private void control_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (ok == 1)
			{
				switch (e.KeyValue)
				{
					case 38:
					switch (keyStatus)
					{
						case 1:
							sPort = "s";
							keyStatus = 0;
							this.pictureBox2.Visible = true;
							this.pictureBox3.Visible = false;
							break;
						case 5:
							sPort = "r";
							keyStatus = 4;
							this.pictureBox6.Visible = true;
							this.pictureBox5.Visible = false;
							this.pictureBox2.Visible = false;
							break;
						case 9:
							sPort = "l";
							keyStatus = 8;
							this.pictureBox4.Visible = false;
							this.pictureBox7.Visible = true;
							break;
					}
						break;

					case 40:
					switch (keyStatus)
					{
						case 2:
							sPort = "s";
							keyStatus = 0;
							this.pictureBox8.Visible = false;
							this.pictureBox9.Visible = false;
							this.pictureBox2.Visible = true;
							break;
						case 6:
							sPort = "r";
							keyStatus = 4;
							this.pictureBox8.Visible = false;
							this.pictureBox9.Visible = false;
							this.pictureBox6.Visible = true;
							break;
						case 10:
							sPort = "l";
							keyStatus = 8;
							this.pictureBox8.Visible = false;
							this.pictureBox10.Visible = false;
							this.pictureBox7.Visible = true;
							break;
					}
						break;

					case 39:
					switch (keyStatus)
					{
						case 4:
							sPort = "s";
							keyStatus = 0;
							this.pictureBox5.Visible = false;
							this.pictureBox6.Visible = false;
							this.pictureBox2.Visible = true;
							break;
						case 5:
							sPort = "f";
							keyStatus = 1;
							this.pictureBox5.Visible = false;
							this.pictureBox3.Visible = true;
							break;
						case 6:
							sPort = "b";
							keyStatus = 2;
							this.pictureBox9.Visible = false;
							this.pictureBox8.Visible = true;
							break;
					}
						break;

					case 37:
					switch (keyStatus)
					{
						case 8:
							sPort = "s";
							keyStatus = 0;
							this.pictureBox4.Visible = false;
							this.pictureBox7.Visible = false;
							this.pictureBox2.Visible = true;
							break;
						case 9:
							sPort = "f";
							keyStatus = 1;
							this.pictureBox4.Visible = false;
							this.pictureBox7.Visible = false;
							this.pictureBox3.Visible = true;
							break;
						case 10:
							sPort = "b";
							keyStatus = 2;
							this.pictureBox8.Visible = true;
							this.pictureBox7.Visible = false;
							this.pictureBox10.Visible = false;
							break;
					}
						break;
				}
				keygenerate();
				websrv.Command(currentkey,nextkey,sPort);
				currentkey = nextkey;
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			bool cancel = false;
			DialogResult disconnect = MessageBox.Show("Are you sure you want to quit?",
				"Exit",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning);
			cancel = (disconnect == DialogResult.OK);
			if (cancel)
			{
				formclosed = true;
				int result = 0;
				do
				{
					keygenerate();
					websrv.Command(currentkey,nextkey,"s");
					currentkey = nextkey;
					result = websrv.Disconnect(currentkey);
				}
				while(result == 1);
				Application.Exit();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			bool cancel = false;
			DialogResult disconnect = MessageBox.Show("Are you sure you want change user?",
				"Change user",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question);
			cancel = (disconnect == DialogResult.OK);
			if (cancel)
			{
				formclosed = true;
				int result = 0;
				do
				{
					keygenerate();
					websrv.Command(currentkey,nextkey,"s");
					currentkey = nextkey;
					result = websrv.Disconnect(currentkey);
				}
				while(result == 1);
				this.Visible = false;
				this.autenticationform = new authentication();
				this.autenticationform.ShowDialog();
				this.Close();
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Report");
		}

		private void control_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!formclosed)
			{
				DialogResult disconnect = MessageBox.Show("Are you sure you want quit?",
					"Exit",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning);
				e.Cancel = (disconnect == DialogResult.Cancel);
				if (!e.Cancel)
				{
					keygenerate();
					websrv.Command(currentkey,nextkey,"s");
					currentkey = nextkey;
					websrv.Disconnect(currentkey);
					Application.Exit();
				}
			}
		}

		private void control_Load(object sender, System.EventArgs e)
		{
			if (ok == 1)
			{
				this.groupBox1.Enabled = false;
				this.button1.Visible = false;
				this.label9.Visible = false;
				this.label10.Visible = false;
				this.pictureBox1.Visible = false;
				this.label6.Text = "  Capturing ...";
				this.label7.Text = "  ON";
				this.label8.Text = "To Disconnecting Press ";
				this.label12.Text = " \"Ctrl+X\" ";
				this.Focus();
			}
			// READ FORM XML FILE
			try
			{
				emptyfile = false;
				StreamReader stream = new StreamReader("c:/robonet/XML/jobsinfo.xml");
				XmlTextReader reader = new XmlTextReader(stream);
				XmlSchemaCollection schemacoll = new XmlSchemaCollection();
				schemacoll.Add(null,"c:/robonet/XSD/jobsinfo.xsd");
				XmlValidatingReader valreader = new XmlValidatingReader(reader);
				valreader.ValidationType = ValidationType.Schema;
				valreader.Schemas.Add(schemacoll);
				valreader.ValidationEventHandler += new ValidationEventHandler(valHandler);
				while (valreader.Read())
				{
					if (valreader.LocalName.Equals("jobname"))
					{
						jobnamefild[jobnamecounter] = valreader.ReadString();
						jobnamecounter++;
					}
					else if (valreader.LocalName.Equals("jobpath"))
					{
						jobpathfild[jobpathcounter] = valreader.ReadString();
						jobpathcounter++;
					}
				}
				valreader.Close();
				reader.Close();
				stream.Close();
				// READING COMPLETE
			}
			catch (Exception caught)
			{
				emptyfile = true;
			}
			// FILL MENUITEMS
			int count;
			for (count=0;jobnamefild[count] != null;count++)  ;
			jobs = new string[count];
			paths = new string[count];
			for (count=0;jobnamefild[count] != null;count++)
			{
				jobs[count] = jobnamefild[count];
				paths[count] = jobpathfild[count];
			}
			MJmenu myjobsname =new MJmenu(); 
			this.menuItem13.MenuItems.Add(myjobsname);
			myjobsname.Initialize(jobs);
			myjobsname.MenuClicked+=new EventHandler(MenuClick);
			this.label13.Text = "Current user : ( " + this.currentusername + " )";
		}

		private void MenuClick(object sender, System.EventArgs e) 
		{
			int result = 0;
			MenuItem mysender = sender as MenuItem;
			for (int i=0; i<jobs.Length; i++)
				if (jobs[i] == mysender.Text)
					currentjobpath = paths[i];
			result = openjob();
			if (result != 1)
				MessageBox.Show("Source of job not found !!!");
		}

		private int openjob()
		{
			if (ok == 1)
			{
				int validcommand = 1;
				try
				{
					FileInfo src = new FileInfo(currentjobpath);
					TextReader reader = src.OpenText();
					string line;
					while (((line = reader.ReadLine()) != null) && validcommand == 1)
					{
						runer = true;
						validcommand = compile(line);
						if (validcommand != 1)
						{
							keygenerate();
							websrv.Command(currentkey,nextkey,"s");
							currentkey = nextkey;
							break;
						}
					}
					reader.Close();
					if (validcommand != 1)
						MessageBox.Show("Invalid command !!!          \nJob stoped.");
				}
				catch(Exception e)
				{
					return 0;
				}
			}
			else
			{
				MessageBox.Show("Divice Turn off.              ");
			}
			return 1;
		}
		public int compile(string str)
		{
			str = str.Trim();
			if (str.CompareTo("") != 0)
			{
				int strlenght;
				char strendcharacter;
				int i,iserror;
				long isint;
				int oktemp = 0;
				string next,st,checkerror,time;
				//*********************
				strlenght = str.Length;
				strendcharacter = Convert.ToChar(str[strlenght-1]);
				switch (strendcharacter)
				{
					case ';' :
					{
						try
						{
							int validcommand = 0;
							st = str;
							i = st.IndexOf(";");
							next =st.Substring(i+1);
							st = st.Substring(0,i);
							i = st.LastIndexOf(")");
							checkerror =st.Substring(i+1);
							st = st.Substring(0,i);
							i = st.LastIndexOf("(");
							time =st.Substring(i+1);
							time = time.Trim();
							isint = Convert.ToInt64(time);
							st = st.Substring(0,i);
							st = st.Trim();
							st = st.ToLower();
							//****************
							checkerror = checkerror.Trim();
							iserror = checkerror.CompareTo("");
							//****************
							if (iserror == 0)
							{
								validcommand = compare(st);
								if (validcommand == 1)
								{
									if (activefor)
									{
										stfor[forcounter] = st;
										timefor[forcounter] = isint;
										forcounter++;
									}
									if (runer && !activefor)
										run(st,isint);
									if (next.CompareTo("") != 0)
									{
										oktemp = compile(next);	
										return oktemp;
									}
									else
										return 1;
						
								}
								else
									return 2;
								//****************
							}
							return 5;
							break;
						}
						catch (Exception cuaght)
						{
							return 4;
						}
					}
					case ')' :
					{
						try
						{
							int validcommand = 0;
							st = str;
							i = st.IndexOf(")");
							next =st.Substring(i+1);
							st = st.Substring(0,i);
							i = st.LastIndexOf("(");
							time =st.Substring(i+1);
							st = st.Substring(0,i);
							time = time.Trim();
							isint = Convert.ToInt64(time);
							st = st.Substring(0,i);
							st = st.Trim();
							st = st.ToLower();
							//****************
							switch (st)
							{
								case "for" :
								{
									validcommand = 1;
									openexception = true;
									closed = false;
									fornum++;
									forrepeat = isint;
									break;
								}
								case "function" :
								{
									validcommand = 2;
									openexception2 = true;
									closed2 = false;
									break;
								}
								default :
								{
									return 0;
									break;
								}
							}
							if (validcommand == 1)
							{
								if (foronce)
								{
									for (int x=0; x != stfor.Length; x++)
									{
										for (int j=0; j != stfor.Length; j++)
										{
											//stfor[x][j] = null;
											//timefor[x][j] = 0;
										}
									}
									foronce = false;
								}
								forrepeat = isint;
								activefor = true;
								return 1;
							}
							else
							{
								if (validcommand == 2)
								{
									if (foronce)
									{
										for (int j=0; j != stfunction.Length; j++)
										{
											stfunction[j] = null;
											timefunction[j] = 0;
										}
										foronce = false;
									}
									activefunction2 = true;
									return 1;
								}
								return(doingfunction(time));
							}
							//*****************************
							break;
						}
						catch(Exception caught)
						{
							return 4;
						}
					}
					case '{' :
					{
						break;
					}
					case '}' :
					{
						if (activefor)
						{
							closed = true;
							if (runer)
							{
								for (int count = 0; count < forrepeat; count++)
								{
									for (int k=0; stfor[k]!= null; k++)
									{
										run(stfor[k],timefor[k]);
									}
								}
							}
							for (int k=0; k<stfor.Length; k++)
							{
								stfor[k] = null;
								timefor[k] = 0;
							}
							fornum--;
							activefor = false;
							forcounter = 0;
							forrepeat = 0;
							foronce = true;
							return 1;
							break;
						}
						else
							return 0;
					}
					default  :
					{
						return 0;
						break;
					}
				}
				return 1;
			}
			else
				return 1;
		}
		public void run(string st,long time)
		{
			if (closed)
			{
				switch (st)
				{
					case "front":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"f");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "back":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"b");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "right":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"r");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "left":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"l");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "frontright":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"fr");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "frontleft":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"fl");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "backright":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"br");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "backleft":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"bl");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "stop":
					{
						keygenerate();
						websrv.Command(currentkey,nextkey,"s");
						currentkey = nextkey;
						sleep(time);
						break;
					}
					case "turnon":
					{
						this.objsrv.command("on");
						sleep(time);
						break;
					}
					case "turnoff":
					{
						this.objsrv.command("off");
						sleep(time);
						break;
					}
				}
			}
		}

		private int compare(string st)
		{
			bool validcommand = false;
			switch (st)
			{
				case "front":
				{
					validcommand = true;
					break;
				}
				case "back":
				{
					validcommand = true;
					break;
				}
				case "right":
				{
					validcommand = true;
					break;
				}
				case "left":
				{
					validcommand = true;
					break;
				}
				case "frontright":
				{
					validcommand = true;
					break;
				}
				case "frontleft":
				{
					validcommand = true;
					break;
				}
				case "backright":
				{
					validcommand = true;
					break;
				}
				case "backleft":
				{
					validcommand = true;
					break;
				}
				case "stop":
				{
					validcommand = true;
					break;
				}
				case "turnon":
				{
					validcommand = true;
					break;
				}
				case "turnoff":
				{
					validcommand = true;
					break;
				}
				case "}":
				{
					validcommand = true;
					break;
				}
			}
			if (validcommand)
				return 1;
			else
				return 0;
		}

		public void sleep(long time)
		{
			waittime =Convert.ToInt32(time);
			wait();
		}
		public void wait()
		{
			Thread.Sleep(waittime);
		}

		private int doingfunction(string functionname)
		{
			return 1;
		}

		private void valHandler(Object sender, ValidationEventArgs e)
		{
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}


		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			int result = 0;
			do
			{
				keygenerate();
				result = websrv.Command(currentkey,nextkey,"on");
				currentkey = nextkey;
			}
			while(result == 1);
			this.pictureBox1.Visible = false;
			this.groupBox2.Enabled = true;
			this.groupBox1.Enabled = false;
			this.button1.Visible = false;
			this.label9.Visible = false;
			this.label10.Visible = false;
			this.label6.Text = "  Capturing ...";
			this.label7.Text = "  Connected";
			this.label8.Text = "To Disconnecting Press ";
			this.label12.Text = " \"Ctrl+X\" ";
			ok = 1;
			this.Focus();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			bool YES = false;
			DialogResult disconnect = MessageBox.Show("Do you want to disconnect ?",
				"Confirm",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			YES = (disconnect == DialogResult.Yes);
			if (YES)
			{
				formclosed = true;
				int result = 0;
				do
				{
					keygenerate();
					websrv.Command(currentkey,nextkey,"s");
					currentkey = nextkey;
					result = websrv.Disconnect(currentkey);
				}
				while(result == 1);
				this.Visible = false;
				this.editorform = new editor();
				editorform.disconnect = true;
				this.editorform.ShowDialog();
				this.Close();
			}
			else
			{
				formclosed = true;
				this.Visible = false;
				this.editorform = new editor();
				editorform.currentusername = this.currentusername;
				editorform.currentpassword = this.currentpassword;
				editorform.currentkey = this.currentkey;
				editorform.on = this.ok;
				editorform.websrv = this.websrv;
				this.editorform.ShowDialog();
				this.Close();
			}
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			this.pictureBox1.Visible = true;
			this.groupBox1.Enabled = true;
			this.label9.Visible = true;
			this.label10.Visible = true;
			this.button1.Visible = true;
			this.label6.Text = "  Disconneced";
			this.label7.Text = "  OFF";
			this.label8.Text = "To Capturing Press \"ENTER\"";
			this.label12.Text = "or Click on \"Capture\" Button.";
			ok = 0;
			this.button1.Focus();
			int result = 0;
			do
			{
				keygenerate();
				result = websrv.Command(currentkey,nextkey,"off");
				currentkey = nextkey;
			}
			while(result == 1);
		}

	}
}
