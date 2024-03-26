using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Identity.Model
{
    public class AuthDbContext:IdentityDbContext
    {

        public AuthDbContext(DbContextOptions<AuthDbContext> options): base(options)
        {
            
        }


    }
    }

