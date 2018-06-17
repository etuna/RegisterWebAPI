using SeatyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seaty
{


    public class SeatySecurity
    {


        public static bool Login(string username, string password)
        {
            using (CinemaSeatingEntities entities = new CinemaSeatingEntities())
            {
                return entities.Users.Any(user => (user.username == username && user.password == password));
            }
        }

    }



}