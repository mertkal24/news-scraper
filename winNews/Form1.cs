using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CodeHollow.FeedReader;
using CodeHollow.FeedReader.Feeds;
using Newtonsoft.Json;
using NewSites.Core;

namespace winNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Casper\Desktop\C# Eğitim\winNews\NewsSites\bin\Debug\", "*.dll");
            foreach(string item in files)
            {
                Assembly nAssm = Assembly.LoadFrom(item);
                Type[] types = nAssm.GetTypes();
                foreach(Type type in types)
                {
                    if (type.BaseType == typeof(NewsSite))
                    {
                        NewsSite news =(NewsSite) Activator.CreateInstance(type);
                        newsSiteComboBox.Items.Add(news);
                    }
                }
            }
        }

        private void newsSiteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newsList.Items.Clear();
            string read = newsSiteComboBox.Items[newsSiteComboBox.SelectedIndex].GetType().GetProperties().First(l => l.Name == "XmlLink").GetValue(newsSiteComboBox.Items[newsSiteComboBox.SelectedIndex], null).ToString();
            Feed feed = FeedReader.Read(read);          
             
            foreach (FeedItem item in feed.Items)
            {
                News news = new News();
                news.Title = item.Title;
                news.Link = item.Link;
                news.Description = item.Description; 
                news.ImageUrl = item.SpecificItem.Element.Element("image").Value;
                newsList.Items.Add(news); 
            }


        }

        private void newsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            
           
        }

        private void newsDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
