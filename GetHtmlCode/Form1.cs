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
            listBoxMessage.Items.Add($"The word {s2.ToUpper()} becomes {Count.CountStringOccurrences(_conn, textBoxSearch.Text)} Times in the Sentence");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            IWebCollector myWebCollector = new WebCollector();
            _conn = await myWebCollector.GetHtmlFromUrlAsync(textBoxUrl.Text);
            var choppedString = _conn.Split('>');

            foreach (var i in choppedString)
            {
                listBox1.Items.Add(i + ">");
            }
        }
    }
}
