using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SessionService
{
    [ServiceBehavior(InstanceContextMode= InstanceContextMode.PerSession)]
    public class SessionService : ISessionService
    {
        int _number;

        public int GetCount()
        {
            _number++;
            return _number;
        }
    }
}
