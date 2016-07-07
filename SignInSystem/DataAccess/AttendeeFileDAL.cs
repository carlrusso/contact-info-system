using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignInSystem.Models;
using System.IO;

namespace SignInSystem.DataAccess
{
    public class AttendeeFileDAL : IAttendeeInfoDAL
    {
        private const string attendeeInfoFile = "attendeeList.csv";

        private const int Col_FirstName = 0;
        private const int Col_LastName = 1;
        private const int Col_Email = 2;
        private const int Col_Phone = 3;

        public void SaveInfo(Attendee guest)
        {
            string currentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string fullPath = Path.Combine(currentDirectory, attendeeInfoFile);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    string line = $"{guest.FirstName}|{guest.LastName}|{guest.Email}|{guest.PhoneNumber}";
                    sw.WriteLine(line);
                }

            }
            catch(IOException e)
            {
                throw;
            }

        }

        public List<Attendee> GetAllInfo()
        {
            List<Attendee> allAttendees = new List<Attendee>();

            string currentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string fullPath = Path.Combine(currentDirectory, attendeeInfoFile);

            try
            {
                using(StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] columns = line.Split('|');

                        Attendee guest = new Attendee()
                        {
                            FirstName = columns[Col_FirstName],
                            LastName = columns[Col_LastName],
                            Email = columns[Col_Email],
                            PhoneNumber = columns[Col_Phone]

                        };
                        allAttendees.Add(guest);
                    }

                }

                return allAttendees;
            }
            catch(IOException e)
            {
                throw;
            }

       
        }

    }
}