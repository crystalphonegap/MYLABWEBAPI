using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using myLabWebApi.Entities;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Security;
using myLabWebApi.Utility;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myLabWebApi.Controllers
{
    //uthorize]
    [Route("[controller]")]
    [ApiController]
    public class UserMasterController : ControllerBase
    {
        private readonly IUserMasterService _userMasterService;
        //private readonly IChecktokenservice _Checktokenservice;
        //private readonly JwtSettings _jwtSettings;
        private readonly ILogger _ILogger;
        private static bool AngularEncryption = true;

        public UserMasterController(IUserMasterService userMasterService, ILogger ILoggerservice)
        {
            _ILogger = ILoggerservice;
            _userMasterService = userMasterService;
            //_jwtSettings = jwtSettings;
            //_Checktokenservice = checktokenservice;
        }

        [HttpGet("GetYear")]
        public IActionResult GetYear()
        {
            try
            {
                DateTime now = DateTime.Today;
                string year = now.ToString("yyyy");
                return Ok(year);
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetUserDetails/{Id}")]
        public IActionResult GetUserDetails(long Id)
        {
            try
            {
                var UserMaster = _userMasterService.GetById(Id);
                return Ok(UserMaster);
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //[HttpGet("GetProfile/{Id}")]
        //public IActionResult GetProfile(long Id)
        //{
        //    try
        //    {
        //        string Token = Request.Headers["Authorization"];
        //        string[] authorize = Token.Split(" ");
        //        if (_Checktokenservice.CheckTokenByID(authorize[1].Trim(), Id))
        //        {
        //            var UserMasterModel = _userMasterService.GetById(Id);
        //            UserMasterModel = new UserMasterModel()
        //            {
        //                Idbint = UserMasterModel.Idbint,
        //                UserCodetxt = UserMasterModel.UserCodetxt,
        //                UserNametxt = UserMasterModel.UserNametxt,
        //                UserTypetxt = UserMasterModel.UserTypetxt,
        //                Divisionvtxt = UserMasterModel.Divisionvtxt,
        //                Mobilevtxt = UserMasterModel.Mobilevtxt,
        //                Emailvtxt = UserMasterModel.Emailvtxt,
        //            };

        //            return Ok(UserMasterModel);
        //        }
        //        else
        //        {
        //            return Ok("Un Authorized User");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest(ex);
        //    }
        //}

        [HttpPost("Create")]
        public ActionResult Create(UserMasterModel model)
        {
            try
            {
                var userMaster = new UserMasterModel()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Type = model.Type,
                    Contact_No = model.Contact_No
                    //ParentCodevtxt = model.ParentCodevtxt,
                    //Emailvtxt = model.Emailvtxt,
                    //IsActivebit = model.IsActivebit,
                    //Passwordvtxt = Encrypttxt(model.Passwordvtxt),
                    //CreatedByint = 1,
                    //CreatedDatedatetime = DateTime.Now,
                    //ModifyByint = 1,
                    //ModifyDatedatetime = DateTime.Now
                };

                return Ok(_userMasterService.Create(userMaster));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPut("Update")]
        public ActionResult Update(UserMasterModel model)
        {
            try
            {
                var userMaster = new UserMasterModel()
                {
                    //Idbint = model.Idbint,
                    //UserCodetxt = model.UserCodetxt,
                    //UserNametxt = model.UserNametxt,
                    //UserTypetxt = model.UserTypetxt,
                    //Divisionvtxt = model.Divisionvtxt,
                    //Mobilevtxt = model.Mobilevtxt,
                    //Emailvtxt = model.Emailvtxt,
                    //Passwordvtxt = Encrypttxt(model.Passwordvtxt),
                    //IsActivebit = model.IsActivebit,
                    //ModifyByint = 1,
                    //ModifyDatedatetime = DateTime.Now
                };

                _userMasterService.Update(userMaster);
                return Ok(userMaster);
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //[HttpPut("EditProfile")]
        //public ActionResult EditProfile(UserMasterModel model)
        //{
        //    try
        //    {
        //        string Token = Request.Headers["Authorization"];
        //        string[] authorize = Token.Split(" ");
        //        if (_Checktokenservice.CheckTokenByID(authorize[1].Trim(), model.Idbint))
        //        {
        //            var userMaster = new UserMasterModel()
        //            {
        //                Idbint = model.Idbint,
        //                UserNametxt = model.UserNametxt,
        //                Mobilevtxt = model.Mobilevtxt,
        //            };
        //            return Ok(_userMasterService.EditProfile(userMaster));
        //        }
        //        else
        //        {
        //            return Ok("Un Authorized User");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest(ex);
        //    }
        //}

        //[HttpPut("ChangePassword")]
        //public ActionResult ChangePassword(UserMasterModel model)
        //{
        //    try
        //    {
        //        string Token = Request.Headers["Authorization"];
        //        string[] authorize = Token.Split(" ");
        //        if (_Checktokenservice.CheckTokenByID(authorize[1].Trim(), model.Idbint))
        //        {
        //            var userMaster = new UserMasterModel()
        //            {
        //                Idbint = model.Idbint,
        //                Passwordvtxt = Encrypttxt(model.Passwordvtxt),
        //                NewPassword = Encrypttxt(model.NewPassword),
        //            };
        //            return Ok(_userMasterService.ChangePassword(userMaster));
        //        }
        //        else
        //        {
        //            return Ok("Un Authorized User");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest(ex);
        //    }
        //}

        [HttpDelete("Delete/{ID}")]
        public IActionResult Delete(long ID)
        {
            try
            {
                _userMasterService.Delete(ID);
                return Ok();
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //[AllowAnonymous]
        //[HttpPost("Refresh")]
        //public IActionResult Refresh(RefreshTokenRequest requesttoken)
        //{
        //    try
        //    {
        //        if (requesttoken.TokenTxt == "undefined" || requesttoken.RefreshTokenTxt == "undefined")
        //        {
        //            return new ObjectResult(new
        //            {
        //                Issue = "Invalid refresh token",
        //            });
        //        }
        //        var principal = GetPrincipalFromExpiredToken(requesttoken.TokenTxt);
        //        var username = principal.Claims.ToList();
        //        var savedRefreshToken = _userMasterService.GetRefreshToken(username[0].Value, requesttoken.RefreshTokenTxt); //retrieve the refresh token from a data store
        //        if (savedRefreshToken != requesttoken.RefreshTokenTxt)

        //            return new ObjectResult(new
        //            {
        //                Issue = "Invalid refresh token",
        //            });
        //        //throw new SecurityTokenException("Invalid refresh token");

        //        var newJwtToken = GenerateToken(principal.Claims);
        //        var newRefreshToken = GenerateRefreshToken();
        //        _userMasterService.DeleteRefreshToken(username[0].Value, requesttoken.RefreshTokenTxt);
        //        _userMasterService.SaveRefreshToken(username[0].Value, newRefreshToken);

        //        return new ObjectResult(new
        //        {
        //            token = newJwtToken,
        //            refreshToken = newRefreshToken
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest(ex);
        //    }
        //}

        private RefreshToken GenerateRefreshToken1()
        {
            RefreshToken refreshToken = new RefreshToken();
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                refreshToken.Tokentxt = Convert.ToBase64String(randomNumber);
            }
            refreshToken.ExpiryDatedatetime = DateTime.UtcNow.AddHours(12);
            return refreshToken;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        //private string GenerateToken(IEnumerable<Claim> claims)
        //{
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

        //    var jwt = new JwtSecurityToken(issuer: "http://localhost:44335",
        //        audience: "MyLabUsers",
        //        claims: claims, //the user's claims, for example new Claim[] { new Claim(ClaimTypes.Name, "The username"), //...
        //        notBefore: DateTime.UtcNow,
        //        expires: DateTime.UtcNow.AddMinutes(20),
        //        signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        //    );

        //    return new JwtSecurityTokenHandler().WriteToken(jwt); //the method is called WriteToken but returns a string
        //}

        //private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        //{
        //    var tokenValidationParameters = new TokenValidationParameters
        //    {
        //        ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
        //        ValidateIssuer = false,
        //        ValidateIssuerSigningKey = true,
        //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
        //        ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
        //    };

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    SecurityToken securityToken;
        //    var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
        //    var jwtSecurityToken = securityToken as JwtSecurityToken;
        //    if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
        //        throw new SecurityTokenException("Invalid token");

        //    return principal;
        //}


        [HttpPost("Login")]
        public IActionResult Login(UserMasterModel userMaster)
        {
            try
            {

                //UserMasterModel usermodel = _userMasterService.Login(userMaster.UserName, userMaster.Password);

                //if (usermodel == null)
                //{
                //    return Ok(StatusCode((int)HttpStatusCode.NotFound, "user not found"));
                //}

                //if (usermodel.UserName != "")
                //{
                //    UserMasterModel model = new UserMasterModel();
                //    model.Type = usermodel.Type;
                //    model.ID = usermodel.ID;
                //    model.LabID = usermodel.LabID;
                //    model.LabName = usermodel.LabName;
                //    model.LabCode = usermodel.LabCode;
                //    model.UserName = usermodel.UserName;
                //    return Ok(model);
                //}
                //else
                //{
                //    return Ok(StatusCode((int)HttpStatusCode.NotFound, "user not found"));
                //}

                return Ok(_userMasterService.Login(userMaster.UserName, userMaster.Password));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        [HttpGet("DeleteErrorLog/{DelDate}")]
        public IActionResult DeleteErrorLog(string DelDate)
        {
            try
            {
                return Ok(_userMasterService.DeleteErrorLog(DelDate));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("EnterLog")]
        [HttpGet("GetError/{fromdate},{todate},{PageNo},{PageSize},{Keyword}")]
        public IActionResult GetError(string fromdate, string todate, int PageNo, int PageSize, string Keyword)
        {
            try
            {
                return Ok(_userMasterService.GetError(fromdate, todate, PageNo, PageSize, Keyword, "List"));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetErrorCount/{fromdate},{todate},{Keyword}")]
        public IActionResult GetErrorCount(string fromdate, string todate, string Keyword)
        {
            try
            {
                return Ok(_userMasterService.GetError(fromdate, todate, 0, 0, Keyword, "count"));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpPost("ResetPassword")]
        public ActionResult ResetPassword(UserMasterModel model)
        {
            try
            {
                var userMaster = new UserMasterModel()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    ResetTokenvtxt = model.ResetTokenvtxt,
                    NewPassword = Encrypttxt(model.NewPassword),
                };
                return Ok(_userMasterService.ResetPassword(userMaster));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        public static string Encrypttxt(string clearText)
        {
            string temptext;
            if (AngularEncryption == true)
            {
                temptext = DecryptAngulartxtAES(clearText);
            }
            else
            {
                temptext = clearText;
            }
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

        public static string DecryptAngulartxtAES(string cipherText)
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

        public static string EncrypAngularttxtAES(string plainText)
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




        [HttpPost("GetusermasterSearch")]
        public IActionResult GetDoctorSearch(SearchFilters m)
        {
            try
            {
                return Ok(_userMasterService.GetusermasterSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpPost("GetusermasterSearchCount")]
        public IActionResult GetDoctorSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_userMasterService.GetusermasterSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("Insertusermaster")]
        public async Task<ActionResult> Insertusermaster([FromForm] UserMdsignusers Data)
        {
            try
            {
                if (Data.FileUpload != null)
                {
                    Data.SavedFileName = await FileUtilityService.UploadedSitePhotoFiles(Data.FileUpload, Data.UserName, "Userreg", null);
                }

                return Ok(_userMasterService.InsertUpdateUsermaster(Data));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateUsermaster")]
        public async Task<ActionResult> UpdateUsermaster([FromForm] UserMdsignusers Data)
        {
            try
            {
                if (Data.FileUpload != null)
                {
                    Data.SavedFileName = await FileUtilityService.UploadedSitePhotoFiles(Data.FileUpload, Data.UserName, "Userreg", null);
                }

                return Ok(_userMasterService.InsertUpdateUsermaster(Data));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetUsermasterDetailsByID/{ID}")]
        public IActionResult GetUsermasterDetailsByID(int ID)
        {
            try
            {
                return Ok(_userMasterService.GetUsermasterUsingId(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        [HttpPost("InsertBlackListMobiles")]
        public ActionResult InsertBlackListMobiles(BlackListMobilesModel_new model)
        {
            try
            {
                return Ok(_userMasterService.InsertBlackListMobiles(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        [HttpPost("GetBlackListMobilesSearch")]
        public ActionResult GetBlackListMobilesSearch(SearchFilters_new model)
        {
            try
            {
                return Ok(_userMasterService.GetBlackListMobilesSearch_new(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpPost("GetBlackListMobilesSearchCount")]
        public ActionResult GetBlackListMobilesSearchCount(SearchFilters model)
        {
            try
            {
                return Ok(_userMasterService.GetBlackListMobilesSearchCount(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        [HttpGet("DeleteBlackListMobiles/{ID}")]
        public ActionResult DeleteBlackListMobiles(int ID)
        {
            try
            {
                return Ok(_userMasterService.DeleteBlackListMobiles(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpPost("GetUserightsDetails")]
        public IActionResult GetuserrightsSearch(SearchFilters_userid m)
        {
            try
            {
                return Ok(_userMasterService.GetuserrightsSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpPost("GetAlluserrightsDetailsCount")]
        public IActionResult GetuserrightsCount(SearchFilters m)
        {
            try
            {
                return Ok(_userMasterService.GetuserrightsCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpPost("GetUserightsDetails_FED")]
        public IActionResult GetUserightsDetails_FED(SearchFilters m)
        {
            try
            {
                return Ok(_userMasterService.GetUserightsDetails_FED(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //[HttpPost("Insertuserrights")]
        //public async Task<ActionResult> Insertuserrights([FromForm] GetUserightsDetails_FED2 model)
        //{
        //    try
        //    {
        //        return Ok(_userMasterService.Insertuserrights(model));
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest(ex);
        //    }
        //}


        [HttpPost("Insertuserrights")]
        public IActionResult Insertuserrights( GetUserightsDetails_FED2 model)
        {
            try
            {
                return Ok(_userMasterService.Insertuserrights(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPut("Updateuserrights")]
        public IActionResult Updateuserrights(GetUserightsDetails_FED2 model)
        {
            try
            {
                return Ok(_userMasterService.Updateuserrights(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("Daily_Username")]
        public IActionResult Daily_Username(SearchFilters m)
        {
            try
            {
                return Ok(_userMasterService.Daily_Username(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
    }
    }