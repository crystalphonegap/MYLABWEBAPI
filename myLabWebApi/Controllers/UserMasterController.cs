using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using ClosedXML.Excel;
using myLabWebApi.Entities;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using  myLabWebApi.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace  myLabWebApi.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UserMasterController : ControllerBase
    {
        private readonly IUserMasterService _userMasterService;
        private readonly IChecktokenservice _Checktokenservice;
        private readonly JwtSettings _jwtSettings;
        private readonly ILogger _ILogger;
        static bool AngularEncryption = true;
        public UserMasterController(IUserMasterService userMasterService, JwtSettings jwtSettings, ILogger ILoggerservice, IChecktokenservice checktokenservice)
        {
            _ILogger = ILoggerservice;
            _userMasterService = userMasterService;
            _jwtSettings = jwtSettings;
            _Checktokenservice = checktokenservice;
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
                return BadRequest();
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
                return BadRequest();
            }
        }

        [HttpGet("GetProfile/{Id}")]

        public IActionResult GetProfile(long Id)
        {
            try
            {
                string Token = Request.Headers["Authorization"];
                string[] authorize = Token.Split(" ");
                if (_Checktokenservice.CheckTokenByID(authorize[1].Trim(), Id))
                {
                    var UserMasterModel = _userMasterService.GetById(Id);
                    UserMasterModel = new UserMasterModel()
                    {
                        Idbint = UserMasterModel.Idbint,
                        UserCodetxt = UserMasterModel.UserCodetxt,
                        UserNametxt = UserMasterModel.UserNametxt,
                        UserTypetxt = UserMasterModel.UserTypetxt,
                        Divisionvtxt = UserMasterModel.Divisionvtxt,
                        Mobilevtxt = UserMasterModel.Mobilevtxt,
                        Emailvtxt = UserMasterModel.Emailvtxt,
                    };

                    return Ok(UserMasterModel);
                }
                else
                {
                    return Ok("Un Authorized User");
                }
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpPost("Create")]
        public ActionResult Create(UserMasterModel model)
        {
            try
            {
                var userMaster = new UserMasterModel()
                {
                    UserCodetxt = model.UserCodetxt,
                    UserNametxt = model.UserNametxt,
                    UserTypetxt = model.UserTypetxt,
                    Divisionvtxt = model.Divisionvtxt,
                    Mobilevtxt = model.Mobilevtxt,
                    ParentCodevtxt = model.ParentCodevtxt,
                    Emailvtxt = model.Emailvtxt,
                    IsActivebit = model.IsActivebit,
                    Passwordvtxt = Encrypttxt(model.Passwordvtxt),
                    CreatedByint = 1,
                    CreatedDatedatetime = DateTime.Now,
                    ModifyByint = 1,
                    ModifyDatedatetime = DateTime.Now
                };

                return Ok(_userMasterService.Create(userMaster));

            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }


        }

        [HttpPut("Update")]
        public ActionResult Update(UserMasterModel model)
        {
            try
            {
                var userMaster = new UserMasterModel()
                {
                    Idbint = model.Idbint,
                    UserCodetxt = model.UserCodetxt,
                    UserNametxt = model.UserNametxt,
                    UserTypetxt = model.UserTypetxt,
                    Divisionvtxt = model.Divisionvtxt,
                    Mobilevtxt = model.Mobilevtxt,
                    Emailvtxt = model.Emailvtxt,
                    Passwordvtxt = Encrypttxt(model.Passwordvtxt),
                    IsActivebit = model.IsActivebit,
                    ModifyByint = 1,
                    ModifyDatedatetime = DateTime.Now
                };

                _userMasterService.Update(userMaster);
                return Ok(userMaster);

            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }


        }

        [HttpPut("EditProfile")]
        public ActionResult EditProfile(UserMasterModel model)
        {
            try
            {
                string Token = Request.Headers["Authorization"];
                string[] authorize = Token.Split(" ");
                if (_Checktokenservice.CheckTokenByID(authorize[1].Trim(), model.Idbint))
                {
                    var userMaster = new UserMasterModel()
                    {
                        Idbint = model.Idbint,
                        UserNametxt = model.UserNametxt,
                        Mobilevtxt = model.Mobilevtxt,

                    };
                    return Ok(_userMasterService.EditProfile(userMaster));
                }
                else
                {
                    return Ok("Un Authorized User");
                }


            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }


        }

        [HttpPut("ChangePassword")]
        public ActionResult ChangePassword(UserMasterModel model)
        {
            try
            {
                string Token = Request.Headers["Authorization"];
                string[] authorize = Token.Split(" ");
                if (_Checktokenservice.CheckTokenByID(authorize[1].Trim(), model.Idbint))
                {
                    var userMaster = new UserMasterModel()
                    {
                        Idbint = model.Idbint,
                        Passwordvtxt = Encrypttxt(model.Passwordvtxt),
                        NewPassword = Encrypttxt(model.NewPassword),

                    };
                    return Ok(_userMasterService.ChangePassword(userMaster));
                }
                else
                {
                    return Ok("Un Authorized User");
                }


            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }


        }
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
                return BadRequest();
            }
        }
        [AllowAnonymous]
        [HttpPost("Refresh")]
        public IActionResult Refresh(RefreshTokenRequest requesttoken)
        {
            try
            {
                if (requesttoken.TokenTxt == "undefined" || requesttoken.RefreshTokenTxt == "undefined")
                {
                    return new ObjectResult(new
                    {
                        Issue = "Invalid refresh token",
                    });
                }
                var principal = GetPrincipalFromExpiredToken(requesttoken.TokenTxt);
                var username = principal.Claims.ToList();
                var savedRefreshToken = _userMasterService.GetRefreshToken(username[0].Value, requesttoken.RefreshTokenTxt); //retrieve the refresh token from a data store
                if (savedRefreshToken != requesttoken.RefreshTokenTxt)

                    return new ObjectResult(new
                    {
                        Issue = "Invalid refresh token",
                    });
                //throw new SecurityTokenException("Invalid refresh token");

                var newJwtToken = GenerateToken(principal.Claims);
                var newRefreshToken = GenerateRefreshToken();
                _userMasterService.DeleteRefreshToken(username[0].Value, requesttoken.RefreshTokenTxt);
                _userMasterService.SaveRefreshToken(username[0].Value, newRefreshToken);

                return new ObjectResult(new
                {
                    token = newJwtToken,
                    refreshToken = newRefreshToken
                });
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }

        }

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

        private string GenerateToken(IEnumerable<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

            var jwt = new JwtSecurityToken(issuer: "http://localhost:44335",
                audience: "MyLabUsers",
                claims: claims, //the user's claims, for example new Claim[] { new Claim(ClaimTypes.Name, "The username"), //... 
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(20),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(jwt); //the method is called WriteToken but returns a string
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }


        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(UserMasterModel userMaster)
        {
            try
            {
                IActionResult ret;
                UserAuthenticationObject obj = new UserAuthenticationObject();
                SecurityManager security = new SecurityManager(_userMasterService, _jwtSettings);
                obj = security.ValidateUser(userMaster.UserCodetxt, Encrypttxt(userMaster.Passwordvtxt));

                if (obj.IsAuthenticated)
                {
                    if (obj.IDbint != 0)
                    {
                        RefreshToken refreshToken = GenerateRefreshToken1();
                        refreshToken.UserIDbint = obj.UserCodetxt;
                        //userMaster.RefreshTokens.Add(refreshToken);
                        _userMasterService.SaveRefreshToken(refreshToken.UserIDbint, refreshToken.Tokentxt);
                        obj.RefreshToken = refreshToken.Tokentxt;
                        ret = StatusCode((int)HttpStatusCode.OK, obj);
                    }
                    else
                    {
                        ret = StatusCode((int)HttpStatusCode.OK, obj);
                    }

                }
                else
                {

                    ret = StatusCode((int)HttpStatusCode.NotFound, "user not found");
                }
                return ret;
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPost("LoginLogs")]
        public IActionResult LoginLogs(UserMasterModel userMaster)
        {
            try
            {
                return Ok(_userMasterService.LoginLogs(userMaster.UserCodetxt, userMaster.UserNametxt, userMaster.UserTypetxt, userMaster.BrowserName, userMaster.IpAddress));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
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
                return BadRequest();
            }
        }


        [HttpPost("EnterLog")]

        [HttpGet("GetError/{fromdate},{todate},{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetError(string fromdate, string todate, int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_userMasterService.GetError(fromdate, todate, PageNo, PageSize, KeyWord, "List"));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpGet("GetErrorCount/{fromdate},{todate},{KeyWord}")]
        public IActionResult GetErrorCount(string fromdate, string todate, string KeyWord)
        {
            try
            {
                return Ok(_userMasterService.GetError(fromdate, todate, 0, 0, KeyWord, "count"));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
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
                    UserCodetxt = model.UserCodetxt,
                    Emailvtxt = model.Emailvtxt,
                    ResetTokenvtxt = model.ResetTokenvtxt,
                    NewPassword = Encrypttxt(model.NewPassword),
                };
                return Ok(_userMasterService.ResetPassword(userMaster));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
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
    }
}


