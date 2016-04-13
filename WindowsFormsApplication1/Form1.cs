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
        class TagNode
        {
            public string tagName { get; set; }
            public string blockType { get; set; }
        }

        List<TagNode> baseAttrList = new List<TagNode>();
        List<TagNode> testAttrList = new List<TagNode>();
        List<TagNode> compareAttrList = new List<TagNode>();

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
            displayTagNodeArrayToTextBox(textBox1, baseAttrList);

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
            displayTagNodeArrayToTextBox(textBox2, testAttrList);

            testCountLabel.Text = testAttrList.Count.ToString() + " block types found";
        }

        private void parseXMLAttr(string XMLFile, List<TagNode> attrList)
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
                if ((attrval != null) && (!attrList.Exists(element => element.blockType == attrval)))
                {
                    TagNode tn = new TagNode { tagName = "p", blockType = attrval };
                    attrList.Add(tn);
                }
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            string attrval;

            // build a 3rd tag list with block types in 2nd file that aren't in 1st file
            // check each block type found in the 2nd (test) XML file
            foreach (TagNode tn in testAttrList)
            {
                // extract just the block type value
                attrval = tn.blockType;
                // search the base list for this block type
                if (!baseAttrList.Exists(element => element.blockType == attrval))
                {
                    // not found and not yet in the diff list, so add it.
                    TagNode newtn = new TagNode { tagName = "p", blockType = attrval };
                    compareAttrList.Add(newtn);
                }
            }

            // now display the new block types in a ListView control
            displayTagNodeArrayToListView(compareListView, compareAttrList);

            compareLabel.Text = compareAttrList.Count.ToString() + " new block types found";
        }

        private void displayTagNodeArrayToTextBox(TextBox tbox, List<TagNode> attrList)
        {
            tbox.Text = "";
            foreach (TagNode tn in attrList)
            {
                tbox.Text += tn.blockType + Environment.NewLine;
            }
        }

        private void displayTagNodeArrayToListView(ListView lv, List<TagNode> attrList)
        {

            lv.Items.Clear();


            foreach (TagNode tn in attrList)
            {
                string[] listRow = { tn.tagName, tn.blockType };
                ListViewItem lvi = new ListViewItem(listRow);
                lv.Items.Add(lvi);
            }
        }
    }
}

