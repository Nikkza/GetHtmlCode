using System;
using System.Windows.Forms;


namespace GetHtmlCode
{
    public partial class Form1 : Form
    {
        private IWebCollector myWebCollector;
        public Form1()
        {
            InitializeComponent();
            listBoxMessage.Visible = false;
            myWebCollector = new WebCollector();
        }

        private static string _conn;

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            listBoxMessage.Items.Clear();
            listBoxMessage.Visible = true;
            var s2 = "";
            s2 = textBoxSearch.Text;
            listBoxMessage.Items.Add($"The word {s2.ToUpper()} becomes {Count.CountStringOccurrences(myWebCollector.Html, textBoxSearch.Text.ToLower())} Times in the Sentence");
        }

        private void ButtonGetHtml_Click(object sender, EventArgs e)
        {
          

            myWebCollector.GetHtmlFromUrlAsync(textBoxUrl.Text);

        }
    }
}
