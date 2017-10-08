using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Closer3.Models
{
    public class Closer3DbSetInitializer : DropCreateDatabaseAlways<Closer3DB>
    {
        protected override void Seed(Closer3DB context)
        {
            //  DB.LOCATION SEEDED
            context.Locations.Add(new Location { LocationName = "Chandler", PhoneNumber = "480-785-4537", Email = "chandler@rumbi.com", Address = "885 North 54th St STE #5", City = "Chandler", State = "AZ", ZipCode = "85226" });
            context.Locations.Add(new Location { LocationName = "Mesa", PhoneNumber = "480-539-5593", Email = "mesa@rumbi.com", Address = "1902 South Val Vista Dr, STE 101", City = "Mesa", State = "AZ", ZipCode = "85201" });
            context.Locations.Add(new Location { LocationName = "Franklin", PhoneNumber = "208-375-5864", Email = "franklin@rumbi.com", Address = "8675 West Franklin Rd", City = "Boise", State = "ID", ZipCode = "83709" });
            context.Locations.Add(new Location { LocationName = "Idaho Falls", PhoneNumber = "208-525-9283", Email = "idahofalls@rumbi.com", Address = "2035 South 25th East", City = "Idaho Falls", State = "ID", ZipCode = "83406" });
            context.Locations.Add(new Location { LocationName = "Meridian", PhoneNumber = "208-884-5511", Email = "meridian@rumbi.com", Address = "3327 North Eagle Rd #165", City = "Meridian", State = "ID", ZipCode = "83646" });
            context.Locations.Add(new Location { LocationName = "4th South", PhoneNumber = "801-530-1000", Email = "4thsouth@rumbi.com", Address = "358 South 700 East", City = "Salt Lake City", State = "UT", ZipCode = "84102" });
            context.Locations.Add(new Location { LocationName = "Bountiful", PhoneNumber = "801-294-0176", Email = "bountiful@rumbi.com", Address = "71 North 500 West STE #C", City = "West Bountiful", State = "UT", ZipCode = "84010" });
            context.Locations.Add(new Location { LocationName = "Draper", PhoneNumber = "801-572-2558", Email = "draper@rumbi.com", Address = "148 East 12300 South STE B", City = "Draper", State = "UT", ZipCode = "84020" });
            context.Locations.Add(new Location { LocationName = "Ft. Union", PhoneNumber = "801-568-3201", Email = "ftunion@rumbi.com", Address = "936 East Ft. Union Blvd Unit #66", City = "Midvale", State = "UT", ZipCode = "84047" });
            context.Locations.Add(new Location { LocationName = "Jordan Landing", PhoneNumber = "801-280-9733", Email = "jlanding@rumbi.com", Address = "7251 South Plaza", City = "West Jordan", State = "UT", ZipCode = "84084" });
            context.Locations.Add(new Location { LocationName = "Layton", PhoneNumber = "801-614-5020", Email = "layton@rumbi.com", Address = "748 West Antelope Dr STE A", City = "Layton", State = "UT", ZipCode = "84041" });
            context.Locations.Add(new Location { LocationName = "Lehi", PhoneNumber = "801-756-3783", Email = "lehi@rumbi.com", Address = "987 West 500 North", City = "American Fork", State = "UT", ZipCode = "84003" });
            context.Locations.Add(new Location { LocationName = "Logan", PhoneNumber = "435-753-4300", Email = "logan@rumbi.com", Address = "970 South Highway 89/91", City = "Logan", State = "UT", ZipCode = "84321" });
            context.Locations.Add(new Location { LocationName = "Murray", PhoneNumber = "801-266-5700", Email = "murray@rumbi.com", Address = "5269 South State St", City = "Murray", State = "UT", ZipCode = "84107" });
            context.Locations.Add(new Location { LocationName = "Orem", PhoneNumber = "801-655-1164", Email = "orem@rumbi.com", Address = "299 East University Pkwy", City = "Orem", State = "UT", ZipCode = "84058" });
            context.Locations.Add(new Location { LocationName = "Provo", PhoneNumber = "801-607-1120", Email = "provo@rumbi.com", Address = "62 West Bulldog Blvd STE 104", City = "Provo", State = "UT", ZipCode = "84602" });
            context.Locations.Add(new Location { LocationName = "Riverdale", PhoneNumber = "801-392-4440", Email = "riverdale@rumbi.com", Address = "41943 Riverdale Rd", City = "Riverdale", State = "UT", ZipCode = "84405" });
            context.Locations.Add(new Location { LocationName = "Sandy", PhoneNumber = "801-523-3610", Email = "sandy@rumbi.com", Address = "10365 South State St", City = "Sandy", State = "UT", ZipCode = "84070" });
            context.Locations.Add(new Location { LocationName = "St.George", PhoneNumber = "435-429-1895", Email = "stgeorge@rumbi.com", Address = "740 West Telegraph St", City = "St George", State = "UT", ZipCode = "84780" });
            context.Locations.Add(new Location { LocationName = "Sugarhouse", PhoneNumber = "801-485-2277", Email = "sugarhouse@rumbi.com", Address = "675 East 2100 South", City = "Salt Lake City", State = "UT", ZipCode = "84106" });
            context.Locations.Add(new Location { LocationName = "West Valley", PhoneNumber = "801-968-1537", Email = "westvalley@rumbi.com", Address = "3603 South 2700 West", City = "West Valley", State = "UT", ZipCode = "84119" });
            //  DB.LOCATION END

            //  DB.POSITION SEEDED
            context.Positions.Add(new Position { PositionTitle = "Super User" });
            context.Positions.Add(new Position { PositionTitle = "Corporate Admin" });
            context.Positions.Add(new Position { PositionTitle = "Corporate Restricted" });
            context.Positions.Add(new Position { PositionTitle = "Maintanence" });
            context.Positions.Add(new Position { PositionTitle = "Director" });
            context.Positions.Add(new Position { PositionTitle = "Regional" });
            context.Positions.Add(new Position { PositionTitle = "General Manager" });
            context.Positions.Add(new Position { PositionTitle = "Asst General Manager" });
            context.Positions.Add(new Position { PositionTitle = "Kitchen Manager" });
            context.Positions.Add(new Position { PositionTitle = "Shift Lead" });
            context.Positions.Add(new Position { PositionTitle = "Prep Cook" });
            context.Positions.Add(new Position { PositionTitle = "Line Cook" });
            context.Positions.Add(new Position { PositionTitle = "Cashier" });
            context.Positions.Add(new Position { PositionTitle = "Lobby" });
            //  DB.POSITION END

            base.Seed(context);
        }
    }
}