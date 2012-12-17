using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using YongShuiGuanLiDBI;

namespace YongShuiGuanLiV2
{

    /// <summary>
    /// 
    /// </summary>
    public class LoginSession
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsLogin()
        {
            return WaterUser != null;
        }


        #region IsAdmin
        /// <summary>
        /// 
        /// </summary>
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        } private bool _isAdmin;
        #endregion //IsAdmin


        #region LoginUserName
        /// <summary>
        /// 
        /// </summary>
        public string LoginUserName
        {
            get
            {
                if (_loginUserName == null)
                {
                    _loginUserName = string.Empty;
                }
                return _loginUserName;
            }
            set
            {
                _loginUserName = value;
            }
        } private string _loginUserName;
        #endregion //LoginUserName

        #region LoginUserID
        /// <summary>
        /// 
        /// </summary>
        public int LoginUserID
        {
            get
            {
                return _loginUserID;
            }
            set
            {
                _loginUserID = value;
            }
        } private int _loginUserID;
        #endregion //LoginUserID

        #region WaterUser
        /// <summary>
        /// 
        /// </summary>
        public YongShuiGuanLiDBI.WaterUserClass WaterUser
        {
            get
            {
                if (_waterUser == null)
                {
                    // TODO: 2011-05-27 
                    //
                    //_waterUser = WaterUserFactory.CreateWaterUserByID(23);

                    FormsAuthentication.SignOut();
                    FormsAuthentication.RedirectToLoginPage();
                    
                }
                return _waterUser;
            }
            set
            {
                _waterUser = value;
            }
        } private YongShuiGuanLiDBI.WaterUserClass _waterUser;
        #endregion //WaterUser

        /// <summary>
        /// 
        /// </summary>
        public UserClass User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        } private UserClass _user;

    }
}
