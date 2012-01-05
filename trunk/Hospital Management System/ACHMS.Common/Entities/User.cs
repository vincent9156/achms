using System;
using DevExpress.Xpo;

namespace ACHMS.Common.Entities
{

    public class User : XPObject
    {
        public string UserName {
            get { return GetPropertyValue<string>("UserName"); }
            set { SetPropertyValue("UserName", value); }
        }

        public string Digest {
            get { return GetPropertyValue<string>("Digest"); }
            set { SetPropertyValue("Digest", value); }
        }

        public string Salt{
            get { return GetPropertyValue<string>("Salt"); }
            set { SetPropertyValue("Salt", value); }
        }

        #region Constructor
        public User()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public User(Session session)
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