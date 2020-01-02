using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using Newtonsoft.Json;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;
using System.Collections.Specialized;
using OpenQA.Selenium.Chrome;

namespace Sprm
{
    #pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
    public partial class Tasks : UserControl
    {

        #pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        public Tasks()
        {
            InitializeComponent();
            //Test Task
            dataGridView1.Rows.Add(dataGridView1.Rows.Count, "Duffle Bag", "Bags", "Random", "Black", "Nico 1", "Normal", "Ready", "⯈");
            dataGridView1.Rows.Add(dataGridView1.Rows.Count, "Nuptse Jacket", "Jackets", "Medium", "Paper Print", "Nico 1", "Normal", "Ready", "⯈");
        }

        #pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        public void Runtasks(int task, string category, string product, string size, string color)
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        {

            var bw = new BackgroundWorker();
            //bw.ReportProgress = true;
            bw.DoWork += delegate {
                //var http = new HttpClient();
                //http.Request.Accept = HttpContentTypes.ApplicationJson;
                //var response = http.Get("http://www.supremenewyork.com/mobile_stock.json");
                //var customer = response.DynamicBody;
                //string ID = "304531";
                this.Invoke(new MethodInvoker(delegate
                {

                    WebClient n = new WebClient();
                    var json = n.DownloadString("http://www.supremenewyork.com/mobile_stock.json");
                    
                    JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                    JavaScriptSerializer jsonSerializer1 = new JavaScriptSerializer();
                    dynamic dobj = jsonSerializer.Deserialize<dynamic>(json);
                    
                    foreach (dynamic item in dobj["products_and_categories"][category])
                    {                        
                        if (item["name"].Contains(product))
                        {
                            textBox3.AppendText("\r\n" + item["name"].ToString());
                            textBox3.AppendText("\r\n" + item["id"].ToString());
                            var json2 =n.DownloadString("http://www.supremenewyork.com/shop/"+item["id"]+".json");
                            dynamic dobj1 = jsonSerializer1.Deserialize<dynamic>(json2);
                            foreach (dynamic item2 in dobj1["styles"])
                            {
                                if (item2["name"].ToString() == color)
                                {
                                    textBox3.AppendText("\r\n" + item2["name"].ToString());
                                    textBox3.AppendText("\r\n" + item2["id"].ToString());

                                    foreach (dynamic item3 in item2["sizes"])
                                    {
                                        
                                        if (item3["name"]== size)
                                        {
                                            
                                            textBox3.AppendText("\r\n" + item3["name"]);
                                            textBox3.AppendText("\r\n" + item3["id"]);
                                            textBox3.AppendText("\r\n" + item3["stock_level"]);
                                            if (item3["stock_level"]==0)
                                            {
                                                textBox3.SelectionColor = Color.Red;
                                                textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #"+task+"-Item out of Stock");
                                                textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Waiting for Restock");
                                                textBox3.SelectionColor = Color.Black;
                                                
                                                
                                            }
                                            if (item3["stock_level"] > 0)
                                            {
                                                textBox3.SelectionColor = Color.LightGreen;
                                                textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Item available");
                                                textBox3.SelectionColor = Color.Black;


                                            }
                                        }
                                        if (size.ToLower() =="random")
                                        {
                                            if (item3["name"] == "N/A")
                                            {
                                                textBox3.AppendText("\r\n" + item3["name"]);
                                                textBox3.AppendText("\r\n" + item3["id"]);
                                                textBox3.AppendText("\r\n" + item3["stock_level"]);
                                                if (item3["stock_level"] == 0)
                                                {
                                                    textBox3.SelectionColor = Color.Red;
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Item out of Stock");
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Waiting for Restock");
                                                    textBox3.SelectionColor = Color.Black;

                                                }
                                                if (item3["stock_level"] > 0)
                                                {
                                                    textBox3.SelectionColor = Color.LightGreen;
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Item available");
                                                    textBox3.SelectionColor = Color.Black;
                                                    atc(item3["id"].ToString(), item2["id"].ToString());
                                                    textBox3.SelectionColor = Color.LightGreen;
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Item add to Cart!");
                                                    textBox3.SelectionColor = Color.Black;



                                                }
                                            }
                                        }
                                        if (size.ToLower() == "any")
                                        {
                                                textBox3.AppendText("\r\n" + item3["name"]);
                                                textBox3.AppendText("\r\n" + item3["id"]);
                                                textBox3.AppendText("\r\n" + item3["stock_level"]);
                                                if (item3["stock_level"] == 0)
                                                {
                                                    textBox3.SelectionColor = Color.Red;
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Item out of Stock");
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Waiting for Restock");
                                                    textBox3.SelectionColor = Color.Black;


                                                }
                                                if (item3["stock_level"] > 0)
                                                {
                                                    textBox3.SelectionColor = Color.LightGreen;
                                                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] Task #" + task + "-Item available");
                                                    textBox3.SelectionColor = Color.Black;


                                                }
                                            
                                        }
                                    }
                                }
                            }

                        }      
                    }
                    


                    
                }));

                
            };
            //bw.ProgressChanged += delegate {  };
            bw.RunWorkerCompleted += delegate {
            // do something with the results.
            };
            bw.RunWorkerAsync();

        }
        
