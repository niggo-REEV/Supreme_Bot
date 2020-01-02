using System;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprm
{

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
    public partial class Billing : UserControl
    {
        public Billing()
        {
            InitializeComponent();
        }
        [System.Flags]
        [System.Runtime.InteropServices.ComVisible(true)]
        [System.Serializable]
        public enum FileAccess { };
        string payment;
        //readonly XmlDocument xmlDoc = new XmlDocument();
        ////readonly XDocument xDoc = XDocument.Load(Application.StartupPath + @"\Billing-Profiles.xml");
        
        

        private void Button3_Click(object sender, EventArgs e)
        {
            if (rb_amex.Checked == true)
            {
                payment = "american_express";
            }
            else if (rb_master.Checked == true)
            {
                payment = "mastercard";
            }
            else if (rb_solo.Checked == true)
            {
                payment = "solo";
            }
            else if (rb_visa.Checked == true)
            {
                payment = "visa";
            }

            if (input_profile.Text.Length >= 1 & input_name.Text.Length >= 1)
            {
                dataGridView2.Rows.Add((Image)io.Properties.Resources.ResourceManager.GetObject(payment), input_profile.Text, "⯈");


                //// Add profile element.
                //XmlNode rootNode = xmlDoc.CreateElement("profiles");
                //xmlDoc.AppendChild(rootNode);

                //XmlNode userNode = xmlDoc.CreateElement("profile");
                //userNode.InnerText = input_profile.Text;
                //rootNode.AppendChild(userNode);
                ////name
                //XmlNode userNode1 = xmlDoc.CreateElement("name");
                //userNode1.InnerText = input_name.Text;
                //rootNode.AppendChild(userNode1);
                ////tel
                //XmlNode userNode2 = xmlDoc.CreateElement("tel");
                //userNode2.InnerText = input_tel.Text;
                //rootNode.AppendChild(userNode2);
                ////street
                //XmlNode userNode3 = xmlDoc.CreateElement("street");
                //userNode3.InnerText = input_street.Text;
                //rootNode.AppendChild(userNode3);
                ////number
                //XmlNode userNode4 = xmlDoc.CreateElement("num");
                //userNode4.InnerText = input_num.Text;
                //rootNode.AppendChild(userNode4);
                ////city
                //XmlNode userNode5 = xmlDoc.CreateElement("city");
                //userNode5.InnerText = input_city.Text;
                //rootNode.AppendChild(userNode5);
                ////zip
                //XmlNode userNode6 = xmlDoc.CreateElement("zip");
                //userNode6.InnerText = input_zip.Text;
                //rootNode.AppendChild(userNode6);
                ////country
                //XmlNode userNode7 = xmlDoc.CreateElement("country");
                //userNode7.InnerText = cb_country.Text;
                //rootNode.AppendChild(userNode7);
                ////payment
                //XmlNode userNode11 = xmlDoc.CreateElement("payment");
                //userNode11.InnerText = payment;
                //rootNode.AppendChild(userNode11);

                //xmlDoc.Save(Application.StartupPath + @"\Billing-Profiles.xml");
            }
            if (input_profile.Text.Length == 0)
            {
                input_profile.BackColor = Color.IndianRed;
            }
            if (input_name.Text.Length == 0)
            {
                input_name.BackColor = Color.IndianRed;
            }
            if (input_tel.Text.Length == 0)
            {
                input_tel.BackColor = Color.IndianRed;
            }
            if (input_street.Text.Length == 0)
            {
                input_street.BackColor = Color.IndianRed;
            }
            if (input_num.Text.Length == 0)
            {
                input_num.BackColor = Color.IndianRed;
            }
            if (input_city.Text.Length == 0)
            {
                input_city.BackColor = Color.IndianRed;
            }
            if (input_zip.Text.Length == 0)
            {
                input_zip.BackColor = Color.IndianRed;
            }
            if (cb_country.Text.Length == 0)
            {
                cb_country.BackColor = Color.IndianRed;
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            //var profile = xDoc.Descendants("profile").First().Value;
            //var payment2 = xDoc.Descendants("payment").First().Value;
            //dataGridView2.Rows.Add((Image)io.Properties.Resources.ResourceManager.GetObject(payment2), profile, "⯈");

        }

        //private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == dataGridView2.Columns["load"].Index && e.RowIndex >= 0)
        //    {

        //        var profile = xDoc.Descendants("profile").First().Value;
        //        var name = xDoc.Descendants("name").First().Value;
        //        var tel = xDoc.Descendants("tel").First().Value;
        //        var street = xDoc.Descendants("street").First().Value;
        //        var num = xDoc.Descendants("num").First().Value;
        //        var city = xDoc.Descendants("city").First().Value;
        //        var zip = xDoc.Descendants("zip").First().Value;
        //        var country = xDoc.Descendants("country").First().Value;
        //        var payment2 = xDoc.Descendants("payment").First().Value;

        //        input_profile.Text = profile;
        //        input_name.Text = name;
        //        input_tel.Text = tel;
        //        input_street.Text = street;
        //        input_num.Text = num;
        //        input_city.Text = city;
        //        input_zip.Text = zip;
        //        cb_country.Text = country;
        //        if (payment2 == "american_express")
        //        {
        //            rb_amex.Checked = true;

        //        }
        //        else if (payment2 == "mastercard")
        //        {
        //            rb_master.Checked = true;
        //        }
        //        else if (payment == "solo")
        //        {
        //            rb_solo.Checked = true;
        //        }
        //        else if (payment == "visa")
        //        {
        //            rb_visa.Checked = true;
        //        }

        //    }
        //}

    }
}
