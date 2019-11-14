using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace RobonetControlApplication
{

	public class authentication : System.Windows.Forms.Form
	{
		//
		// register form
		//
		private RobonetControlApplication.editor editorform;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button5;
		//
		// variables
		//
		public string currentusername,currentpassword;
		public int currentkey;
		//
		// webservice
		//
		private localhost.roboservice websrv;
		//private localhost.robonetservice websrv;
		//
		// register form
		//
		private RobonetControlApplication.register registerform;
		//
		// control form
		//
		private RobonetControlApplication.control controlform;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public authentication()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		[STAThread]
		static void Main() 
		{
			Application.Run(new authentication());
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(authentication));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.websrv = new RobonetControlApplication.localhost.roboservice();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(8, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 265);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Location = new System.Drawing.Point(40, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Connecting to Robonet";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(277, 43);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.ForeColor = System.Drawing.Color.Red;
			this.button5.Location = new System.Drawing.Point(42, 232);
			this.button5.Name = "button5";
			this.button5.TabIndex = 8;
			this.button5.Text = "&Force";
			this.button5.Visible = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Location = new System.Drawing.Point(196, 232);
			this.button4.Name = "button4";
			this.button4.TabIndex = 6;
			this.button4.Text = "&Cancel";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(142, 156);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "&Login";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(65, 156);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "&Reset";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(42, 114);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(42, 89);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(141, 114);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(141, 89);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(119, 232);
			this.button3.Name = "button3";
			this.button3.TabIndex = 5;
			this.button3.Text = "&Signin";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(48, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 28);
			this.label3.TabIndex = 7;
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// websrv
			// 
			this.websrv.Credentials = null;
			this.websrv.UnsafeAuthenticatedConnectionSharing = false;
			this.websrv.Url = "http://localhost/roboservice/robonetservice.asmx";
			this.websrv.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; MS Web Services Client Protocol 1.1.4322.573)";
			// 
			// authentication
			// 
			this.AcceptButton = this.button2;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.CancelButton = this.button4;
			this.ClientSize = new System.Drawing.Size(296, 274);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "authentication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Authentication";
			this.Closed += new System.EventHandler(this.authentication_Closed);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text = null;
			this.textBox2.Text = null;
			this.label3.Text = "";
			this.textBox1.Focus();
			this.button5.Visible = false;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string result;
			this.button5.Visible = false;
			this.label3.Text = "Please wait...";
			result = this.websrv.Connect(this.textBox1.Text.Trim(),this.textBox2.Text);
			if (result.CompareTo("Divice is being used by another user !!!") == 0)
				this.label3.Text = result;
			else if (result.CompareTo("You haven't Permission !!!") == 0)
				this.label3.Text = result;
			else if (result.CompareTo("Thread error !!!") == 0)
				this.label3.Text = result;
			else if (result.CompareTo("Invalid username or password !!!") == 0)
			{
				this.textBox2.Text = null;
				this.textBox2.Focus();
				this.label3.Text = result;
			}
			else if(result.CompareTo("XML file error !!!") == 0)
				this.label3.Text = result;
			else if (this.textBox1.Text.Trim().CompareTo("Administrator") == 0)
			{
				if (result.Length > 30)
				{
					string message,user;
					int i;
					this.button5.Visible = true;
					i = result.IndexOf(":");
					user = result.Substring(i+1);
					message = result.Substring(0,i);
					this.label3.Text = message + " :\n" + user;
				}
				else
				{
					string newusers,key;
					int i;
					i = result.IndexOf("#");
					newusers = result.Substring(i+1);
					key = result.Substring(0,i);
					if (newusers != null)
					{
						this.label3.Text = "";
						currentkey = Convert.ToInt32(key);
						MessageBox.Show(newusers + " New user(s) signin.");
						this.Visible = false;
						this.controlform = new control();
						controlform.currentusername = this.textBox1.Text.Trim();
						controlform.currentpassword = this.textBox2.Text;
						controlform.currentkey = this.currentkey;
						controlform.websrv = this.websrv;
						this.textBox1.Text = null;
						this.textBox2.Text = null;
						this.controlform.ShowDialog();
						this.Close();
					}
				}
			}
			else
			{
				this.label3.Text = "";
				currentkey = Convert.ToInt32(result);
				this.controlform= new control();
				controlform.currentusername = this.textBox1.Text.Trim();
				controlform.currentpassword = this.textBox2.Text;
				controlform.currentkey = this.currentkey;
				controlform.websrv = this.websrv;
				this.Visible = false;
				this.textBox1.Text = null;
				this.textBox2.Text = null;
				this.controlform.ShowDialog();
				this.Close();
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.button5.Visible = false;
			this.Visible = false;
			this.registerform = new register();
			this.registerform.ShowDialog();
			this.Close();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			string result;
			result = this.websrv.Force(this.textBox1.Text.Trim(),this.textBox2.Text);
			if (result.CompareTo("Thread error !!!") == 0)
				this.label3.Text = result;
			else if(result.CompareTo("XML file error !!!") == 0)
				this.label3.Text = result;
			else
			{
				string newusers,key;
				int i;
				i = result.IndexOf("#");
				newusers = result.Substring(i+1);
				key = result.Substring(0,i);
				this.label3.Text = "";
				this.button5.Visible = false;
				currentkey = Convert.ToInt32(key);
				MessageBox.Show(newusers + " New user(s) signin.");
				this.Visible = false;
				this.controlform = new control();
				controlform.currentusername = this.textBox1.Text.Trim();
				controlform.currentpassword = this.textBox2.Text;
				controlform.currentkey = this.currentkey;
				controlform.websrv = this.websrv;
				this.textBox1.Text = null;
				this.textBox2.Text = null;
				this.controlform.ShowDialog();
				this.Close();
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			this.button5.Visible = false;
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			this.button5.Visible = false;
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			this.textBox1.SelectAll();
		}

		private void textBox2_Enter(object sender, System.EventArgs e)
		{
			this.textBox2.SelectAll();
		}

		private void authentication_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

	}	
}
