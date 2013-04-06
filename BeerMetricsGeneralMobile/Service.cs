using System;
using System.Linq;
using System.Collections.Generic;

namespace BeerMetricsGeneralLibrary
{
	public class Service
	{
		
		List<Beer> _beerList = new List<Beer> ();
		
		public Service ()
		{
			_beerList.Add (new Beer {Name="Beer 1", Scan="078742093963"});
			_beerList.Add (new Beer {Name="Beer 2", Scan="875720001114"});
		}
		
		public Beer LookupBeerFromScanCode (string code)
		{
			var found =_beerList.Where ( b=> b.Scan == code).First ();
			if (found != null)
				return found;
			
			throw new Exception ("Beer Not Found");
		}
	}
}

