using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPAssistantSampleAppWf.Forms.Icao
{
    public partial class BasicIlsForm : Form
    {
        public BasicIlsForm()
        {
            InitializeComponent();
        }

        private async void BasicIlsForm_Load(object sender, EventArgs e)
        {
            await InitializeAsync();

            ResizeWebViewOnPanel2();
        }
        private void BasicIlsForm_Resize(object sender, EventArgs e)
        {
            ResizeWebViewOnPanel2();
        }

        private void ResizeWebViewOnPanel2()
        {
            WebView21.Width = this.Width;
            WebView21.Height = this.Height - SplitContainer.Panel1.Height - 43;
        }

        private async Task InitializeAsync()
        {
            Debug.WriteLine("InitializeAsync");
            await WebView21.EnsureCoreWebView2Async(null);
            Debug.WriteLine("WebView2 Runtime version: " + WebView21.CoreWebView2.Environment.BrowserVersionString);

            //webView2.CoreWebView2.Navigate("https://www.microsoft.com");
            //Debug.WriteLine("after Navigate");

            if ((WebView21 == null) || (WebView21.CoreWebView2 == null))
            {
                Debug.WriteLine("not ready");
            }

            WebView21.NavigateToString(html);

            Debug.WriteLine("after NavigateToString");
        }

        private void ButtonConstruct_Click(object sender, EventArgs e)
        {
            var tt = WebView21.ExecuteScriptAsync(javaScript);
        }


        private readonly string javaScript = @"var map = new Microsoft.Maps.Map(document.getElementById('myMap'), {});
var center = map.getCenter();
var polyline = new Microsoft.Maps.Polyline([
    new Microsoft.Maps.Location(center.latitude + 0.02, center.longitude - 0.08),
    new Microsoft.Maps.Location(center.latitude + 0.02, center.longitude),
    new Microsoft.Maps.Location(center.latitude - 0.02, center.longitude),
    new Microsoft.Maps.Location(center.latitude - 0.02, center.longitude + 0.08)], null);
map.entities.push(polyline);";

        private readonly string html = @"<!DOCTYPE html>
                               <html>
                               <head>
                                  <title></title>
                                  <meta charset=""utf-8"" />
            
                                  <!-- Reference to the Bing Maps SDK -->
                                  <script type='text/javascript' src='http://www.bing.com/api/maps/mapcontrol?callback=GetMap' async defer></script>
                                  <script type='text/javascript'>
                                  function GetMap()
                                  {
                                      var map = new Microsoft.Maps.Map('#myMap', {
                                          credentials: 'P2iDzZSmcbjyOXbKpKpi~lv5pTdgXFmEfyczAEnzCgg~AprXWl9t71nA_08VW4FefTUQKVrlD4YVi0NyRPFG6_bVoLnDU-IsFhuB0ux6pPtC',
                                          center: new Microsoft.Maps.Location(51.50632, -0.12714),
                                          mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                                          zoom: 10
                                      });
                                      //Add your post map load code here.
                                  }
                                  </script>
                               </head>
                               <body>
                                  <div id=""myMap"" style=""position:relative;width:100%;height:100%;""></div>
                               </body>
                               </html>";

    }
}
