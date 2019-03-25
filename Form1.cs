// **************************************************************************************
//  Program: NewsHeadlines (RSSFeedReader)
//  Description: Reads RSS Feeds and sorts them into a legible format with auto-updating
//  Author: Arhum Nayyar (Rummy)
//  Date of Creation: 4/25/15
//  Date of Completion: 4/25/15
// **************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; //We need this since everything we will do will involve XML and also Feeds are saved as XML's :)
using System.ServiceModel; //Service Model allows us to perform various functions such as grabbing Titles, Descriptions, Syndication, Formatting.
using System.ServiceModel.Description;
using System.ServiceModel.Syndication;


namespace NewsHeadlines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
        }
        ListBox RumList = new ListBox(); //Add the items (Descriptions) into a listbox so we can easily list out each headline for that feed

        string XMLURL = ""; //this is a universal string that will define the url. We do this to be able to change the url just by changing the string text within each Feed Button url rather than having multiple methods of the method below. (Look at XmlReader = RumReader, it uses the string)

        public void RumFeedCreator() { //this is our main method, as it will go to the xml and grab all items and sort everything
            try
            {   
                XmlReader RumReader = XmlReader.Create(XMLURL); //gets the URL using XMLREADER and converts it to a useable method
                SyndicationFeed RumFeed = SyndicationFeed.Load(RumReader); //will load the URL using RumReader

                TabPage RumTab = new TabPage(RumFeed.Title.Text); //creates a new tab page with the title of the feed


                tabControl1.TabPages.Add(RumTab); //add new tab with Feed Name

                ListBox RumList = new ListBox(); //Add the items (Descriptions) into a listbox so we can easily list out each headline for that feed

                RumTab.Controls.Add(RumList); //Add the list box into the tab

                RumList.Dock = DockStyle.Fill; //Make the listbox fill into the group/textbox

                RumList.HorizontalScrollbar = true; //allow scrolling in the textbox


                foreach (SyndicationItem Rumitems in RumFeed.Items) //loop until we get all items
                {
                    string summarytext = Rumitems.Summary.Text; //define the first instance of the summary text
                    bool bbcoderemover = true; //set the bbcoderemover boolean to true at default so it can keep looping until its shut off

                    string finalsummarytext = ""; //final instance/revised of the summary text

                    foreach (char RumCharData in summarytext) //for each letter in summarytext 
                    {
                        if (RumCharData != '<' && bbcoderemover) //if the data is there and bbcoderemover is true remove everything after the initalization of bbcodes (the < )
                        {
                            finalsummarytext = finalsummarytext + RumCharData;  //Adds the revised final summary all together to use
                        }
                        else
                        {
                            bbcoderemover = false; //if theres no data, end loop.
                        }
                    }
                            RumList.Items.Add(Rumitems.Links.ToString());
                            RumList.Items.Add(Rumitems.Title.Text); //add the items with title
                            RumList.Items.Add(finalsummarytext); //add the items with the summary
                            RumList.Items.Add("________________________________________________"); //A seperator/divider
                            RumList.Items.Add(""); //A seperator/divider
                      
                }

                
            }
            catch //if theres an error print a message
            {
                MessageBox.Show("Error! Please check the URL and make sure its a correct RSS Feed URL!");
            }
            
            
    }

        public void RumCustomFeedCreator() //this is the same method as above except the first line "XmlReader RumReader..." uses the textBox1 text (the input url) as the XML page!
        {
            try
            {
                XmlReader RumReader = XmlReader.Create(textBox1.Text); //gets the URL using XMLREADER and converts it to a useable method
                SyndicationFeed RumFeed = SyndicationFeed.Load(RumReader); //will load the URL using RumReader

                TabPage RumTab = new TabPage(RumFeed.Title.Text); //creates a new tab page with the title of the feed

                
                tabControl1.TabPages.Add(RumTab); //add new tab with Feed Name

                ListBox RumList = new ListBox(); //Add the items (Descriptions) into a listbox so we can easily list out each headline for that feed

                RumTab.Controls.Add(RumList); //Add the list box into the tab

                RumList.Dock = DockStyle.Fill; //Make the listbox fill into the group/textbox

                RumList.HorizontalScrollbar = true; //allow scrolling in the textbox

                foreach (SyndicationItem Rumitems in RumFeed.Items) //loop until we get all items
                {
                    string summarytext = Rumitems.Summary.Text;
                    bool bbcoderemover = true;

                    string finalsummarytext = "";

                    foreach (char RumCharData in summarytext) //for each letter in summarytext 
                    {
                        if (RumCharData != '<' && bbcoderemover) //if the data is there and bbcoderemover is true remove everything after the initalization of bbcodes (the < )
                        {
                            finalsummarytext = finalsummarytext + RumCharData; //Adds the revised final summary all together to use
                        }
                        else
                        {
                            bbcoderemover = false; //if theres no data, end loop.
                        }
                    }

                    RumList.Items.Add(Rumitems.Title.Text); //add the items with title
                    RumList.Items.Add(finalsummarytext); //add the items with the summary
                    RumList.Items.Add("________________________________________________"); //A seperator/divider
                    RumList.Items.Add(""); //A seperator/divider
                }
            }
            catch //if theres an error print a message
            {
                MessageBox.Show("Error! Please check the URL and make sure its a correct RSS Feed URL!");
            }
        }

        void RumList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RumCustomFeedCreator(); //calls the RumCustomFeedCreator
        }

        private void WorldFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/World.xml"; //defines the universal XMLURL to the "World" Feed URL
            RumFeedCreator(); //creates the Feed using the XMLURL above ^
        }

        private void ScienceFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/Science.xml"; //defines the universal XMLURL to the "Science" Feed URL
            RumFeedCreator();
        }

        private void BusinessFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/Business.xml";
            RumFeedCreator();
        }

        private void HealthFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/Health.xml";
            RumFeedCreator();
        }

        private void TechnologyFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/Technology.xml";
            RumFeedCreator();
        }

        private void NewYorkFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/NYRegion.xml";
            RumFeedCreator();
        }

        private void SportsFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/Sports.xml";
            RumFeedCreator();
        }

        private void USFeed_Click(object sender, EventArgs e)
        {
            XMLURL = "http://rss.nytimes.com/services/xml/rss/nyt/US.xml";
            RumFeedCreator();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tabControl1.Refresh();
        }
    }
}
