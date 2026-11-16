<!-- Generated file — do not edit; regenerated with the SDK. -->

# BankAccounts — operations

Accessor: `client.BankAccounts` · Source: `src/Square/Api/BankAccounts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBankAccount

- **Auth**: `options.BearerAuth`
- **Signature**: `GetBankAccount(GetBankAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BankAccountId`
- **Returns**: `GetBankAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBankAccountRequest` | `src/Square/Requests/BankAccounts/GetBankAccountRequest.cs` |
| `GetBankAccountResponse` | `src/Square/Models/GetBankAccountResponse.cs` |

### GetBankAccountByV1Id

- **Auth**: `options.BearerAuth`
- **Signature**: `GetBankAccountByV1Id(GetBankAccountByV1IdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `V1BankAccountId`
- **Returns**: `GetBankAccountByV1IdResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBankAccountByV1IdRequest` | `src/Square/Requests/BankAccounts/GetBankAccountByV1IdRequest.cs` |
| `GetBankAccountByV1IdResponse` | `src/Square/Models/GetBankAccountByV1IdResponse.cs` |

### ListBankAccounts

- **Auth**: `options.BearerAuth`
- **Signature**: `ListBankAccounts(ListBankAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`, `location_id` ← `LocationId`
- **Returns**: `ListBankAccountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBankAccountsOperationRequest` | `src/Square/Requests/BankAccounts/ListBankAccountsOperationRequest.cs` |
| `ListBankAccountsResponse` | `src/Square/Models/ListBankAccountsResponse.cs` |

