using System;

namespace BeerMetricsGeneralLibrary
{
	public class Engine
	{
		static Engine _instance = new Engine ();
		Service _service;

		private Engine ()
		{
			_service = new Service ();
		}

		public static Service Service 
		{
			get
			{
				return _instance._service;
			}
		}
	}
}

