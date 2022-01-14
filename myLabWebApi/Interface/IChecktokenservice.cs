﻿namespace myLabWebApi.Interface
{
    public interface IChecktokenservice
    {
        bool CheckToken(string Token, string usercode);

        bool CheckTokenForCustomer(string Token, string usercode);

        bool CheckTokenForCustomerByID(string Token, long id);

        bool CheckTokenByID(string Token, long id);
    }
}