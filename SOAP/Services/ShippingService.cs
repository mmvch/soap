namespace SOAP.Services
{
	public class ShippingService : IShippingService
	{
		public decimal CalculateShippingCost(double weight, double distance, ShippingType shippingType)
		{
			if (weight <= 0)
			{
				throw new ArgumentException("Weight must be greater than zero.");
			}

			if (distance <= 0)
			{
				throw new ArgumentException("Distance must be greater than zero.");
			}

			if (shippingType == ShippingType.None)
			{
				throw new ArgumentException("Shipping type must be specified.");
			}

			decimal cost = (decimal)(weight * distance * (int)shippingType * 0.0001);
			return cost;
		}
	}
}
