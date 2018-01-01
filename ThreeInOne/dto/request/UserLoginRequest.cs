using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThreeInOne.dto.request
{
    /// <summary>
    /// The user login request.
    /// </summary>
    public class UserLoginRequest: BaseRequest
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }
        public string password { get; set; }
        public int client { get; set; }

        public UserLoginRequest(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.client = 1;
            this.method = RestSharp.Method.POST;
            this.router = "/user/login";
        }
    }
}