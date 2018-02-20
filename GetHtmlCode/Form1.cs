using System;
using System.Windows.Forms;


namespace GetHtmlCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxMessage.Visible = false;
        }

        private static string _conn;
        private  void button1_Click(object sender, EventArgs e)
        {
            listBoxMessage.Visible = true;
            var s2 = "";
            s2 = textBoxSearch.Text;
            listBoxMessage.Items.Add($"The word {s2.ToUpper()} becomes {Count.CountStringOccurrences(_conn.ToLower(), textBoxSearch.Text.ToLower())} Times in the Sentence");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IWebCollector myWebCollector = new WebCollector();
            myWebCollector.GetHtmlFromUrlAsync(textBoxUrl.Text);
            _conn = myWebCollector.Html.ToLower();
          

            
        }
    }
}
