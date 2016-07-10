using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInSystem.DataAccess;
using SignInSystem.Models;

namespace SignInSystem.Tests
{
    class AttendeeStubFileDAL : IAttendeeInfoDAL
    {
        private List<Attendee> cannedAttendees = new List<Attendee>()
        {
            new Attendee { FirstName = "Terry", LastName = "Tate", Email = "terry@officelinebacker.com", PhoneNumber = "1234567890" },
            new Attendee { FirstName = "Mike", LastName = "Ditka", Email = "mike@bears.com", PhoneNumber = "1234567890" }
        };

      

        List<Attendee> IAttendeeInfoDAL.GetAllInfo()
        {
            return cannedAttendees;
        }

        void IAttendeeInfoDAL.SaveInfo(Attendee guest)
        {
            throw new NotImplementedException();
        }
    }
}
