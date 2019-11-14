using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.IO;

namespace RobonetControlApplication
{
	public class editor : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button openFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button1;
		protected internal System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.RichTextBox source;
		private System.Windows.Forms.RichTextBox error;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label filename;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.TextBox digital;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private Delay delay;
		//
		// key generate
		//
		private System.Random random;
		//
		// variable
		//
		bool closing = false;
		bool exitbutton = false;
		bool backbutton = false;
		string[] jobnamefild = new string[50];
		string[] jobpathfild = new string[50];
		int jobnamecounter = 0;
		int jobpathcounter = 0;
		bool emptyfile = false;
		bool beforcompile = false;
		//
		//add to joblist variable
		//
		bool compiled = false;
		//
		// authentication form
		//
		private RobonetControlApplication.authentication authenticationform;
		//
		// control form
		//
		private RobonetControlApplication.control controlform;
		//
		// variables for security
		//
		public string currentusername = null,currentpassword = null;
		public int currentkey,nextkey,on=0;
		public bool disconnect = false;
		//
		// websrv
		//
		public RobonetControlApplication.localhost.roboservice websrv;

		public editor()
		{

			InitializeComponent();
			delay = new Delay(digital);
			random = new Random();
			Thread thread = new Thread(new System.Threading.ThreadStart(wait));

		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(editor));
			this.openFile = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.source = new System.Windows.Forms.RichTextBox();
			this.error = new System.Windows.Forms.RichTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.filename = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.digital = new System.Windows.Forms.TextBox();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFile
			// 
			this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.openFile.Location = new System.Drawing.Point(14, 19);
			this.openFile.Name = "openFile";
			this.openFile.TabIndex = 1;
			this.openFile.Text = "&Open File";
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// label
			// 
			this.label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label.Location = new System.Drawing.Point(108, 25);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(66, 23);
			this.label.TabIndex = 2;
			this.label.Text = "Current File:";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(7, 379);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "&Save";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(89, 379);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "&Compile";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(96, 354);
			this.button3.Name = "button3";
			this.button3.TabIndex = 10;
			this.button3.Text = "&Run";
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// source
			// 
			this.source.BackColor = System.Drawing.SystemColors.Window;
			this.source.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.source.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.source.Location = new System.Drawing.Point(24, 49);
			this.source.Name = "source";
			this.source.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.source.Size = new System.Drawing.Size(410, 241);
			this.source.TabIndex = 0;
			this.source.Text = "";
			this.source.TextChanged += new System.EventHandler(this.source_TextChanged_1);
			// 
			// error
			// 
			this.error.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.error.Location = new System.Drawing.Point(24, 291);
			this.error.Name = "error";
			this.error.ReadOnly = true;
			this.error.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.error.Size = new System.Drawing.Size(410, 53);
			this.error.TabIndex = 17;
			this.error.TabStop = false;
			this.error.Text = "";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Location = new System.Drawing.Point(14, 49);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(10, 241);
			this.panel2.TabIndex = 20;
			// 
			// filename
			// 
			this.filename.BackColor = System.Drawing.SystemColors.Window;
			this.filename.Location = new System.Drawing.Point(177, 24);
			this.filename.Name = "filename";
			this.filename.Size = new System.Drawing.Size(183, 18);
			this.filename.TabIndex = 21;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Location = new System.Drawing.Point(14, 291);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 53);
			this.panel3.TabIndex = 21;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem5,
																					  this.menuItem8});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItem2.Text = "&Open";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItem3.Text = "&Save";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menuItem4.Text = "E&xit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem5.Text = "&Debug";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlF5;
			this.menuItem6.Text = "&Compile";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.menuItem7.Text = "&Run";
			this.menuItem7.Visible = false;
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem9});
			this.menuItem8.Text = "&Tools";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.menuItem9.Text = "&Remove job";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// digital
			// 
			this.digital.BackColor = System.Drawing.SystemColors.Window;
			this.digital.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.digital.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.digital.ForeColor = System.Drawing.Color.DimGray;
			this.digital.Location = new System.Drawing.Point(363, 24);
			this.digital.Multiline = true;
			this.digital.Name = "digital";
			this.digital.Size = new System.Drawing.Size(70, 18);
			this.digital.TabIndex = 22;
			this.digital.TabStop = false;
			this.digital.Text = "";
			this.digital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(132, 174);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Location = new System.Drawing.Point(171, 379);
			this.button5.Name = "button5";
			this.button5.TabIndex = 5;
			this.button5.Text = "&Add to list";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(87, 357);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(347, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "";
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Location = new System.Drawing.Point(359, 420);
			this.button6.Name = "button6";
			this.button6.TabIndex = 6;
			this.button6.Text = "E&xit";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(14, 357);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 23;
			this.label1.Text = "Job name :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Location = new System.Drawing.Point(7, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(436, 447);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Location = new System.Drawing.Point(270, 415);
			this.button4.Name = "button4";
			this.button4.TabIndex = 25;
			this.button4.Text = "&Back";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// editor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(449, 459);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.digital);
			this.Controls.Add(this.filename);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.error);
			this.Controls.Add(this.source);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label);
			this.Controls.Add(this.openFile);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Interpreter Editor";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.editor_Closing);
			this.Load += new System.EventHandler(this.editor_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//******************
		bool textchange = false;
		bool save = true;
		bool open = false;
		bool isopen = false;
		bool comp = false;
		bool runer = false;
		string filepath;
		string openpath;
		int ok = 0;
		int waittime = 0;
		//
		bool err = false;
		//for
		bool activefor = false;
		bool openexception = false;
		bool closeexception = false;
		bool closed = true;
		//function
		bool activefunction2 = false;
		bool openexception2 = false;
		bool closeexception2 = false;
		bool closed2 = true;
		//for
		string[] stfor = new string[10];
		long[] timefor = new long[10];
		long forrepeat = 0;
		int forcounter = 0;
		int fornum = 0;
		string checkerror,st,time,er;
		//function
		string[] stfunction = new string[10];
		long[] timefunction = new long[10];
		int functioncounter = 0;
		//for function
		bool foronce = true;
		//******************
		public void sleep(long time)
		{
			waittime =Convert.ToInt32(time);
			wait();
		}
		public void wait()
		{
			Thread.Sleep(waittime);
		}
		//****************
		public void command()
		{
			string path;
			int errorhandellingresult = 1;
			bool compilesuccesfully = true;
			int counter=0;
			int tempcounter = 0;
			if (open)
				path = openFileDialog.FileName;
			else
				path = openpath;
			FileInfo src = new FileInfo(path);
			TextReader reader = src.OpenText();
			source.Text = "";
			error.Text = "";
			string line;
			bool once = true;
			while((line = reader.ReadLine())!= null)
			{
				counter++;
				source.Text +=line + "\n";
				if (openexception)
				{
					if (once)
					{
						tempcounter = counter-1;
						once = false;
					}
					line = line.Trim();
					ok = line.CompareTo("{");
					if (ok == 0)
					{
						openexception = false;
						once = true;
						closeexception = true;
						ok = 1;
					}
					else
					{
						ok = line.CompareTo("");
						if (ok != 0)
						{
							openexception = false;
							once = true;
							ok = 3;
						}
						else
							ok = 1;
					}
				}
				else
					ok = compile(line);
				errorhandellingresult = errorhandelling(ok,line,counter,tempcounter);
				if (errorhandellingresult != 1)
					compilesuccesfully = false;
				if (errorhandellingresult == 0)
					break;
			}
			reader.Close();
			if (compilesuccesfully  && !err && closed)
			{
				this.error.ForeColor = System.Drawing.Color.Blue;
				error.Text += "Compiled successfuly \n";
				compiled = true;
			}
			if (!closed)
			{
				this.error.ForeColor = System.Drawing.Color.Brown;
				error.Text += "\" } \" Expected !!!";
			}

			err = false;
			compilesuccesfully = true;
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
				string next;
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
											stfor[x][j] = null;
											timefor[x][j] = 0;
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
						this.objsrv.command("f");
						sleep(time);
						break;
					}
					case "back":
					{
						this.objsrv.command("b");
						sleep(time);
						break;
					}
					case "right":
					{
						this.objsrv.command("r");
						sleep(time);
						break;
					}
					case "left":
					{
						this.objsrv.command("l");
						sleep(time);
						break;
					}
					case "frontright":
					{
						this.objsrv.command("fr");
						sleep(time);
						break;
					}
					case "frontleft":
					{
						this.objsrv.command("fl");
						sleep(time);
						break;
					}
					case "backright":
					{
						this.objsrv.command("br");
						sleep(time);
						break;
					}
					case "backleft":
					{
						this.objsrv.command("bl");
						sleep(time);
						break;
					}
					case "stop":
					{
						this.objsrv.command("s");
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
		private int errorhandelling(int ok,string line,int counter,int tempcounter)
		{
			if (ok == 0)
			{
				this.error.ForeColor = System.Drawing.Color.Brown;
				error.Text += "Syntax error on line (" + counter.ToString();
				error.Text += ")" + "\n";
				err = true;
				//********* important to sent zero to port
				if (runer)
				{
					this.objsrv.command("s");
					return 0;
				}
			}
			if (ok == 2)
			{
				this.error.ForeColor = System.Drawing.Color.Brown;
				error.Text += "\" " + st + " \"" + "  Badcommand on line (" + counter.ToString();
				error.Text += ")" + "\n";
				err = true;
				//********* important to sent zero to port
				if (runer)
				{
					this.objsrv.command("s");
					return 0;
				}
			}
			if (ok == 3)
			{
				this.error.ForeColor = System.Drawing.Color.Brown;
				error.Text += "\" { \" Expected on line (" + tempcounter.ToString();
				error.Text += ")" + "\n";
				err = true;
				//********* important to sent zero to port
				if (runer)
				{
					this.objsrv.command("s");
					return 0;
				}
				ok = compile(line);
				errorhandelling(ok,line,counter,tempcounter);
			}
			if (ok == 4)
			{
				this.error.ForeColor = System.Drawing.Color.Brown;
				error.Text += "\" " + time + " \"" + "  Invalid argument (" + counter.ToString();
				error.Text += ")" + "\n";
				err = true;
				//********* important to sent zero to port
				if (runer)
				{
					this.objsrv.command("s");
					return 0;
				}
			}
			if (ok == 5)
			{
				this.error.ForeColor = System.Drawing.Color.Brown;
				error.Text += "\" " + checkerror + " \"" + "  Don't expected (" + counter.ToString();
				error.Text += ")" + "\n";
				err = true;
				//********* important to sent zero to port
				if (runer)
				{
					this.objsrv.command("s");
					return 0;
				}
			}
			return 1;
		}
		private int doingfor(string time)
		{
			return 1;
		}
		private int doingfunction(string functionname)
		{
			return 1;
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

		private void openFile_Click(object sender, System.EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			int linecounter=1;
			string fullPathname = openFileDialog.FileName;
			filepath = fullPathname;
			FileInfo src = new FileInfo(fullPathname);
			filename.Text = " " + src.Name;
			source.Text = "";
			TextReader reader = src.OpenText();
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				source.Text +=  line + "\n";
				linecounter ++;
			}
			reader.Close();
			save = true;
			open = true;
			isopen = true;
			textchange = false;
		}

		private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string path = this.saveFileDialog1.FileName;
			TextWriter writer = new StreamWriter(path);
			filepath = path;
			openpath = path;
			writer.Write(source.Text);
			writer.Close();
			//***
			string fullPathname = path;
			filepath = path;
			FileInfo src = new FileInfo(fullPathname);
			filename.Text = src.Name;
			source.Text = "";
			TextReader reader = src.OpenText();
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				source.Text +=line + "\n";
			}
			reader.Close();
			save = true;
			isopen = true;
			textchange = false;
			//**
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.saveFileDialog1.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			runer = false;
			if (isopen)
			{
				string path = filepath;
				TextWriter writer = new StreamWriter(path);
				writer.Write(source.Text);
				writer.Close();
				isopen = true;
				comp = true;
				command();
				textchange = false;
			}
			else
			{
				MessageBox.Show("Can't compile befor save !!!");
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			runer = true;
			if (isopen)
			{
				string path = filepath;
				TextWriter writer = new StreamWriter(path);
				writer.Write(source.Text);
				writer.Close();
				isopen = true;
				comp = true;
				command();
				textchange = false;
			}
			else
			{
				MessageBox.Show("Can't Run befor save !!!");
			}
		}

		private void source_TextChanged(object sender, System.EventArgs e)
		{
			if (save)
				save = false;
			if (comp)
				save = true;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if (!textchange)
			{
				if (currentusername != null)
				{
					bool cancel = false;
					DialogResult disconnect = MessageBox.Show("Are you sure you want quit?",
						"Exit",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning);
					cancel = (disconnect == DialogResult.Cancel);
					if (!cancel)
					{
						closing = true;
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
				else
				{
					bool cancel = false;
					DialogResult disconnect = MessageBox.Show("Are you sure you want quit?",
						"Exit",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning);
					cancel = (disconnect == DialogResult.Cancel);
					if (!cancel)
					{
						closing = true;
						Application.Exit();
					}
				}
			}
			else
			{
				bool ok = false;
				DialogResult disconnect = MessageBox.Show("Exiting without save;\nAre you sure?",
					"Confirm",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question);
				ok = (disconnect == DialogResult.OK);
				if (ok)
				{
					if (currentusername != null)
					{
						closing = true;
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
					else
					{
						closing = true;
						Application.Exit();
					}
				}
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.saveFileDialog1.ShowDialog();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			runer = false;
			if (isopen)
			{
				string path = filepath;
				TextWriter writer = new StreamWriter(path);
				writer.Write(source.Text);
				writer.Close();
				isopen = true;
				comp = true;
				command();
				textchange = false;
			}
			else
			{
				MessageBox.Show("Can't compile befor save !!!");
			}
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			runer = true;
			if (isopen)
			{
				string path = filepath;
				TextWriter writer = new StreamWriter(path);
				writer.Write(source.Text);
				writer.Close();
				isopen = true;
				comp = true;
				command();
				textchange = false;

			}
			else
			{
				MessageBox.Show("Can't Run befor save !!!");
			}
		}

		private void source_TextChanged_1(object sender, System.EventArgs e)
		{
			this.error.Text = "";
			textchange = true;
			compiled = false;
		}

		private void editor_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!closing && !exitbutton)
			{
				if (!textchange)
				{
					DialogResult disconnect = MessageBox.Show("Are you sure you want quit?",
						"Exit",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning);
					e.Cancel = (disconnect == DialogResult.Cancel);
					if (!e.Cancel)
					{
						if (currentusername != null)
						{
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
						else
						{
							Application.Exit();
						}
					}
				}
				else
				{
					DialogResult disconnect = MessageBox.Show("Exiting without save;\nAre you sure?",
						"Exit",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning);
					e.Cancel = (disconnect == DialogResult.Cancel);
					if (!e.Cancel)
					{
						if (currentusername != null)
						{
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
						else
						{
							Application.Exit();
						}
					}
				}
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			if (compiled)
			{
				if (this.textBox1.Text.Trim() != "")
				{
					bool doubldefinition = false;
					bool YES = false;
					int doubleindex = 0;
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
					// CHECKING JOB NAME TO EXIST
					for (int i=0; i<jobnamefild.Length ;i++)
					{
						if (this.textBox1.Text.Trim() == jobnamefild[i])
						{
							doubldefinition = true;
							doubleindex = i;
						}
					}
					// CHECKING COMPLETE
					if (doubldefinition)
					{
						DialogResult disconnect = MessageBox.Show("Would you like to replace the existing job ?",
							"Confirm",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question);
						YES = (disconnect == DialogResult.Yes);
						if (!YES)
						{
							// WRITE LAST JOBS WITHOUT NEW JOB
							if (!emptyfile)
							{
								XmlTextWriter writer = new XmlTextWriter("c:/robonet/XML/jobsinfo.xml", null);
								writer.Formatting = Formatting.Indented;
								writer.WriteStartDocument();
								writer.WriteStartElement("jobinfo");
								writer.WriteAttributeString("xmlns", null, "http://tempuri.org/jobsinfo.xsd");
								for(int i = 0; jobnamefild[i] != null; i++)
								{
									writer.WriteStartElement("jobname");
									writer.WriteString(jobnamefild[i].ToString());
									writer.WriteEndElement();
									writer.WriteStartElement("jobpath");
									writer.WriteString(jobpathfild[i].ToString());
									writer.WriteEndElement();
								}
								writer.WriteEndElement();
								writer.WriteEndDocument();
								writer.Close();
								emptyfile = false;
								reset();
							}
							// WRITE COMPLETE
						}
						else
						{
							// INSERT NEW JOB
							XmlTextWriter writer = new XmlTextWriter("c:/robonet/XML/jobsinfo.xml", null);
							writer.Formatting = Formatting.Indented;
							writer.WriteStartDocument();
							writer.WriteStartElement("jobinfo");
							writer.WriteAttributeString("xmlns", null, "http://tempuri.org/jobsinfo.xsd");
							writer.WriteStartElement("jobname");
							writer.WriteString(this.textBox1.Text.Trim());
							writer.WriteEndElement();
							writer.WriteStartElement("jobpath");
							writer.WriteString("c:/robonet/JOBS/" + this.textBox1.Text.Trim() + ".rn");
							writer.WriteEndElement();
							// NEW JOB INSERTED
							// WRITE LAST JOBS
							if (!emptyfile)
							{
								for(int i = 0; jobnamefild[i] != null; i++)
								{
									if (doubleindex != i)
									{
										writer.WriteStartElement("jobname");
										writer.WriteString(jobnamefild[i].ToString());
										writer.WriteEndElement();
										writer.WriteStartElement("jobpath");
										writer.WriteString(jobpathfild[i].ToString());
										writer.WriteEndElement();
									}
								}
							}
							// WRITEING LAST JOBS COMLETE
							writer.WriteEndElement();
							writer.WriteEndDocument();
							writer.Close();
							emptyfile = false;
							reset();
							// SAVE IN JOBS FOLDER
							TextWriter savewriter = new StreamWriter("c:/robonet/JOBS/" + this.textBox1.Text + ".rn");
							savewriter.Write(source.Text);
							savewriter.Close();
							// SAVE COMPLETE
							MessageBox.Show(this.textBox1.Text.Trim() + " add to joblist successfuly.");
						}
					}
					else
					{
						// INSERT NEW JOB
						XmlTextWriter writer = new XmlTextWriter("c:/robonet/XML/jobsinfo.xml", null);
						writer.Formatting = Formatting.Indented;
						writer.WriteStartDocument();
						writer.WriteStartElement("jobinfo");
						writer.WriteAttributeString("xmlns", null, "http://tempuri.org/jobsinfo.xsd");
						writer.WriteStartElement("jobname");
						writer.WriteString(this.textBox1.Text.Trim());
						writer.WriteEndElement();
						writer.WriteStartElement("jobpath");
						writer.WriteString("c:/robonet/JOBS/" + this.textBox1.Text.Trim() + ".rn");
						writer.WriteEndElement();
						// NEW JOB INSERTED
						// WRITE LAST JOBS
						if (!emptyfile)
						{
							for(int i = 0; jobnamefild[i] != null; i++)
							{
								writer.WriteStartElement("jobname");
								writer.WriteString(jobnamefild[i].ToString());
								writer.WriteEndElement();
								writer.WriteStartElement("jobpath");
								writer.WriteString(jobpathfild[i].ToString());
								writer.WriteEndElement();
							}
						}
						// WRITEING LAST JOBS COMLETE
						writer.WriteEndElement();
						writer.WriteEndDocument();
						writer.Close();
						emptyfile = false;
						reset();

						// SAVE IN JOBS FOLDER
						TextWriter savewriter = new StreamWriter("c:/robonet/JOBS/" + this.textBox1.Text + ".rn");
						savewriter.Write(source.Text);
						savewriter.Close();
						// SAVE COMPLETE
						MessageBox.Show(this.textBox1.Text.Trim() + " add to joblist successfuly.");
					}
					doubldefinition = false;
				}
				else
				{
					MessageBox.Show("Please fill the jobname fild.");
				}
			}
			else
			{
				MessageBox.Show("Can't add to joblist befor compile !!!");
			}
		}
		private void reset()
		{
			for (int i=0;i<jobnamefild.Length ;i++)
			{
				jobnamefild[i] = null;
				jobpathfild[i] = null;
			}
			jobnamecounter = 0;
			jobpathcounter = 0;
			emptyfile = false;
		}
		private void valHandler(Object sender, ValidationEventArgs e)
		{
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			if (!textchange)
			{
				if (currentusername != null)
				{
					bool cancel = false;
					DialogResult disconnect = MessageBox.Show("Are you sure you want quit?",
						"Exit",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning);
					cancel = (disconnect == DialogResult.Cancel);
					if (!cancel)
					{
						closing = true;
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
				else
				{
					bool cancel = false;
					DialogResult disconnect = MessageBox.Show("Are you sure you want quit?",
						"Exit",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Warning);
					cancel = (disconnect == DialogResult.Cancel);
					if (!cancel)
					{
						closing = true;
						Application.Exit();
					}
				}
			}
			else
			{
				bool ok = false;
				DialogResult disconnect = MessageBox.Show("Exiting without save;\nAre you sure?",
					"Confirm",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Question);
				ok = (disconnect == DialogResult.OK);
				if (ok)
				{
					if (currentusername != null)
					{
						closing = true;
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
					else
					{
						closing = true;
						Application.Exit();
					}
				}
			}
		}

		private void editor_Load(object sender, System.EventArgs e)
		{
		
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			this.textBox1.SelectAll();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if (this.textBox1.Text.Trim() != "")
			{
				bool exist = false;
				bool YES = false;
				int index = 0;
				reset();
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
				// CHECKING JOB NAME TO EXIST
				for (int i=0; i<jobnamefild.Length ;i++)
				{
					if (this.textBox1.Text.Trim() == jobnamefild[i])
					{
						exist = true;
						index = i;
					}
				}
				// CHECKING COMPLETE
				if (exist)
				{
					DialogResult disconnect = MessageBox.Show("Are you sure you want delete job ?",
						"Delete job",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);
					YES = (disconnect == DialogResult.Yes);
					if (YES)
					{
						// WRITE LAST JOBS
						XmlTextWriter writer = new XmlTextWriter("c:/robonet/XML/jobsinfo.xml", null);
						writer.Formatting = Formatting.Indented;
						writer.WriteStartDocument();
						writer.WriteStartElement("jobinfo");
						writer.WriteAttributeString("xmlns", null, "http://tempuri.org/jobsinfo.xsd");
						if (!emptyfile)
						{
							for(int i = 0; jobnamefild[i] != null; i++)
							{
								if (index != i)
								{
									writer.WriteStartElement("jobname");
									writer.WriteString(jobnamefild[i].ToString());
									writer.WriteEndElement();
									writer.WriteStartElement("jobpath");
									writer.WriteString(jobpathfild[i].ToString());
									writer.WriteEndElement();
								}
							}
						}
						// WRITEING LAST JOBS COMLETE
						writer.WriteEndElement();
						writer.WriteEndDocument();
						writer.Close();
						emptyfile = false;
						reset();
						// REMOVE SOURCE OF JOB
						System.IO.File.Delete("C:/robonet/JOBS/" + this.textBox1.Text.Trim() + ".rn");
						// REMOVE COMPLETE
						MessageBox.Show(this.textBox1.Text.Trim() + " delete successfuly.");
					}
				}
				else
				{
					MessageBox.Show("Job not found !!!");
				}
			}
			else
			{
				MessageBox.Show("Please fill the jobname fild.");
			}
		}

		private void keygenerate()
		{
			nextkey = random.Next(99999);
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (disconnect == false)
			{
				if (!textchange)
				{
					backbutton = true;
					closing = true;
					this.Visible = false;
					this.controlform = new control();
					controlform.currentusername = this.currentusername;
					controlform.currentpassword = this.currentpassword;
					controlform.currentkey = this.currentkey;
					controlform.ok = this.on;
					controlform.websrv = this.websrv;
					this.controlform.ShowDialog();
					this.Close();
				}
				else
				{
					bool ok = false;
					DialogResult disconnecting = MessageBox.Show("Exiting without save;\nAre you sure?",
						"Confirm",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Question);
					ok = (disconnecting == DialogResult.OK);
					if (ok)
					{
						closing = true;
						backbutton = true;
						this.Visible = false;
						this.controlform = new control();
						controlform.currentusername = this.currentusername;
						controlform.currentpassword = this.currentpassword;
						controlform.currentkey = this.currentkey;
						controlform.ok = this.on;
						controlform.websrv = this.websrv;
						this.controlform.ShowDialog();
						this.Close();
					}
				}
			}
			else
			{
				if (!textchange)
				{
					closing = true;
					this.Visible = false;
					this.authenticationform = new authentication();
					this.authenticationform.ShowDialog();
					this.Close();
				}
				else
				{
					bool ok = false;
					DialogResult disconnecting = MessageBox.Show("Exiting without save;\nAre you sure?",
						"Confirm",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Question);
					ok = (disconnecting == DialogResult.OK);
					if (ok)
					{
						closing = true;
						this.Visible = false;
						this.authenticationform = new authentication();
						this.authenticationform.ShowDialog();
						this.Close();
					}
				}
			}
		}
	}
}
