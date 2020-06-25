using System;
using System.Collections.Generic;
using System.Text;
using module7_TP04.Entities;

namespace module7_TP04.Services
{
    public interface ITwitterService
    {
        String Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
