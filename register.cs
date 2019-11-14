using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RobonetControlApplication
{

	public class register : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
		//
		//webservice
		//
		private RobonetControlApplication.localhost.roboservice websrv;
		//
		//authentication form
		//
		private RobonetControlApplication.authentication authenticationform;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public register()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(register));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.websrv = new RobonetControlApplication.localhost.roboservice();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(6, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(315, 368);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(12, 295);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(289, 30);
			this.label8.TabIndex = 17;
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Location = new System.Drawing.Point(13, 262);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(69, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "&Reset";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(235, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(69, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "&Cancel";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(87, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "&Back";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(161, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "&Next";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Location = new System.Drawing.Point(11, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(289, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Please fill all of filds by valid information.";
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(12, 228);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Email";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(111, 228);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(193, 20);
			this.textBox6.TabIndex = 10;
			this.textBox6.Text = "";
			this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(111, 191);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(193, 20);
			this.textBox5.TabIndex = 9;
			this.textBox5.Text = "";
			this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(111, 154);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(193, 20);
			this.textBox4.TabIndex = 8;
			this.textBox4.Text = "";
			this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(111, 117);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(193, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(111, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(193, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "";
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(111, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(193, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(12, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Lastname";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(12, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Name";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(12, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirm password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// websrv
			// 
			this.websrv.Credentials = null;
			this.websrv.UnsafeAuthenticatedConnectionSharing = false;
			this.websrv.Url = "http://localhost/roboservice/robonetservice.asmx";
			this.websrv.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; MS Web Services Client Protocol 1.1.4322.573)";
			// 
			// register
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(329, 375);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "register";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Signin";
			this.Closed += new System.EventHandler(this.register_Closed);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;
			this.authenticationform = new authentication();
			this.authenticationform.ShowDialog();
			this.Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int result,webresult = 3;
			result = Checkinformation(this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,
				this.textBox4.Text,this.textBox5.Text,this.textBox6.Text);
			switch (result)
			{
				case 1:
				{
					this.label8.Text = "";
					webresult = this.websrv.Signin(this.textBox1.Text,this.textBox2.Text,
						this.textBox4.Text,this.textBox5.Text,this.textBox6.Text);
					break;
				}
				case 2:
				{
					this.textBox1.Focus();
					this.label8.Text = "Please fill all of filds. \nCan't left \"Username fild\" empty !!!";
					break;
				}
				case 3:
				{
					this.textBox2.Focus();
					this.label8.Text = "Please fill all of filds. \nCan't left \"Password fild\" empty !!!";
					break;
				}
				case 4:
				{
					this.textBox3.Focus();
					this.label8.Text = "Please fill all of filds. \nCan't left \"Confirmpassword\" fild empty !!!";
					break;
				}
				case 5:
				{
					this.textBox4.Focus();
					this.label8.Text = "Please fill all of filds. \nCan't left \"Name\" fild empty !!!";
					break;
				}
				case 6:
				{
					this.textBox5.Focus();
					this.label8.Text = "Please fill all of filds. \nCan't left \"Lastname\" fild empty !!!";
					break;
				}
				case 7:
				{
					this.textBox6.Focus();
					this.label8.Text = "Please fill all of filds. \nCan't left \"Email\" fild empty !!!";
					break;
				}
				case 8:
				{
					this.textBox2.Focus();
					this.textBox2.SelectAll();
					this.label8.Text = "The passwords you typed do not match !!!";
					break;
				}
				case 9:
				{
					this.textBox2.Focus();
					this.label8.Text = "For your password atleast type 6 charater !!!";
					break;
				}
				case 10:
				{
					this.textBox6.Focus();
					this.label8.Text = "Enter your email address completely !!! \nFor example yourmail@yahoo.com";
					break;
				}
			}
			switch (webresult)
			{
				case 0:
				{
					this.label8.Text = "Error: Can't insert data in bank !!!";
					break;
				}
				case 1:
				{
					bool ok = false;
					DialogResult disconnect = MessageBox.Show("Signin complete successfully",
						"Message",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					ok = (disconnect == DialogResult.OK);
					if (ok)
					{
						this.Visible = false;
						this.authenticationform = new authentication();
						this.authenticationform.ShowDialog();
						this.Close();
					}
					break;
				}
				case 2:
				{
					this.textBox1.Focus();
					this.textBox1.SelectAll();
					this.label8.Text = "\"" + this.textBox1.Text + "\"" + " registered !!!";
					break;
				}
			}
		}
		private int Checkinformation(string username,string password,string confirm,
			string name,string lastname,string email)
		{
			if (username.Trim() == "")
				return 2;
			else if(password == "")
				return 3;
			else if (confirm == "")
				return 4;
			else if (name.Trim() == "")
				return 5;
			else if (lastname.Trim() == "")
				return 6;
			else if (email.Trim() == "")
				return 7;
			else if (password.CompareTo(confirm) != 0)
				return 8;
			else if (password.Length <6)
				return 9;
			else
			{
				int result;
				result = Checkmailsyntax(email.Trim());
				if (result == 0)
					return 10;
			}
			return 1;
		}
		private int Checkmailsyntax(string email)
		{
			string next,mail,domain,zone;
			try
			{
				int i;
				i = email.IndexOf("@");
				next = email.Substring(i+1);
				mail = email.Substring(0,i);
			}
			catch(Exception caught)
			{
				return 0;
			}
			try
			{
				int i;
				i = next.IndexOf(".");
				zone = next.Substring(i+1);
				domain = next.Substring(0,i);
			}
			catch(Exception caught)
			{
				return 0;
			}
			if ((mail == "") || (domain == "") || (zone == ""))
				return 0;
			return 1;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.textBox3.Text = "";
			this.textBox4.Text = "";
			this.textBox5.Text = "";
			this.textBox6.Text = "";
			this.label8.Text = "";
			this.textBox1.Focus();
		}
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			this.textBox1.SelectAll();
		}

		private void textBox2_Enter(object sender, System.EventArgs e)
		{
			this.textBox2.SelectAll();
		}

		private void textBox3_Enter(object sender, System.EventArgs e)
		{
			this.textBox3.SelectAll();
		}

		private void textBox4_Enter(object sender, System.EventArgs e)
		{
			this.textBox4.SelectAll();
		}

		private void textBox5_Enter(object sender, System.EventArgs e)
		{
			this.textBox5.SelectAll();
		}

		private void textBox6_Enter(object sender, System.EventArgs e)
		{
			this.textBox6.SelectAll();
		}

		private void register_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
