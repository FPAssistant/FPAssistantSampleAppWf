﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FpAssistantCore.General;
using FpAssistantCore.Geographical;
using FpAssistantCore.IcaoPansOps;

namespace FPAssistantSampleAppWf.Forms.Icao
{
    /// <summary>
    /// Form to display the parameters to construct an ICAO Basic ILS and a map to show the surfaces constructed
    /// </summary>
    /// <remarks>https://weblog.west-wind.com/posts/2021/Jan/26/Chromium-WebView2-Control-and-NET-to-JavaScript-Interop-Part-2</remarks>
    public partial class BasicIlsForm : Form
    {
        // Start coordinate for WebView map - Central London
        private static readonly GeoCoordinateBasic startGeoCoordinate = new GeoCoordinateBasic(51.50632, -0.12714);

        public BasicIlsForm()
        {
            InitializeComponent();

            TextBoxLatitude.Text = startGeoCoordinate.Latitude.ToString();
            TextBoxLongitude.Text = startGeoCoordinate.Longitude.ToString();
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
            WebView21.Width = Width;
            WebView21.Height = Height - SplitContainer.Panel1.Height - 43;
        }

        private async Task InitializeAsync()
        {
            Debug.WriteLine("InitializeAsync");
            await WebView21.EnsureCoreWebView2Async(null);
            Debug.WriteLine("WebView2 Runtime version: " + WebView21.CoreWebView2.Environment.BrowserVersionString);

            if ((WebView21 == null) || (WebView21.CoreWebView2 == null))
            {
                Debug.WriteLine("not ready!");
                return;
            }

            WebView21.NavigateToString(html);
        }

        private async void ButtonConstruct_Click(object sender, EventArgs e)
        {
            #region Latitude / Longitude
            (bool status, double latitude) = Utilities.ConvertStringToDouble(TextBoxLatitude.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude value!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }
            (status, double longitude) = Utilities.ConvertStringToDouble(TextBoxLongitude.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude value!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }
            #endregion

            (status, double bearing) = Utilities.ConvertStringToDouble(TextBoxBearing.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Bearing value!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            (status, double elevation) = Utilities.ConvertStringToDouble(TextBoxElevation.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Bearing value!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            Cursor = Cursors.WaitCursor;
            BasicIlsSurfaces basicIlsSurface = new(FpAssistantCore.GeneralAviation.CriteriaUnits.Si)
            {

                BasePoint = new GeoCoordinate(latitude, longitude),
                DirectionOfFlight = new CompassBearing(bearing),
                HeightMSL = new LinearDistance(elevation, LinearDistanceUnits.Metres)
            };
            basicIlsSurface.DirectionOfFlight = new CompassBearing(bearing);

            GeoMapElementCollection geoMapElementCollection = await Task.Run(() =>
            {
                return basicIlsSurface.CreateGeographicalGeometry(CoordinateSystems.FindByMapProjection(MapProjections.UtmWgs84), GraphicalRepresentation.Lines);
            });

            List<GeoMapEngineElement> geoMapEngineElements = WebViewEngine.Create(geoMapElementCollection);

            StringBuilder javaScript = new();
            WebViewEngine.Initialise(ref javaScript);
            foreach (GeoMapEngineElement geoMapEngineElement in geoMapEngineElements)
            {
                if (geoMapEngineElement.EngineObject is string mapElement)
                {
                    javaScript.Append(mapElement);
                }
            }
            WebViewEngine.Zoom(ref javaScript, startGeoCoordinate, 10);  
            WebViewEngine.Finalise(ref javaScript);

            _ = WebView21.ExecuteScriptAsync(javaScript.ToString());
            Cursor = Cursors.Default;
        }

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
                                          credentials: 'Your Bing Maps API key here',
                                          center: new Microsoft.Maps.Location(" + startGeoCoordinate.Latitude.ToString() + @"," + startGeoCoordinate.Longitude.ToString() +
                                          @"), mapTypeId: Microsoft.Maps.MapTypeId.aerial,
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

        private void ButtonSaveToGml_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
        }
    }
}