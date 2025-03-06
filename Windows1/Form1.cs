using RazorLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string link = txtLink.Text;

            var engine = new RazorLightEngineBuilder()
                              .UseEmbeddedResourcesProject(typeof(Form1))
                              .UseMemoryCachingProvider()
                              .Build();

            //file .cshtml
            string template = @"";

            //truyền danh sách
            var model = new { Name = "World" };

            string result = await engine.CompileRenderStringAsync("templateKey", template, model);

            // Hiển thị lên webview2
            web_1.NavigateToString(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wbView_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
