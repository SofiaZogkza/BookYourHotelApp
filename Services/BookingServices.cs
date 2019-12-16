using Interfaces;
using System;
using Types;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Web;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Services
{
    public class BookingServices : IBookingServices
    {
        public List<Response> Search(int HotelID, DateTime ArrivalDate)
        {
            var availableHotels = CheckForAvailableHotels(HotelID, ArrivalDate);
            
            return availableHotels;
        }

        private List<Response> CheckForAvailableHotels(int hotelID, DateTime arrivalDate)
        {
            var jsonObject = ParseJsonFile();

            List<Response> yourChoice;
            Hotel yourHotel = new Hotel();
            //List<List<HotelRates>> yourHotelRates = new List<List<HotelRates>>();
            List<HotelRates> yourHotelRates = new List<HotelRates>();

            foreach (var jo in jsonObject)
            {
                List<HotelRates> availableHotelRates = new List<HotelRates>();
                int? availableHotel;

                availableHotelRates =
                    from hr in jo.HotelRates
                    where hr.TargetDay.All(o => o.TargetDay.Date == arrivalDate.Date)
                    select hr;

                //availableHotelRates = jo.HotelRates.Select(x => new x)
                //                                   .Where(x => x.TargetDay.Date == arrivalDate.Date);
                availableHotel = jo.Hotels.Id;

                if (  (availableHotel == hotelID)) // (availableHotelRates.TargetDay.Date != arrivalDate.Date)
                {
                    yourHotel = jo.Hotels;
                    yourHotelRates.Add(jo.HotelRates.FirstOrDefault(x=>x.TargetDay == arrivalDate.Date));
                    
                }
                
            }

            yourChoice = new List<Response>()
            {
                new Response()
                {
                    Hotels = yourHotel,
                    HotelRates = yourHotelRates
                }
            };
            return yourChoice;
        }

        private List<Response> ParseJsonFile()
        {
            // Read file as a string
            string jsonFile = File.ReadAllText(HttpContext.Current.Server.MapPath("~/Resources/hotelsrates.json"));
            // Deserialize string to object
            var jsonObject = JsonConvert.DeserializeObject<List<Response>>(jsonFile);

            return jsonObject;
        }
    }
}
