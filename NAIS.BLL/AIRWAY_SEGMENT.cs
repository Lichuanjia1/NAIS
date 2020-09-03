using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAIS.Lib;
using NAIS.Model;

namespace NAIS.BLL
{
    public partial class AIRWAY_SEGMENT
    {
        #region BasicMethod
        public List<Model.AIRWAY_SEGMENT> GetModelBySegments(List<Model.SEGMENT> segments,bool cal_center=false)
        {
            List<Model.AIRWAY_SEGMENT> aIRWAY_SEGMENTs = new List<Model.AIRWAY_SEGMENT>();
            List<Model.AIRWAY_POINT0> aIRWAY_POINT0s = new AIRWAY_POINT0().GetModelList("");
            segments.ForEach(p =>
            {
                Model.AIRWAY_POINT0 point1 = aIRWAY_POINT0s.AsEnumerable().Where(q => q.AIRWAY_POINT_ID == p.AIRWAY_POINT1).SingleOrDefault();
                Model.AIRWAY_POINT0 point2 = aIRWAY_POINT0s.AsEnumerable().Where(q => q.AIRWAY_POINT_ID == p.AIRWAY_POINT2).SingleOrDefault();
                Model.AIRWAY_SEGMENT airway_segment = new Model.AIRWAY_SEGMENT(p, point1, point2);
                if (cal_center == true)
                {
                    airway_segment.Centerpoint = new BLL.AIRWAY_SEGMENT().Cal_Center_Point(point1, point2);
                    airway_segment.Trans_angle = new BLL.AIRWAY_SEGMENT().Cal_Trans_Angle(point1, point2);
                }
                aIRWAY_SEGMENTs.Add(airway_segment);
            });
            Convert_Lng_Lat_Of_Model(aIRWAY_SEGMENTs);
            return aIRWAY_SEGMENTs;
        }
        #endregion
        #region ExtensionMethod
        public static void Convert_Lng_Lat_Of_Model(List<NAIS.Model.AIRWAY_SEGMENT> list)
        {
            list.ForEach(p =>
            {
                /*
                 *方法体
                 */
                p.Point1.LATITUDE = Latitude.Parse(p.Point1.LATITUDE);
                p.Point1.LONGITUDE = Longitude.Parse(p.Point1.LONGITUDE);
                p.Point2.LATITUDE = Latitude.Parse(p.Point2.LATITUDE);
                p.Point2.LONGITUDE = Longitude.Parse(p.Point2.LONGITUDE);
            });
        }
        public string[] Cal_Center_Point(IMarker point1,IMarker point2)
        {
            string center_lon = Longitude.Parse(((Convert.ToDouble(point1.LONGITUDE) + Convert.ToDouble(point2.LONGITUDE)) / 2).ToString());
            string center_lat = Latitude.Parse(((Convert.ToDouble(point1.LATITUDE) + Convert.ToDouble(point2.LATITUDE)) / 2).ToString());
            return new string[2] { center_lon, center_lat };
        }
        public double Cal_Trans_Angle(IMarker point1, IMarker point2)
        {
            double rate = (Convert.ToDouble(point1.LATITUDE) - Convert.ToDouble(point2.LATITUDE))/
                (Convert.ToDouble(point1.LONGITUDE) - Convert.ToDouble(point2.LONGITUDE));
            double rad_angle = Math.Atan(Math.Abs(rate));
            return rad_angle * 180 / Math.PI;
        }
        #endregion
    }
}
