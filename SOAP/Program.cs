using SOAP.Services;
using SoapCore;

namespace SOAP
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddSingleton<IShippingService, ShippingService>();
			builder.Services.AddSoapCore();

			var app = builder.Build();
			app.UseSoapEndpoint<IShippingService>("/Service.asmx", new SoapEncoderOptions());
			app.Run();
		}
	}
}
