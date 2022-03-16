using Dapper;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace myLabWebApi.Services
{
    public class UserMasterService : IUserMasterService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public Document Document { get; private set; }

        public UserMasterService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public List<ErrorModel> GetError(string fromdate, string todate, int pageNo, int pageSize, string Keyword, string Type)
        {
            var dbPara = new DynamicParameters();
            DateTime fdate = DateTime.ParseExact(fromdate, "dd-MM-yyyy", null);
            DateTime tdate = DateTime.ParseExact(todate, "dd-MM-yyyy", null);
            dbPara.Add("fromdate", Convert.ToDateTime(fdate).ToString("yyyy-MM-dd"), DbType.DateTime);
            dbPara.Add("todate", Convert.ToDateTime(tdate).ToString("yyyy-MM-dd"), DbType.DateTime);
            dbPara.Add("PageNo", pageNo, DbType.Int32);
            dbPara.Add("PageSize", pageSize, DbType.Int32);
            if (Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", Keyword, DbType.String);
            }
            dbPara.Add("Type", Type, DbType.String);
            var data = _MyLabHelper.GetAll<ErrorModel>("[dbo].[uspviewError]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public int Create(UserMasterModel UserMasterDetails)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserName", UserMasterDetails.UserName, DbType.String);
            dbPara.Add("Type", UserMasterDetails.Type, DbType.String);
            dbPara.Add("LabCode", UserMasterDetails.LabCode, DbType.String);
            dbPara.Add("LabID", UserMasterDetails.LabID, DbType.String);
            dbPara.Add("Contact_No", UserMasterDetails.Contact_No, DbType.String);
            dbPara.Add("Email", UserMasterDetails.Email, DbType.String);
            dbPara.Add("Flag", UserMasterDetails.Flag, DbType.Boolean);
            dbPara.Add("Password", UserMasterDetails.Password, DbType.String);
            dbPara.Add("CreatedByint", 1, DbType.Int32);
            dbPara.Add("CreatedDatedatetime", DateTime.Now, DbType.DateTime);
            dbPara.Add("ModifyByint", 1, DbType.Int32);
            dbPara.Add("ModifyDatedatetime", DateTime.Now, DbType.DateTime);

            #region using dapper

            var data = _MyLabHelper.Insert<int>("[dbo].[uspInsertUserMaster]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }

        public long Delete(long id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("IDbint", id, DbType.Int64);
            var data = _MyLabHelper.Execute("[dbo].[uspDeleteUserMaster]", dbPara,
                   commandType: CommandType.StoredProcedure);
            return data;
        }

        public UserMasterModel GetById(long id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("IDbint", id, DbType.Int64);

            #region using dapper

            var data = _MyLabHelper.Get<UserMasterModel>("[dbo].[uspviewUserMasterById]", dbPara,
                    commandType: CommandType.StoredProcedure);
            UserMasterModel users = data;

            UserMasterModel model = new UserMasterModel();
            //model.UserCodetxt = users.UserCodetxt;
            //model.UserNametxt = users.UserNametxt;
            //model.Idbint = users.Idbint;
            //model.UserTypetxt = users.UserTypetxt;
            //model.Mobilevtxt = users.Mobilevtxt;
            //model.Emailvtxt = users.Emailvtxt;
            //model.Divisionvtxt = users.Divisionvtxt;
            //model.IsActivebit = users.IsActivebit;
            //model.Passwordvtxt = EncryptAngularStringAES(Decrypttxt(users.Passwordvtxt));
            //model.IsActivebit = users.IsActivebit;
            //model.ModifyByint = users.ModifyByint;
            //model.ModifyDatedatetime = users.ModifyDatedatetime;
            //model.CreatedByint = users.CreatedByint;
            //model.ParentCodevtxt = users.ParentCodevtxt;
            //model.CreatedDatedatetime = users.CreatedDatedatetime;
            return model;

            #endregion using dapper
        }

        string IUserMasterService.Update(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("IDbint", UserMaster.ID, DbType.Int64);
            dbPara.Add("UserNametxt", UserMaster.UserName, DbType.String);
            dbPara.Add("UserTypetxt", UserMaster.Type, DbType.String);
            dbPara.Add("LabCode", UserMaster.LabCode, DbType.String);
            dbPara.Add("Mobilevtxt", UserMaster.Contact_No, DbType.String);
            dbPara.Add("Email", UserMaster.Email, DbType.String);
            dbPara.Add("Password", UserMaster.Password, DbType.String);
            dbPara.Add("Flag", UserMaster.Flag, DbType.Boolean);
            dbPara.Add("ModifyByint", 1, DbType.Int32);
            dbPara.Add("ModifyDatedatetime", DateTime.Now, DbType.DateTime);

            var data = _MyLabHelper.Update<string>("[dbo].[uspUpdateUserMaster]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        string IUserMasterService.ChangePassword(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("IDbint", UserMaster.ID, DbType.Int64);
            dbPara.Add("Passwordvtxt", UserMaster.Password, DbType.String);
            dbPara.Add("NewPassword", UserMaster.NewPassword, DbType.String);

            var data = _MyLabHelper.Update<string>("[dbo].[uspUpdateUserPassword]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        string IUserMasterService.EditProfile(UserMasterModel UserMaster)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("IDbint", UserMaster.ID, DbType.Int64);
            dbPara.Add("UserNametxt", UserMaster.UserName, DbType.String);
            dbPara.Add("Mobilevtxt", UserMaster.Contact_No, DbType.String);

            var data = _MyLabHelper.Update<string>("[dbo].[uspUpdateUserProfile]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        //public UserMasterModel Login(string usercode, string password)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("usercode", usercode, DbType.String);
        //    dbPara.Add("password", password, DbType.String);
        //    var data = _MyLabHelper.Get<UserMasterModel>("[dbo].[uspviewCheckUser]", dbPara, commandType: CommandType.StoredProcedure);
        //    return data;
        //}

        public List<UserMasterModel> Login(string usercode, string password)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("usercode", usercode, DbType.String);
            dbPara.Add("password", password, DbType.String);
            var data = _MyLabHelper.GetAll<UserMasterModel>("[dbo].[uspviewCheckUser]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public UserMasterModel LoginLogs(string UserCode, string UserName, string UserType, string BrowserName, string IpAddress)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserCode", UserCode, DbType.String);
            dbPara.Add("UserName", UserName, DbType.String);
            dbPara.Add("UserType", UserType, DbType.String);
            dbPara.Add("BrowserName", BrowserName, DbType.String);
            dbPara.Add("IpAddress", IpAddress, DbType.String);
            var data = _MyLabHelper.Get<UserMasterModel>("[dbo].[uspInsertLoginLogs]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long DeleteErrorLog(string DelDate)
        {
            var dbPara = new DynamicParameters();
            DateTime tempDelDate = DateTime.ParseExact(DelDate, "dd-MM-yyyy", null);
            dbPara.Add("DeleteDate", Convert.ToDateTime(tempDelDate).ToString("yyyy-MM-dd"), DbType.String);
            var data = _MyLabHelper.GetAll<Count>("[dbo].[uspDeleteErrorLog]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0].ListCount;
        }

        public int SaveRefreshToken(string usercode, string reftoken)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserIDbint", usercode, DbType.String);
            dbPara.Add("Tokentxt", reftoken, DbType.String);
            dbPara.Add("ExpiryDatedatetime", DateTime.Now.AddDays(1), DbType.DateTime);

            #region using dapper

            var data = _MyLabHelper.Insert<int>("[dbo].[uspInsertRefreshToken]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }

        public string GetRefreshToken(string usercode, string reftoken)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("usercode", usercode, DbType.String);
            dbPara.Add("Tokentxt", reftoken, DbType.String);
            var data = _MyLabHelper.GetAll<RefreshToken>("[dbo].[uspviewgettokenbyUsercode]", dbPara, commandType: CommandType.StoredProcedure);
            return Convert.ToString(data[0].Tokentxt);
        }

        public int DeleteRefreshToken(string usercode, string token)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("usercode", usercode, DbType.String);
            dbPara.Add("token", token, DbType.String);
            var data = _MyLabHelper.Insert<int>("[dbo].[uspdeletetokenbyUsercode]",
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

            dbPara.Add("UserCode", UserMaster.UserName, DbType.String);
            dbPara.Add("EmailID", UserMaster.Email, DbType.String);
            dbPara.Add("NewPassword", UserMaster.NewPassword, DbType.String);
            dbPara.Add("ResetToken", UserMaster.ResetTokenvtxt, DbType.String);

            var data = _MyLabHelper.Update<string>("[dbo].[uspResetUserPassword]",
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

        public List<UserMasterModel> Search(string Keyword)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> UserPaging(int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> GetAllUserMasterForDivisionalAdminSearch(int PageNo, int PageSize, string Keyword)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> GetAllUserMasterByParentCode(string status, string CustomerId, int PageNo, int PageSize, string Keyword)
        {
            throw new NotImplementedException();
        }

        public long GetAllUserMasterCountByParentCode(string status, string CustomerId, string Keyword)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> GetAllUserMasterForDivisionalAdminDownload(string Keyword)
        {
            throw new NotImplementedException();
        }

        public long GetAllUserMasterForDivisionalAdminCount(string Keyword)
        {
            throw new NotImplementedException();
        }

        public List<UserMasterModel> ExportToExcelForParent(string ParentCode, string status, string Keyword)
        {
            throw new NotImplementedException();
        }

        public object GetusermasterSearch(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);

            var data = _MyLabHelper.GetAll<UserMasterModel>("[dbo].[SP_Get_USERMASTER_ALL_DATA]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }



        public long GetusermasterSearchCount(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -2, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<UserMasterModel>("[dbo].[SP_Get_USERMASTER_ALL_DATA]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }



        //public static void databaseFilePut(string varFilePath)
        //{
        //    byte[] file;
        //    using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
        //    {
        //        using (var reader = new BinaryReader(stream))
        //        {
        //            file = reader.ReadBytes((int)stream.Length);
        //        }
        //    }
        //    using (var varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails))
        //    using (var sqlWrite = new SqlCommand("INSERT INTO Raporty (RaportPlik) Values(@File)", varConnection))
        //    {
        //        sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
        //        sqlWrite.ExecuteNonQuery();
        //    }
        //}
        public long InsertUpdateUsermaster(UserMdsignusers Data)
        {





            try
            {

                var dbPara = new DynamicParameters();
                dbPara.Add("@P_ID", 0, DbType.Int32);
                dbPara.Add("@P_UserName", Data.UserName, DbType.String);
                dbPara.Add("@P_Contact_No", Data.Contact_No, DbType.String);
                dbPara.Add("@P_Email", Data.Email, DbType.String);
                dbPara.Add("@P_Password", Data.Password, DbType.String);
                dbPara.Add("@P_Type", Data.Type, DbType.String);
                //if (Data.Type == true)
                //{
                //    dbPara.Add("@P_Type", "A");
                //}
                //else
                //{
                //    dbPara.Add("@P_Type", "U");

                //}
                dbPara.Add("@P_DOB", Data.DOB, DbType.String);
                dbPara.Add("@P_Gender", Data.Gender, DbType.String);
                dbPara.Add("@P_Qualification", Data.Qualification, DbType.String);
                dbPara.Add("@P_City", Data.City, DbType.String);
                dbPara.Add("@P_Area", Data.Area, DbType.String);
                dbPara.Add("@P_Pincode", Data.Pincode, DbType.String);
                dbPara.Add("@P_State", Data.State, DbType.String);
                dbPara.Add("@P_Address", Data.Address, DbType.String);
                dbPara.Add("@P_Age", Data.Age, DbType.String);
                dbPara.Add("@P_RegDate", DateTime.Now, DbType.DateTime);
                dbPara.Add("@P_RowSent", Data.RowSent, DbType.String);
                //dbPara.Add("Flag", Data.Flag, DbType.Boolean);
                dbPara.Add("@P_LabID", Data.LabID, DbType.Int32);
                dbPara.Add("@P_LabName", Data.LabName, DbType.String);
                dbPara.Add("@P_CentrID", Data.CentrID, DbType.Int32);
                dbPara.Add("@P_LabCode", Data.LabCode, DbType.String);
                dbPara.Add("@P_Sys_Date", DateTime.Now, DbType.DateTime);
                dbPara.Add("@P_Userid", Data.Userid, DbType.Int32);
                if (Data.admin == true)
                {
                    dbPara.Add("@P_admin", "A");
                }
                else
                {
                    dbPara.Add("@P_admin", "U");

                }

                dbPara.Add("@P_Company_Id", Data.Company_Id, DbType.Int32);
                if (Data.Flag == true)
                {
                    dbPara.Add("@P_Flag", 1);
                }
                else
                {
                    dbPara.Add("@P_Flag", 0);
                }


                dbPara.Add("@P_Name", Data.Name, DbType.String);
                dbPara.Add("@P_Degree", Data.Degree, DbType.String);
                dbPara.Add("@P_Reg_No", Data.Reg_No, DbType.String);
                dbPara.Add("@P_Consulting", Data.Consulting, DbType.String);

                var fileName = "";
                //var file = Data.FileUpload;
                string folderName = "UploadedFiles";
                if (!string.IsNullOrEmpty("Userreg"))
                {
                    folderName = Path.Combine(folderName, "Userreg");
                }
                folderName = Path.Combine(folderName);
                string pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (Data.FileUpload == null)
                {
                    dbPara.Add("@P_Attachment", Convert.FromBase64String(""), DbType.Binary);
                }
                else
                {
                    var fileName1 = ContentDispositionHeaderValue.Parse(Data.FileUpload.ContentDisposition).FileName.Trim('"');
                    fileName = Data.UserName + "_" + DateTime.Now.Ticks + fileName1;
                    var fullPath = Path.Combine(pathToSave, Data.SavedFileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    byte[] file;


                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {

                            file = reader.ReadBytes((int)stream.Length);
                            dbPara.Add("@P_Attachment", file, DbType.Binary);

                        }
                    }

                }



                var data = _MyLabHelper.Insert<long>("[dbo].[PRC_InsertUpdateUserMaster_NEW_IUD]", dbPara, commandType: CommandType.StoredProcedure);
                return data;



            }
            catch (Exception Ex)
            {
            }
            return 1;


        }


        public UserMdsignusers GetUsermasterUsingId(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);

            var data = _MyLabHelper.GetAll<UserMdsignusers>("[dbo].[SP_GetUsermaster_NEW_DetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }



        public long InsertBlackListMobiles(BlackListMobilesModel_new model)
        {
            long data = 0;

           

                var dbPara = new DynamicParameters();
                dbPara.Add("@P_Addedby", model.Addedby, DbType.Int32);
                dbPara.Add("@P_MenuName", model.MenuName, DbType.String);
                //dbPara.Add("UserId", model.Addedby, DbType.Int32);
                data = _MyLabHelper.Insert<long>("[dbo].[PRC_MENULIST_IUD]",
                             dbPara,
                             commandType: CommandType.StoredProcedure);
                return data;
           
           






        }




        public List<BlackListMobilesModel_new1> GetBlackListMobilesSearch_new(SearchFilters_new model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", model.PageNo, DbType.Int32);
            dbPara.Add("PageSize", model.PageSize, DbType.Int32);
            if (model.Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", model.Keyword, DbType.String);
            }
            var data = _MyLabHelper.GetAll<BlackListMobilesModel_new1>("[dbo].[PRC_MenuName_SP]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }



        public long GetBlackListMobilesSearchCount(SearchFilters model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            if (model.Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", model.Keyword, DbType.String);
            }
            var data = _MyLabHelper.Get<CountModel>("[dbo].[PRC_MenuName_SP]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ListCount;
        }


        public long DeleteBlackListMobiles(int ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -4, DbType.Int32);
            dbPara.Add("PageSize", ID, DbType.Int32);
            dbPara.Add("Keyword", "", DbType.String);
            var data = _MyLabHelper.Get<long>("[dbo].[PRC_MenuName_SP]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }


        public object GetuserrightsSearch(SearchFilters_userid m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Userid", m.Userid, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);

            var data = _MyLabHelper.GetAll<BlackListMobilesModel_new1>("[dbo].[SP_Get_USERRIGHTS_ALL_DATA]", dbPara, commandType: CommandType.StoredProcedure);
           
            if(data.Count==0)
            {
                var dbPara1 = new DynamicParameters();
                dbPara1.Add("PageNo", -3, DbType.Int32);
                dbPara1.Add("PageSize", m.PageSize, DbType.Int32);
                dbPara1.Add("Userid", m.Userid, DbType.Int32);
                dbPara1.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);

                var data1 = _MyLabHelper.GetAll<BlackListMobilesModel_new2>("[dbo].[SP_Get_USERRIGHTS_ALL_DATA]", dbPara1, commandType: CommandType.StoredProcedure);
                return data1.ToList();
            }
            else
            {
                return data.ToList();


            }
        }


        public long GetuserrightsCount(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -2, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<BlackListMobilesModel_new1>("[dbo].[SP_Get_USERRIGHTS_ALL_DATA]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }

        public object GetUserightsDetails_FED(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -3, DbType.Int32);
            dbPara.Add("PageSize",0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);

            var data = _MyLabHelper.GetAll<BlackListMobilesModel_new1>("[dbo].[SP_Get_USERRIGHTS_ALL_DATA]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }



        public long Insertuserrights(GetUserightsDetails_FED2 model)
        {
            long data=0;
            try
            {

                var dbPara = new DynamicParameters();
                for (int i=0;i< model.Value.Count;i++)
                {
                   
                    //string Userid = model.Value[i].Userid.ToString();
                    string MenuName = model.Value[i].MenuName.ToString();
                    string Flag = model.Value[i].Flag.ToString();
                    string Edit = model.Value[i].Edit.ToString();
                    string Delete = model.Value[i].Delete.ToString();
                    //string s = model.Value[i].Delete.ToString();

                    dbPara.Add("@P_ACTION", 'I', DbType.String);
                    dbPara.Add("@P_Userid", model.Userid, DbType.Int32);
                    dbPara.Add("@P_MenuName", Convert.ToString(MenuName), DbType.String);
                    if (Flag == "True")
                    {
                        dbPara.Add("@P_Flag", 1, DbType.Int32);
                    }
                    else
                    {
                        dbPara.Add("P_Flag", 0, DbType.Int32);
                    }
                    if (Edit == "True")
                    {
                        dbPara.Add("@P_Edit", 1, DbType.Int32);
                    }
                    else
                    {
                        dbPara.Add("P_Edit", 0, DbType.Int32);
                    }
                    if (Delete == "True")
                    {
                        dbPara.Add("@P_Delete", 1, DbType.Int32);
                    }
                    else
                    {
                        dbPara.Add("@P_Delete", 0, DbType.Int32);
                    }


                    dbPara.Add("@P_AddedBy", model.AddedBy, DbType.Int32);

                    data = _MyLabHelper.Insert<long>("[dbo].[PRC_InsertUpdateUserrights_IUD]", dbPara, commandType: CommandType.StoredProcedure);

                }



                





            }
            catch (Exception Ex)
            {
            }
            return 1;


        }




        public long Updateuserrights(GetUserightsDetails_FED2 model)
        {
            long data = 0;
            try
            {

                var dbPara = new DynamicParameters();
                for (int i = 0; i < model.Value.Count; i++)
                {

                    //string Userid = model.Value[i].Userid.ToString();
                    string MenuName = model.Value[i].MenuName.ToString();
                    string Flag = model.Value[i].Flag.ToString();
                    string Edit = model.Value[i].Edit.ToString();
                    string Delete = model.Value[i].Delete.ToString();
                    //string s = model.Value[i].Delete.ToString();

                    dbPara.Add("@P_ACTION", 'U', DbType.String);
                    dbPara.Add("@P_Userid", model.Userid, DbType.Int32);
                    dbPara.Add("@P_MenuName", Convert.ToString(MenuName), DbType.String);
                    if (Flag == "True")
                    {
                        dbPara.Add("@P_Flag", 1, DbType.Int32);
                    }
                    else
                    {
                        dbPara.Add("P_Flag", 0, DbType.Int32);
                    }
                    if (Edit == "True")
                    {
                        dbPara.Add("@P_Edit", 1, DbType.Int32);
                    }
                    else
                    {
                        dbPara.Add("P_Edit", 0, DbType.Int32);
                    }
                    if (Delete == "True")
                    {
                        dbPara.Add("@P_Delete", 1, DbType.Int32);
                    }
                    else
                    {
                        dbPara.Add("@P_Delete", 0, DbType.Int32);
                    }


                    dbPara.Add("@P_AddedBy", model.AddedBy, DbType.Int32);

                    data = _MyLabHelper.Insert<long>("[dbo].[PRC_InsertUpdateUserrights_IUD]", dbPara, commandType: CommandType.StoredProcedure);

                }









            }
            catch (Exception Ex)
            {
            }
            return 1;


        }
    }
}