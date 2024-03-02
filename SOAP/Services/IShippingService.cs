using System.ServiceModel;

namespace SOAP.Services
{
	[ServiceContract]
	public interface IShippingService
	{
		[OperationContract]
		decimal CalculateShippingCost(double weight, double distance, ShippingType shippingType);
	}
}
