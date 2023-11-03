using System.Text;

using FpAssistantCore.Geographical;

namespace FPAssistantSampleAppWf
{
    /// <summary>
    /// Class to handle viewing a map using Microsoft Bing Maps V8 Control on a WebView WinForm control
    /// </summary>
    public class WebViewEngine : GeoMapElementEngine
    {
        public WebViewEngine()
        {
        }

        public static List<GeoMapEngineElement> Create(GeoMapElementCollection geoMapElements)
        {
            WebViewEngine engine = new();
            List<GeoMapEngineElement> newGeoMapElements = engine.CreateGeoMapElements(geoMapElements);
            return newGeoMapElements;
        }

        public override List<GeoMapEngineElement> CreateGeoMapElements(GeoMapElementCollection geoMapElements)
        {
            List<GeoMapEngineElement>? results = base.CreateGeoMapElements(geoMapElements);
            return results;
        }

        /// <summary>
        /// Using Layers in the Bing Maps V8 Control, need to create a new Layer
        /// </summary>
        /// <param name="stringBuilder"></param>
        public static void Initialise(ref StringBuilder stringBuilder)
        {
            stringBuilder.Append("var layer = new Microsoft.Maps.Layer();");
        }

        /// <summary>
        /// Added graphics to layer, so now need to tell map control to Insert layer onto map
        /// </summary>
        /// <param name="stringBuilder"></param>
        public static void Finalise(ref StringBuilder stringBuilder)
        {
            stringBuilder.Append("map.layers.insert(layer);");
        }

        protected override object CreateAction(GeoMapElementActions geoMapElementAction)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoArc(GeoArc geoArc)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoCircle(GeoCircle geoCircle)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoLine(GeoLine geoLine)
        {
            string properties = "{ strokeColor: 'red',strokeThickness: 2}";
            StringBuilder sb = new(@"var map = new Microsoft.Maps.Map(document.getElementById('myMap'), {});");
            sb.Append("");
            sb.Append("var polyline = new Microsoft.Maps.Polyline([");
            sb.Append(string.Format("new Microsoft.Maps.Location({0},{1}),", geoLine.StartCoordinate.Latitude, geoLine.StartCoordinate.Longitude));
            sb.Append(string.Format("new Microsoft.Maps.Location({0},{1})], {2});", geoLine.EndCoordinate.Latitude, geoLine.EndCoordinate.Longitude, properties));
            sb.Append("layer.add(polyline);");
            return sb.ToString();
        }

        protected override object CreateGeoLineString(GeoLineString geoLineString)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoMapIcon(GeoMapIcon geoMapIcon)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoMapImage(GeoMapImage geoMapImage)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoPoint(GeoPoint geoPoint)
        {
            throw new NotImplementedException();
        }

        protected override object CreateGeoPolygon(GeoPolygon geoPolygon)
        {
            throw new NotImplementedException();
        }
    }
}
