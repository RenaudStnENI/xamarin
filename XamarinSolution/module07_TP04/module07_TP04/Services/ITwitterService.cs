using System;
using System.Collections.Generic;
using System.Text;
using module07_TP04.Entities;

namespace module07_TP04.Services
{
    public interface ITwitterService
    {
        String Authenticate(User user);
        List<Tweet> TweetList { get; }
    }
}
