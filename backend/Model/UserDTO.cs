﻿namespace backend.Model
{
    public class UserDTO : UserAuthentication
    {
        public string idUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; }
        public byte typeUser { get; set; }
        public int rating { get; set; }
    }
}
