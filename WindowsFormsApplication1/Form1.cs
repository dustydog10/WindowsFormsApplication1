using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlCompareApp
{
    public partial class Form1 : Form
    {
        List<string> baseAttrList = new List<string>();
        List<string> testAttrList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openBaseXMLButton_Click(object sender, EventArgs e)
        {
            // dialog init code can be moved into forms designer settings
            openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // call the ShowDialog method to show the dialog box.
            // bool? userClickedOK = openFileDialog1.ShowDialog();
            openFileDialog1.ShowDialog();
            // assuming OK clicked

            string XMLFile = openFileDialog1.FileName;
            // bool userClickedOK = true;
            baseLabel.Text = XMLFile;

            // parse base XML file
            parseXMLAttr(XMLFile, baseAttrList);

            // display the list of block_types we have collected
            textBox1.Text = String.Join(Environment.NewLine, baseAttrList);
            baseCountLabel.Text = baseAttrList.Count.ToString() + " block types found";
        }

        private void openTestXMLFile_Click(object sender, EventArgs e)
        {
            // dialog init code can be moved into forms designer settings
            openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // call the ShowDialog method to show the dialog box.
            openFileDialog1.ShowDialog();

            string XMLFile = openFileDialog1.FileName;
            // bool userClickedOK = true;
            testLabel.Text = XMLFile;

            // parse base XML file
            parseXMLAttr(XMLFile, testAttrList);

            // display the list of block_types we have collected
            textBox2.Text = String.Join(Environment.NewLine, testAttrList);
            testCountLabel.Text = testAttrList.Count.ToString() + " block types found";
        }

        private void parseXMLAttr(string XMLFile, List<string> attrList)
        {
            // see previous version for the xmlReader solution
            string srchAttrName = "block_type";
            // XPath string saying "All nodes with attribute we have indicated"
            string selectAllBlockTypes = "//@" + srchAttrName;

            // XmlDocument needs these lines instead of the one used by XmlReader
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XMLFile);

            // set up XPath for all elements with data_block attribute
            XmlNodeList btNodes = xmlDoc.SelectNodes(selectAllBlockTypes);

            // for each node in list
            for (int i = 0; i < btNodes.Count; i++)
            {
                // fetch the attribute value
                string attrval = btNodes[i].Value;
                // if not yet indicated, add to diff list
                if ((attrval != null) && (!attrList.Exists(element => element == attrval)))
                {
                    attrList.Add(attrval);
                }
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            int diffCnt = 0;

            foreach (string attr in testAttrList)
            {
                if (!baseAttrList.Exists(element => element == attr))
                {
                    compareTextBox.Text += attr + Environment.NewLine;
                    diffCnt++;
                }
            }

            compareLabel.Text = diffCnt.ToString() + " new block types found";
        }
    }
}

// original file reader code -- now switch to XMLReader
// check the response
//if (userClickedOK == true)
//{
// Open the selected file to read.
//string text = System.IO.File.ReadAllText(XMLFile);
//textBox1.Text = text;
//}

