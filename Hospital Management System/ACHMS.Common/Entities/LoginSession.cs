using System;
using DevExpress.Xpo;

namespace ACHMS.Common.Entities
{
    public class LoginSession : XPObject
    {

        public User User {
            get { return GetPropertyValue<User>("User"); }
            set { SetPropertyValue<User>("User", value); }
        }

        #region Constructor
        public LoginSession()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public LoginSession(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        #endregion
    }

}