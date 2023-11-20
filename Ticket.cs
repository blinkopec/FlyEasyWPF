using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace integrationWPF
{
    public class Ticket
    {
        public int idRoute {  get; set; }   
        public string Cost { get; set; }
        public string SendPoint { get; set; }   
        public string EndPoint { get; set;}
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime EndDate { get; set; }
        public string Class { get; set; }
        public Ticket(int id,string Cost, string SendPoint, string EndPoint, TimeSpan StartTime, TimeSpan EndTime, DateTime Date, DateTime EndDate, string @class)
        {
            this.idRoute = id;
            this.Cost = Cost;
            this.SendPoint = SendPoint;
            this.EndPoint = EndPoint;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Date = Date;
            this.EndDate = EndDate;
            this.Class = Class;
        }

        public Ticket(int id) 
        {
            using (var context = new integrationWPFEntities())
            {
                Route route = context.Route
                    .Where(b => b.id == id)
                    .Single();

                string send = context.cities
                    .Where(b => b.id == route.sending_point)
                    .Select(b => b.name)
                    .Single();
                string end = context.cities
                    .Where(b => b.id == route.destination)
                    .Select(b => b.name)
                    .Single();
                string getclass = context.@class
                    .Where(b => b.id == route.@class)
                    .Select(b => b.name)    
                    .Single();

                this.idRoute = route.id;
                this.Cost = route.cost.ToString() + "₽";
                this.SendPoint = send;
                this.EndPoint = end;
                this.StartTime = (TimeSpan)route.start_time;
                this.EndTime = (TimeSpan)route.end_time;
                this.Date = (DateTime)route.data;
                this.EndDate = (DateTime)route.return_date;
                this.Class = getclass;
            }
        }
    }
}
