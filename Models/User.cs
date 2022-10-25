using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Yad2.Models
{
    public class User : IdentityUser
    {
        public List<Message> userMessages;
    }
}
