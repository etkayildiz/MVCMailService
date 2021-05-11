﻿using MVCMailService_0.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMailService_0.DesignPatterns.SingletonPattern
{
    public class DBTool
    {


        DBTool() { }

        static MyContext _dbInstance;

        public static MyContext DBInstance
        {
            get
            {

                if (_dbInstance is null)
                {

                    _dbInstance = new MyContext();

                }

                return _dbInstance;

            }
        }



    }
}