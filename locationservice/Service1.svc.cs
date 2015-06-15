using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using locationservice.Database;
using System.Web.Http.Cors;
namespace locationservice
{
    public class Service1 : myservice
    {
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void json(List<MyLocation> locations)
        {
            if (locations != null)
            {
                if (locations.Count > 0)
                {
                    locationserviceEntities db = new locationserviceEntities();

                    for (int i = 0; i < locations.Count; i++)
                    {
                        location item = new location();
                        item.X = locations[i].X;
                        item.Y = locations[i].Y;
                        item.message =  "[json-method] " + locations[i].message;
                        item.uploadtime = DateTime.Now;
                        item.time = locations[i].time;
                        db.locations.Add(item);
                    }

                    db.SaveChangesAsync();
                }
            }
        }

        public void normalmethod(string x, string y, string message, DateTime time)
        {
            locationserviceEntities db = new locationserviceEntities();
            location item = new location();
            item.X = x;
            item.Y = y;
            item.message = "[normal-method] " + message;
            item.uploadtime = DateTime.Now;
            item.time = time;
            db.locations.Add(item);

            db.SaveChangesAsync();

        }
    }
}
