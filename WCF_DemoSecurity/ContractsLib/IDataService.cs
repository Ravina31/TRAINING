﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ContractsLib
{
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        string SayHello(string name);
    }
}