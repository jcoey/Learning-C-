﻿using System;
using DevExpress.Xpo;

namespace Basics
{

    public class OverloadingOperator : XPLiteObject
    {
        public OverloadingOperator() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public OverloadingOperator(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

    }

}