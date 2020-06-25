using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using module07_TP04.Entities;

namespace module07_TP04.Services
{
    public class TwitterServiceImpl : ITwitterService
    {
        public List<Tweet> TweetList
        {
            get
            {
                return new List<Tweet>()
                {
                     new Tweet(){User = new User() { Email = "email", Password = "password"}, Data ="maximus arcu lectus at lectus", CreatedAt = DateTime.Now},
                    new Tweet(){User = new User() { Email = "email", Password = "password"}, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = DateTime.Now},
                    new Tweet(){User = new User() { Email = "email", Password = "password"}, Data ="Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar, lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae", CreatedAt = DateTime.Now},

                };
            }
        }


        public string Authenticate(User user)
        {
            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(user.Email) || user.Email.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant doit posséder au moins 3 caractères");
            }

            if (String.IsNullOrEmpty(user.Password) || user.Password.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe doit posséder au moins 6 caractères.");
            }

            if (!TweetList.Select(x => x.User).Any(x => x.Email == user.Email && x.Password == user.Password))
            {
                Debug.WriteLine("Pas de user");
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("L'utilisateur n'existe pas.");
            }

            return stringBuilder.ToString();
        }
    }
}
