using System;
using DevExpress.Xpo;

namespace ACHMS.Common.Entities
{

    public class Patient : XPObject
    {
        #region Constructor
        public Patient()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Patient(Session session)
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