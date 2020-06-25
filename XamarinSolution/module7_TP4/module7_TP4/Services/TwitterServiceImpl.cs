using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using module7_TP04.Entities;

namespace module7_TP04.Services
{
    public class TwitterServiceImpl : ITwitterService
    {
        public List<Tweet> Tweets
        {
            get
            {
                User user = new User() { Login = "test", Password = "password"};
                return new List<Tweet>()
                {
                    new Tweet(){User = user, Data ="aaaaaLorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = DateTime.Now},
                    new Tweet(){User = user, Data ="Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar, lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae", CreatedAt = DateTime.Now},
                    new Tweet(){User = user, Data ="maximus arcu lectus at lectus", CreatedAt = DateTime.Now},
                    new Tweet(){User = user, Data ="Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce ipsum nisl, accumsan ac diam sed, scelerisque tempus sapien.", CreatedAt = DateTime.Now},
                    new Tweet(){User = user, Data ="Praesent eu", CreatedAt = DateTime.Now}
                };
            }
        }

        public string Authenticate(User user)
        {
            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(user.Login) || user.Login.Length < 3)
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
                stringBuilder.Append("Le mot de passe doit posséder au moins 6 caractère.");
            }

            if (!Tweets.Select(x => x.User).Any(x => x.Login == user.Login && x.Password == user.Password))
            {
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
