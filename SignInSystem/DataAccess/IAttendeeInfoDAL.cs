using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInSystem.Models;

namespace SignInSystem.DataAccess
{
    public interface IAttendeeInfoDAL
    {
        void SaveInfo(Attendee guest);
        List<Attendee> GetAllInfo();

    }
}
