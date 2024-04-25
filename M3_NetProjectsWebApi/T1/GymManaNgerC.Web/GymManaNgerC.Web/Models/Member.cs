using System;

namespace GymManaNgerC.Web.Models
{
    public class Member
    {
        public string Name { get; set; }

        public string LasName { get; set; }
        public DateTime BirthDay { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public bool AloowNewsletter { get; set; }

    }
}
