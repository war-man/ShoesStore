namespace CoV.Common.Infrastructure
{
    /// <summary>
    /// Define all Constants
    /// </summary>
    public class Constants
    {
        public const string CommaString = ",";
        public const char Colon = ':';
        public const string PageTitle = "Title";
        public const string Gender = "Gender";
        public const string DateServerFormat = "DateServerFormat";
        public const string DateClientFortmat = "DateClientFortmat";
        public const string Controller = "controller";
        public const string Action = "action";
        public const string AppName = "Xem";
        public const string CacheBuster = "CacheBuster";
        public const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        public const string Ok = "OK";
        public const string UploadDir = "Upload";
        public const string SessionKey = "VshopSession";
        public const string AppSession = ".Vshop.Session";
        public const string FormatName = "{0} {1} {2}";
        public class BasicAuth
        {
            public const string AuthenticationUsername = "Authentication:Username";
            public const string AuthenticationPassword = "Authentication:Password";
            public const string Authorization = "Authorization";
            public const string BasicAuthorization = "Basic Authorization";
            public const string StringType = "string";
            public const string Header = "header";
            public const string Basic = "Basic";
            public const string BasicHeader = "Basic ";
            public const string Iso88591 = "iso-8859-1";
        }

        public class CommonFields
        {
            public const string CreatedBy = "CreatedBy";
            public const string CreatedOn = "CreatedOn";
            public const string UpdatedBy = "UpdatedBy";
            public const string UpdatedOn = "UpdatedOn";
        }
        public class Policy
        {
            public const string Master = "Master";
            public const string Normal = "Normal";
            public const string AdminMaster = "AdminMaster";
            public const string MasterNormal = "MasterNormal";
        }

        public class DateTimeFormat
        {
            public const string YyyyMMdd = "yyyy-MM-dd";
            public const string YyMMdd = "yyMMdd";
            public const string YyyyMmDdHhMmSs = "yyyy/MM/dd HH:mm:ss";
            public const string YyyyMMddHHmmss = "yyyyMMddHHmmss";
            public const string MmDDyyyy = "MM/dd/yyyy";
            public const string DDmmYyyy = "dd/MM/yyyy";
        }
        
        /// <summary>
        /// class define all route in system
        /// </summary>
        public class Route
        {
            public const string ErrorPage = "/error/systemerror";
            public const string NotFound = "/error/pagenotfound";
            public const string AccessDenied = "/error/accessdenied";
            public const string ApiRoute = "/api";
        }

        /// <summary>
        /// Config for swagger
        /// </summary>
        public class Swagger
        {
            public const string Header = "header";
            public const string V1 = "v1";
            public const string CorsPolicy = "CorsPolicy";
        }

        /// <summary>
        /// Define key for appsetting config 
        /// </summary>
        public class Settings
        {
            public const string DefaultCulture = "Cultures:Default";
            public const string OptionCulture = "Cultures:Option";
            public const string PageSize = "Pagination:PageSize";
            public const string LoginExpiredTime = "Login:ExpiredTime";
            public const string ErrorMessage = "ErrorMessage";
            public const string ConnectionString = "ConnectionString";
            public const string DefaultConnection = "DefaultConnection";
            public const string ResourcesDir = "Resources";
            public const string VshopDataAccess = "Vshop.VshopDataAccess";
            public const string EncryptKey = "Encryptor:Key";
            public const string MaxTimezoneTimeHour = "23";
            public const string MaxTimezoneTimeMinute = "59";
            public const double MaxTimezoneTimeHourMinute = 23.99;
            public const string ExpiredSessionTime = "ExpiredSessionTime";
            public const string DefaultUsername = "Admin";
            public const string DefaultPassword = "Admin";

        }

        /// <summary>
        /// Config for logger system
        /// </summary>
        public class Logger
        {
            public const string LogFile = "Logging:LogDir";
            public const string Logging = "Logging";
        }

        public class Pagination
        {
            public const string Start = "start";
            public const string OrderColumn = "order[0][column]";
            public const string OrderDirection = "order[0][dir]";
        }

        public class ClaimName
        {
            public const string UserCode = "UserCode";
            public const string UserName = "UserName";
            public const string AccountId = "AccountId";
            public const string Id = "AccountId";
            public const string Role = "Role";
        }
        public class Fcm
        {
            public const string Key = "Fcm:Key";
            public const string Url = "Fcm:Url";
        }

        public class MailSetting
        {
            public const string DeliveryMethod = "MailSettings:DeliveryMethod";
            public const string From = "MailSettings:From";
            public const string Host = "MailSettings:Host";
            public const string Port = "MailSettings:Port";
            public const string DefaultCredentials = "MailSettings:DefaultCredentials";
            public const string UserName = "MailSettings:UserName";
            public const string Password = "MailSettings:Password";
        }

        public class StoreProcedure
        {
        }

        public class StoreProcedureParam
        {
            
        }

        public class Role
        {
            public const string Admin = "Admin";
            public const string Accountant = "Kế toán";
            public const string Employee = "Nhân viên";
            public const string Shiper = "Shiper";
        }
        
        public class StatusOrder
        {
            public const string XN = "Xác nhận";
            public const string DVC = "Đang Giao";
            public const string HoanHang = "Hoàn Hàng";
            public const string WIN = "Giao thành công";
            public const string DC = "Đang chờ shiper";
            public const string DH = "Đặt hàng";
        }
        
        public class ImageUserDefail
        {
            public const string imageAvatar =
                "002f1d1f-e239-4409-b8e6-72efa2824ba7_photo-1-15611010487262059848050.png";
        }
        
        
        public class  Document
        {
            public const string AccountNotPound = "login with acoount not pound";
            public const string AccountName = "Login with account :";
        }
        
        public const string JwtIssuer = "Jwt:Issuer";
        public const string JwtKey = "Jwt:Key";
        
        public class  ColorProduct
        {
            public const string Red = "RED";
            public const string Blue = "BLUE";
            public const string Green = "GREEN";
            public const string Yellow = "YELLOW";
            public const string Black = "BLACK";
            public const string White = "WHITE";
            public const string Pink = "PINK";
        }

        public class CategoryProduct
        {
            public const string ShoesLong = "Giày cao cổ";
            public const string ShoesCs = "Giày Công sở";
            public const string Shoeshirst = "Giày thấp cổ";
            public const string Giayluoi = "Giày lười";
            public const string Giaythethao = "Giày thể thao";
            public const string GiayDangYeu = "Giày đáng yêu";
            public const string GiayPhongCach = "Giày phong cách";
            public const string GiayDa = "Giày Da";
        }
        
        public class  MakerProduct
        {
            public const string Adidas = "Adidas";
             public const string Nike = "Nike";
             public const string Vans = "Vans";
            public const string Convert = "Convert";           
        }
        public class GenderProduct
        {
            public const string Male = "Nam";    
            public const string Female  = "Nữ";
            public const string UnknownGender  = "Mọi người";
            public const string Baby  = "Em bé";
            
        }
        
        public class  StatusProduct
        {
            public const string Action = "Đang hoạt động";
            public const string Stop = "Tạm đừng";
            
        }
    }
}
