using System;
using System.Collections.Generic;
using System.Text;
using module09_TP06.Entities;

namespace module09_TP06.Services
{
    public interface ITwitterService
    {
        String Authenticate(User user);
        List<Tweet> TweetList { get; }
    }
}
