namespace ThreeInOne.dto.response
{
    using System;

    using ThreeInOne.model;

    class UserLoginResponse
    {
        public String token { get; set; }
        public User user { get; set; }
    }
}