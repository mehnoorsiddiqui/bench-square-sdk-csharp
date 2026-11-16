using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in a request to the <c>DeleteCustomer</c>
/// endpoint.
/// </summary>
public record DeleteCustomerRequest
{
    /// <summary>
    /// The current version of the customer profile.
    /// <para>
    /// As a best practice, you should include this parameter to enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see> control.  For more information, see <see href="https://developer.squareup.com/docs/customers-api/use-the-api/keep-records#delete-customer-profile">Delete a customer profile</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
