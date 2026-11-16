<!-- Generated file — do not edit; regenerated with the SDK. -->

# MobileAuthorization — operations

Accessor: `client.MobileAuthorization` · Source: `src/Square/Api/MobileAuthorization.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMobileAuthorizationCode

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateMobileAuthorizationCode(CreateMobileAuthorizationCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateMobileAuthorizationCodeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateMobileAuthorizationCodeOperationRequest` | `src/Square/Requests/MobileAuthorization/CreateMobileAuthorizationCodeOperationRequest.cs` |
| `CreateMobileAuthorizationCodeRequest` | `src/Square/Models/CreateMobileAuthorizationCodeRequest.cs` |
| `CreateMobileAuthorizationCodeResponse` | `src/Square/Models/CreateMobileAuthorizationCodeResponse.cs` |

