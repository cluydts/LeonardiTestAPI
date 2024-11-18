#nullable enable

namespace LeonardoNS.Client
{
    public partial interface IPricingCalculatorClient
    {
        /// <summary>
        /// Calculating API Cost<br/>
        /// This endpoint returns the cost used for generating images using a particular service type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LeonardoNS.Client.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.PricingCalculatorResponse> PricingCalculatorAsync(
            global::LeonardoNS.Client.PricingCalculatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculating API Cost<br/>
        /// This endpoint returns the cost used for generating images using a particular service type.
        /// </summary>
        /// <param name="service">
        /// The services to be chosen for calculating the API credit cost.
        /// </param>
        /// <param name="serviceParams">
        /// Parameters for the service
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LeonardoNS.Client.PricingCalculatorResponse> PricingCalculatorAsync(
            global::LeonardoNS.Client.PricingCalculatorServices? service = default,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParams? serviceParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}