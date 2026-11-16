<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payouts — operations

Accessor: `client.Payouts` · Source: `src/Square/Api/Payouts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPayout

- **Auth**: `options.BearerAuth`
- **Signature**: `GetPayout(GetPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PayoutId`
- **Returns**: `GetPayoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPayoutRequest` | `src/Square/Requests/Payouts/GetPayoutRequest.cs` |
| `GetPayoutResponse` | `src/Square/Models/GetPayoutResponse.cs` |

### ListPayoutEntries

- **Auth**: `options.BearerAuth`
- **Signature**: `ListPayoutEntries(ListPayoutEntriesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PayoutId`
- **Query params (wire ← C#)**: `sort_order` ← `SortOrder`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListPayoutEntriesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPayoutEntriesOperationRequest` | `src/Square/Requests/Payouts/ListPayoutEntriesOperationRequest.cs` |
| `ListPayoutEntriesResponse` | `src/Square/Models/ListPayoutEntriesResponse.cs` |

### ListPayouts

- **Auth**: `options.BearerAuth`
- **Signature**: `ListPayouts(ListPayoutsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `status` ← `Status`, `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `sort_order` ← `SortOrder`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListPayoutsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPayoutsOperationRequest` | `src/Square/Requests/Payouts/ListPayoutsOperationRequest.cs` |
| `ListPayoutsResponse` | `src/Square/Models/ListPayoutsResponse.cs` |

