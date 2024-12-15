using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage
{
    public interface IFlightDetails
    {
        public void ShowFlightDetails();
        public bool SearchFlight(string dateOfJourney,string source,string destination);
    }
    
}