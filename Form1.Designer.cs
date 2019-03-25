namespace NewsHeadlines
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USFeed = new System.Windows.Forms.Button();
            this.SportsFeed = new System.Windows.Forms.Button();
            this.NewYorkFeed = new System.Windows.Forms.Button();
            this.TechnologyFeed = new System.Windows.Forms.Button();
            this.HealthFeed = new System.Windows.Forms.Button();
            this.WorldFeed = new System.Windows.Forms.Button();
            this.ScienceFeed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BusinessFeed = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add custom feed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(6, 16);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 427);
            this.tabControl1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.USFeed);
            this.groupBox1.Controls.Add(this.SportsFeed);
            this.groupBox1.Controls.Add(this.NewYorkFeed);
            this.groupBox1.Controls.Add(this.TechnologyFeed);
            this.groupBox1.Controls.Add(this.HealthFeed);
            this.groupBox1.Controls.Add(this.WorldFeed);
            this.groupBox1.Controls.Add(this.ScienceFeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BusinessFeed);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // USFeed
            // 
            this.USFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources._961812489166_HC0tfdqt_l;
            this.USFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.USFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.USFeed.Location = new System.Drawing.Point(56, 311);
            this.USFeed.Name = "USFeed";
            this.USFeed.Size = new System.Drawing.Size(40, 38);
            this.USFeed.TabIndex = 15;
            this.toolTip1.SetToolTip(this.USFeed, "U.S Feed");
            this.USFeed.UseVisualStyleBackColor = true;
            this.USFeed.Click += new System.EventHandler(this.USFeed_Click);
            // 
            // SportsFeed
            // 
            this.SportsFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.Sports_ball_rugbyball_rugby_512;
            this.SportsFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SportsFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SportsFeed.Location = new System.Drawing.Point(6, 311);
            this.SportsFeed.Name = "SportsFeed";
            this.SportsFeed.Size = new System.Drawing.Size(40, 38);
            this.SportsFeed.TabIndex = 14;
            this.toolTip1.SetToolTip(this.SportsFeed, "Sports Feed");
            this.SportsFeed.UseVisualStyleBackColor = true;
            this.SportsFeed.Click += new System.EventHandler(this.SportsFeed_Click);
            // 
            // NewYorkFeed
            // 
            this.NewYorkFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.NY;
            this.NewYorkFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewYorkFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewYorkFeed.Location = new System.Drawing.Point(56, 236);
            this.NewYorkFeed.Name = "NewYorkFeed";
            this.NewYorkFeed.Size = new System.Drawing.Size(40, 38);
            this.NewYorkFeed.TabIndex = 13;
            this.toolTip1.SetToolTip(this.NewYorkFeed, "New York Feed");
            this.NewYorkFeed.UseVisualStyleBackColor = true;
            this.NewYorkFeed.Click += new System.EventHandler(this.NewYorkFeed_Click);
            // 
            // TechnologyFeed
            // 
            this.TechnologyFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.Lighting_icon;
            this.TechnologyFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TechnologyFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechnologyFeed.Location = new System.Drawing.Point(6, 236);
            this.TechnologyFeed.Name = "TechnologyFeed";
            this.TechnologyFeed.Size = new System.Drawing.Size(40, 38);
            this.TechnologyFeed.TabIndex = 12;
            this.toolTip1.SetToolTip(this.TechnologyFeed, "Technology Feed");
            this.TechnologyFeed.UseVisualStyleBackColor = true;
            this.TechnologyFeed.Click += new System.EventHandler(this.TechnologyFeed_Click);
            // 
            // HealthFeed
            // 
            this.HealthFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.images1;
            this.HealthFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HealthFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealthFeed.Location = new System.Drawing.Point(56, 169);
            this.HealthFeed.Name = "HealthFeed";
            this.HealthFeed.Size = new System.Drawing.Size(40, 38);
            this.HealthFeed.TabIndex = 11;
            this.toolTip1.SetToolTip(this.HealthFeed, "Health Feed");
            this.HealthFeed.UseVisualStyleBackColor = true;
            this.HealthFeed.Click += new System.EventHandler(this.HealthFeed_Click);
            // 
            // WorldFeed
            // 
            this.WorldFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.hobsons_blog_world;
            this.WorldFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorldFeed.Location = new System.Drawing.Point(6, 105);
            this.WorldFeed.Name = "WorldFeed";
            this.WorldFeed.Size = new System.Drawing.Size(40, 38);
            this.WorldFeed.TabIndex = 10;
            this.toolTip1.SetToolTip(this.WorldFeed, "World Feed");
            this.WorldFeed.UseVisualStyleBackColor = true;
            this.WorldFeed.Click += new System.EventHandler(this.WorldFeed_Click);
            // 
            // ScienceFeed
            // 
            this.ScienceFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.chemistry_laboratory_flask_beaker_lab_potion_glassware_chemical_experiment_flat_design_icon_512;
            this.ScienceFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScienceFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScienceFeed.Location = new System.Drawing.Point(56, 105);
            this.ScienceFeed.Name = "ScienceFeed";
            this.ScienceFeed.Size = new System.Drawing.Size(40, 38);
            this.ScienceFeed.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ScienceFeed, "Science Feed");
            this.ScienceFeed.UseVisualStyleBackColor = true;
            this.ScienceFeed.Click += new System.EventHandler(this.ScienceFeed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hover for tooltips";
            // 
            // BusinessFeed
            // 
            this.BusinessFeed.BackgroundImage = global::NewsHeadlines.Properties.Resources.Account_and_Control;
            this.BusinessFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BusinessFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusinessFeed.Location = new System.Drawing.Point(6, 169);
            this.BusinessFeed.Name = "BusinessFeed";
            this.BusinessFeed.Size = new System.Drawing.Size(40, 38);
            this.BusinessFeed.TabIndex = 7;
            this.toolTip1.SetToolTip(this.BusinessFeed, "Business Feed");
            this.BusinessFeed.UseVisualStyleBackColor = true;
            this.BusinessFeed.Click += new System.EventHandler(this.BusinessFeed_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(3, 410);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feed URL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(122, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 449);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feed";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 444);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(72, 17);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(11, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(494, 467);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.77D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NewsHeadlines By Rummy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BusinessFeed;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ScienceFeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button USFeed;
        private System.Windows.Forms.Button SportsFeed;
        private System.Windows.Forms.Button NewYorkFeed;
        private System.Windows.Forms.Button TechnologyFeed;
        private System.Windows.Forms.Button HealthFeed;
        private System.Windows.Forms.Button WorldFeed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

