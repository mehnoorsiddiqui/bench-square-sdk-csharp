<!-- Generated file — do not edit; regenerated with the SDK. -->

# Cards — operations

Accessor: `client.Cards` · Source: `src/Square/Api/Cards.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCard

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateCard(CreateCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCardOperationRequest` | `src/Square/Requests/Cards/CreateCardOperationRequest.cs` |
| `CreateCardRequest` | `src/Square/Models/CreateCardRequest.cs` |
| `CreateCardResponse` | `src/Square/Models/CreateCardResponse.cs` |

### DisableCard

- **Auth**: `options.BearerAuth`
- **Signature**: `DisableCard(DisableCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CardId`
- **Returns**: `DisableCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisableCardRequest` | `src/Square/Requests/Cards/DisableCardRequest.cs` |
| `DisableCardResponse` | `src/Square/Models/DisableCardResponse.cs` |

### ListCards

- **Auth**: `options.BearerAuth`
- **Signature**: `ListCards(ListCardsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `customer_id` ← `CustomerId`, `include_disabled` ← `IncludeDisabled`, `reference_id` ← `ReferenceId`, `sort_order` ← `SortOrder`
- **Returns**: `ListCardsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCardsOperationRequest` | `src/Square/Requests/Cards/ListCardsOperationRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListCardsResponse` | `src/Square/Models/ListCardsResponse.cs` |

### RetrieveCard

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveCard(RetrieveCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CardId`
- **Returns**: `RetrieveCardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCardRequest` | `src/Square/Requests/Cards/RetrieveCardRequest.cs` |
| `RetrieveCardResponse` | `src/Square/Models/RetrieveCardResponse.cs` |

