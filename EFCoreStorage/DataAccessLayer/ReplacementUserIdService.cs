using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ReplacementUserIdService : IUserIdService
    {
        /// <summary>
        /// This is a replacement for the IUserIdService, which is used when no user is logged in.
        /// </summary>
        /// <returns>A new Guid</returns>
        public Guid GetUserId()
        {
            // This is a replacement for the IUserIdService, which is used when no user is logged in.
            return Guid.Empty;
        }
    }
}
