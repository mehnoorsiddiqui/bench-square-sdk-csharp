<!-- Generated file — do not edit; regenerated with the SDK. -->

# Transactions — operations

Accessor: `client.Transactions` · Source: `src/Square/Api/Transactions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListTransactions

- **Auth**: `options.BearerAuth`
- **Signature**: `ListTransactions(ListTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Query params (wire ← C#)**: `begin_time` ← `BeginTime`, `end_time` ← `EndTime`, `sort_order` ← `SortOrder`, `cursor` ← `Cursor`
- **Returns**: `ListTransactionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTransactionsRequest` | `src/Square/Requests/Transactions/ListTransactionsRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListTransactionsResponse` | `src/Square/Models/ListTransactionsResponse.cs` |

### RetrieveTransaction

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveTransaction(RetrieveTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`, `TransactionId`
- **Returns**: `RetrieveTransactionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTransactionRequest` | `src/Square/Requests/Transactions/RetrieveTransactionRequest.cs` |
| `RetrieveTransactionResponse` | `src/Square/Models/RetrieveTransactionResponse.cs` |

