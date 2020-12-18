using CustomerPortalWebApi.Entities;
using CustomerPortalWebApi.Interface;
using CustomerPortalWebApi.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace CustomerPortalWebApi.Services
{
    public class UserMasterService : IUserMasterService
    {


        private readonly IConfiguration _config;
        private readonly ICustomerPortalHelper _customerPortalHelper;
        private readonly ILogger _ILogger;
        public UserMasterService(ICustomerPortalHelper customerPortalHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _customerPortalHelper = customerPortalHelper;
        }

        public List<ErrorModel> GetError(string fromdate, string todate, int pageNo, int pageSize, string KeyWord, string Type)
        {
            var dbPara = new DynamicParameters();
            DateTime fdate = DateTime.ParseExact(fromdate, "dd-MM-yyyy", null);
            DateTime tdate = DateTime.ParseExact(todate, "dd-MM-yyyy", null);
            dbPara.Add("fromdate", Convert.ToDateTime(fdate).ToString("yyyy-MM-dd"), DbType.DateTime);
            dbPara.Add("todate", Convert.ToDateTime(tdate).ToString("yyyy-MM-dd"), DbType.DateTime);
            dbPara.Add("PageNo", pageNo, DbType.Int32);
            dbPara.Add("PageSize", pageSize, DbType.Int32);
            if (KeyWord == "NoSearch")
            {
                dbPara.Add("KeyWord", "", DbType.String);
            }
            else
            {
                dbPara.Add("KeyWord", KeyWord, DbType.String);
            }
            dbPara.Add("Type", Type, DbType.String);
            var data = _customerPortalHelper.GetAll<ErrorModel>("[dbo].[uspviewError]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public int Create(UserMasterModel UserMasterDetails)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserCodetxt", UserMasterDetails.UserCodetxt, DbType.String);
            dbPara.Add("UserNametxt", UserMasterDetails.UserNametxt, DbType.String);
            dbPara.Add("UserTypetxt", UserMasterDetails.UserTypetxt, DbType.String);
            dbPara.Add("ParentCodevtxt", UserMasterDetails.ParentCodevtxt, DbType.String);
            dbPara.Add("Divisionvtxt", UserMasterDetails.Divisionvtxt, DbType.String);
            dbPara.Add("Mobilevtxt", UserMasterDetails.Mobilevtxt, DbType.String);
            dbPara.Add("Emailvtxt", UserMasterDetails.Emailvtxt, DbType.String);
            dbPara.Add("IsActivebit", UserMasterDetails.IsActivebit, DbType.Boolean);
            dbPara.Add("Passwordvtxt", UserMasterDetails.Passwordvtxt, DbType.String);
            dbPara.Add("CreatedByint", 1, DbType.Int32);
            dbPara.Add("CreatedDatedatetime", DateTime.Now, DbType.DateTime);
            dbPara.Add("ModifyByint", 1, DbType.Int32); 
            dbPara.Add("ModifyDatedatetime", DateTime.Now, DbType.DateTime);

            #region using dapper  
            var data = _customerPortalHelper.Insert<int>("[dbo].[uspInsertUserMaster]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        public long Delete(long id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("IDbint", id, DbType.Int64);
            var data = _customerPortalHelper.Execute("[dbo].[uspDeleteUserMaster]", dbPara,
                   commandType: CommandType.StoredProcedure);
            return data;
        }

        public UserMasterModel GetById(long id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("IDbint", id, DbType.Int64);
            #region using dapper  
            var data = _customerPortalHelper.Get<UserMasterModel>("[dbo].[uspviewUserMasterById]", dbPara,
                    commandType: CommandType.StoredProcedure);
            UserMasterModel users = data;

            UserMasterModel model = new UserMasterModel();
            model.UserCodetxt = users.UserCodetxt;
            model.UserNametxt = users.UserNametxt;
            model.Idbint = users.Idbint;
            model.UserTypetxt = users.UserTypetxt;
            model.Mobilevtxt = users.Mobilevtxt;
            model.Emailvtxt = users.Emailvtxt;
            model.Divisionvtxt = users.Divisionvtxt;
            model.IsActivebit = users.IsActivebit;
            model.Passwordvtxt = EncryptAngularStringAES( Decrypttxt(users.Passwordvtxt));
            model.IsActivebit = users.IsActivebit;
            model.ModifyByint = users.ModifyByint;
            model.ModifyDatedatetime = users.ModifyDatedatetime;
            model.CreatedByint = users.CreatedByint;
            model.ParentCodevtxt = users.ParentCodevtxt;
            model.CreatedDatedatetime = users.CreatedDatedatetime;
            return model;
            #endregion

        }
       
        string IUserMasterService.Update(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("IDbint", UserMaster.Idbint, DbType.Int64);
            dbPara.Add("UserCodetxt", UserMaster.UserCodetxt, DbType.String);
            dbPara.Add("UserNametxt", UserMaster.UserNametxt, DbType.String);
            dbPara.Add("UserTypetxt", UserMaster.UserTypetxt, DbType.String);
            dbPara.Add("Divisionvtxt", UserMaster.Divisionvtxt, DbType.String);
            dbPara.Add("Mobilevtxt", UserMaster.Mobilevtxt, DbType.String);
            dbPara.Add("Emailvtxt", UserMaster.Emailvtxt, DbType.String);
            dbPara.Add("Passwordvtxt", UserMaster.Passwordvtxt, DbType.String);
            dbPara.Add("IsActivebit", UserMaster.IsActivebit, DbType.Boolean);
            dbPara.Add("ModifyByint", 1, DbType.Int32);
            dbPara.Add("ModifyDatedatetime", DateTime.Now, DbType.DateTime);


            var data = _customerPortalHelper.Update<string>("[dbo].[uspUpdateUserMaster]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }
        string IUserMasterService.ChangePassword(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("IDbint", UserMaster.Idbint, DbType.Int64);
            dbPara.Add("Passwordvtxt", UserMaster.Passwordvtxt, DbType.String);
            dbPara.Add("NewPassword", UserMaster.NewPassword, DbType.String);

            var data = _customerPortalHelper.Update<string>("[dbo].[uspUpdateUserPassword]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        string IUserMasterService.EditProfile(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("IDbint", UserMaster.Idbint, DbType.Int64);
            dbPara.Add("UserNametxt", UserMaster.UserNametxt, DbType.String);
            dbPara.Add("Mobilevtxt", UserMaster.Mobilevtxt, DbType.String);

            var data = _customerPortalHelper.Update<string>("[dbo].[uspUpdateUserProfile]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        public UserMasterModel Login(string usercode, string password)
        {
           
                var dbPara = new DynamicParameters();
                dbPara.Add("usercode", usercode, DbType.String);
                dbPara.Add("password", password, DbType.String);
                var data = _customerPortalHelper.Get<UserMasterModel>("[dbo].[uspviewCheckUser]", dbPara, commandType: CommandType.StoredProcedure);
                return data;
           
           
        }

        public UserMasterModel LoginLogs(string UserCode, string UserName, string UserType, string BrowserName, string IpAddress)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("UserCode", UserCode, DbType.String);
            dbPara.Add("UserName", UserName, DbType.String);
            dbPara.Add("UserType", UserType, DbType.String);
            dbPara.Add("BrowserName", BrowserName, DbType.String);
            dbPara.Add("IpAddress", IpAddress, DbType.String);
            var data = _customerPortalHelper.Get<UserMasterModel>("[dbo].[uspInsertLoginLogs]", dbPara, commandType: CommandType.StoredProcedure);
            return data;


        }
       
        public long DeleteErrorLog(string DelDate)
        {

            var dbPara = new DynamicParameters();
            DateTime tempDelDate = DateTime.ParseExact(DelDate, "dd-MM-yyyy", null);
            dbPara.Add("DeleteDate", Convert.ToDateTime(tempDelDate).ToString("yyyy-MM-dd"), DbType.String);
            var data = _customerPortalHelper.GetAll<Count>("[dbo].[uspDeleteErrorLog]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0].ListCount;
        }

        public int SaveRefreshToken(string usercode, string reftoken)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserIDbint", usercode, DbType.String);
            dbPara.Add("Tokentxt", reftoken, DbType.String);
            dbPara.Add("ExpiryDatedatetime", DateTime.Now.AddDays(1), DbType.DateTime);
            #region using dapper  
            var data = _customerPortalHelper.Insert<int>("[dbo].[uspInsertRefreshToken]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        public string GetRefreshToken(string usercode, string reftoken)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("usercode", usercode, DbType.String);
            dbPara.Add("Tokentxt", reftoken, DbType.String);
            var data = _customerPortalHelper.GetAll<RefreshToken>("[dbo].[uspviewgettokenbyUsercode]", dbPara, commandType: CommandType.StoredProcedure);
            return Convert.ToString(data[0].Tokentxt);
        }

        public int DeleteRefreshToken(string usercode, string token)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("usercode", usercode, DbType.String);
            dbPara.Add("token", token, DbType.String);
            var data = _customerPortalHelper.Insert<int>("[dbo].[uspdeletetokenbyUsercode]",
                           dbPara,
                           commandType: CommandType.StoredProcedure);
            return data;
        }
       
        public static string Encrypttxt(string clearText)
        {

            string temptext = DecryptAngularStringAES(clearText);
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(temptext);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    temptext = Convert.ToBase64String(ms.ToArray());
                }
            }
            return temptext;
        }

        public static string Decrypttxt(string cipherText)
        {

            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string DecryptAngularStringAES(string cipherText)
        {
            var keybytes = Encoding.UTF8.GetBytes("4512631236589784");
            var iv = Encoding.UTF8.GetBytes("4512631236589784");

            var encrypted = Convert.FromBase64String(cipherText);
            var decriptedFromJavascript = DecryptStringFromBytes(encrypted, keybytes, iv);
            return decriptedFromJavascript;
        }
        private static string DecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (var rijAlg = new RijndaelManaged())
            {
                //Settings
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.FeedbackSize = 128;

                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a decrytor to perform the stream transform.
                var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                try
                {
                    // Create the streams used for decryption.
                    using (var msDecrypt = new MemoryStream(cipherText))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {

                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                // Read the decrypted bytes from the decrypting stream
                                // and place them in a string.
                                plaintext = srDecrypt.ReadToEnd();

                            }

                        }
                    }
                }
                catch
                {
                    plaintext = "keyError";
                }
            }

            return plaintext;
        }

        public static string EncryptAngularStringAES(string plainText)
        {
            var keybytes = Encoding.UTF8.GetBytes("4512631236589784");
            var iv = Encoding.UTF8.GetBytes("4512631236589784");

            var encryoFromJavascript = EncryptStringToBytes(plainText, keybytes, iv);
            return Convert.ToBase64String(encryoFromJavascript);
        }

        private static byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            byte[] encrypted;
            // Create a RijndaelManaged object
            // with the specified key and IV.
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.FeedbackSize = 128;

                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a decrytor to perform the stream transform.
                var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        string IUserMasterService.ResetPassword(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("UserCode", UserMaster.UserCodetxt, DbType.String);
            dbPara.Add("EmailID", UserMaster.Emailvtxt, DbType.String);
            dbPara.Add("NewPassword", UserMaster.NewPassword, DbType.String);
            dbPara.Add("ResetToken", UserMaster.ResetTokenvtxt, DbType.String);

            var data = _customerPortalHelper.Update<string>("[dbo].[uspResetUserPassword]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        public long UserCount()
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> UserPaging(int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> GetAllUserMasterForDivisionalAdminSearch(int PageNo, int PageSize, string KeyWord)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> GetAllUserMasterByParentCode(string status, string CustomerId, int PageNo, int PageSize, string KeyWord)
        {
            throw new NotImplementedException();
        }

        public long GetAllUserMasterCountByParentCode(string status, string CustomerId, string KeyWord)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> GetAllUserMasterForDivisionalAdminDownload(string KeyWord)
        {
            throw new NotImplementedException();
        }

        public long GetAllUserMasterForDivisionalAdminCount(string KeyWord)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> ExportToExcelForParent(string ParentCode, string status, string KeyWord)
        {
            throw new NotImplementedException();
        }
    }
}
