using System;
using System.Collections.Generic;
using System.Globalization;

using CyberSource.Api;
using CyberSource.Model;

namespace Cybersource_rest_samples_dotnet.Samples.Reporting
{
	public class GetChargebackSummaries
	{
		public static ReportingV3ChargebackSummariesGet200Response Run()
		{
			// QUERY PARAMETERS
			string organizationId = "testrest";
			var startTime = DateTime.ParseExact("2021-08-01T00:00:00Z", "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
			var endTime = DateTime.ParseExact("2021-09-01T23:59:59Z", "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
			try
			{
				var configDictionary = new Configuration().GetConfiguration();
				var clientConfig = new CyberSource.Client.Configuration(merchConfigDictObj: configDictionary);

				var apiInstance = new ChargebackSummariesApi(clientConfig);
				ReportingV3ChargebackSummariesGet200Response result = apiInstance.GetChargebackSummaries(startTime, endTime, organizationId);
				Console.WriteLine(result);
				return result;
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception on calling the API : " + e.Message);
				return null;
			}
		}
	}
}