        private void atc( string size, string style)
        {
            
            var request = (HttpWebRequest)WebRequest.Create("http://www.supremenewyork.com/shop/" + style + "/add.json");            
            request.KeepAlive = true;
            request.Method = "POST";
            request.Referer= "http://www.supremenewyork.com/mobile";
            request.Host = "www.supremenewyork.com";
            request.Accept = "application/json";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5376e Safari/8536.25";
            request.CookieContainer = new CookieContainer();
            var postData = "utf8=%E2%9C%93&style=" + style + "&size=" + size + "&commit=hinzuf%C3%BCgen";
            var data = Encoding.ASCII.GetBytes(postData);
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
                

            }
            //using (var driver = new ChromeDriver())

            //{
            //    driver.Navigate().GoToUrl("https://www.supremenewyork.com/shop/cart.json");
            //    //System.Threading.Thread.Sleep(5000);

            //}
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            
            
            textBox3.AppendText("\r\n" + responseString);
            //System.Text.Encoding.UTF8.GetString(data)
        }

        //Create Tasks
        private void Button1_Click(object sender, EventArgs e)
        {
            if (cb_region.Text.Length > 0 && input_keywords.Text.Length > 0 && cb_category.Text.Length > 0 && cb_color.Text.Length > 0 && cb_size.Text.Length > 0 && cb_profile.Text.Length > 0 && cb_mode.Text.Length > 0)
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    textBox3.AppendText("\r\n [" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] " + "Task #" + dataGridView1.Rows.Count + " created");
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count, input_keywords.Text, cb_category.Text, cb_size.Text, cb_color.Text, cb_profile.Text, cb_mode.Text, "Ready", "⯈");
                }
            }
            else
            {
                MessageBox.Show("Please, check your input!", "Check your Input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        //Start-Stop Tasks
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == dataGridView1.Columns["c_start"].Index && e.RowIndex >= 0)
            {
                object val = dataGridView1.Rows[e.RowIndex].Cells["c_start"].Value;
                if (val.ToString() == "■")
                {
                    dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value = "Stopped!";
                    dataGridView1.Rows[e.RowIndex].Cells["c_start"].Value = "⯈";
                    dataGridView1.Rows[e.RowIndex].Cells["Column6"].Style.ForeColor = Color.Red;
                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] " + "Task #" + e.RowIndex + " stopped!");
                    
                }
                else if (val.ToString() == "⯈")
                {
                    dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value = "Running!";
                    dataGridView1.Rows[e.RowIndex].Cells["c_start"].Value = "■";
                    dataGridView1.Rows[e.RowIndex].Cells["Column6"].Style.ForeColor = Color.Green;
                    textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] " + "Task #" + e.RowIndex + " started!");
                    Runtasks(e.RowIndex,dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["c_style"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
                   
                }  
               

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Column6"].Value = "Running!";
                dataGridView1.Rows[i].Cells["c_start"].Value = "■";
                dataGridView1.Rows[i].Cells["Column6"].Style.ForeColor = Color.Green;
                textBox3.SelectionColor = Color.LightGreen;
                textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] " + "Task #" + i + " started!");
                textBox3.SelectionColor = Color.Black;
                Runtasks(i,dataGridView1.Rows[i].Cells["Column3"].Value.ToString(), dataGridView1.Rows[i].Cells["Column2"].Value.ToString(), dataGridView1.Rows[i].Cells["c_style"].Value.ToString(), dataGridView1.Rows[i].Cells["Column4"].Value.ToString());

            }


        }

        private void Button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows.Clear();
            }

        }

        #pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            //XDocument xDoc = XDocument.Load(Application.StartupPath + @"\Billing-Profiles.xml");

            //var profile = xDoc.Descendants("profile").First().Value;
            //ComboboxItem item = new ComboboxItem();
            //item.Text = profile;
            //item.Value = profile.Length - 1;
            //cb_profile.Items.Add(item);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Column6"].Value = "Stopped!";
                dataGridView1.Rows[i].Cells["c_start"].Value = "⯈";
                dataGridView1.Rows[i].Cells["Column6"].Style.ForeColor = Color.Red;
                textBox3.SelectionColor = Color.Red;
                textBox3.AppendText("\r\n[" + DateTime.Now.Hour + ":" + DateTime.Today.Minute + ":" + DateTime.UtcNow.Second + "] " + "Task #" + i + " stopped!");
                textBox3.SelectionColor = Color.Black;
            }
        }
    }

}

