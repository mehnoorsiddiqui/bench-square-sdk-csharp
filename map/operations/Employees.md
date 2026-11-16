<!-- Generated file — do not edit; regenerated with the SDK. -->

# Employees — operations

Accessor: `client.Employees` · Source: `src/Square/Api/Employees.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListEmployees

- **Auth**: `options.BearerAuth`
- **Signature**: `ListEmployees(ListEmployeesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `status` ← `Status`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListEmployeesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEmployeesOperationRequest` | `src/Square/Requests/Employees/ListEmployeesOperationRequest.cs` |
| `ListEmployeesResponse` | `src/Square/Models/ListEmployeesResponse.cs` |

### RetrieveEmployee

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveEmployee(RetrieveEmployeeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RetrieveEmployeeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveEmployeeRequest` | `src/Square/Requests/Employees/RetrieveEmployeeRequest.cs` |
| `RetrieveEmployeeResponse` | `src/Square/Models/RetrieveEmployeeResponse.cs` |

