using System;
using DevExpress.Xpo;

namespace ACHMS.Common.Entities
{

    public class Doctor : XPObject
    {
        #region Constructor
        public Doctor()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Doctor(Session session)
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