<!-- Generated file — do not edit; regenerated with the SDK. -->

# Labor — operations

Accessor: `client.Labor` · Source: `src/Square/Api/Labor.cs` · 16 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateBreakType

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateBreakType(CreateBreakTypeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateBreakTypeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBreakTypeOperationRequest` | `src/Square/Requests/Labor/CreateBreakTypeOperationRequest.cs` |
| `CreateBreakTypeRequest` | `src/Square/Models/CreateBreakTypeRequest.cs` |
| `CreateBreakTypeResponse` | `src/Square/Models/CreateBreakTypeResponse.cs` |

### CreateShift

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateShift(CreateShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateShiftOperationRequest` | `src/Square/Requests/Labor/CreateShiftOperationRequest.cs` |
| `CreateShiftRequest` | `src/Square/Models/CreateShiftRequest.cs` |
| `CreateShiftResponse` | `src/Square/Models/CreateShiftResponse.cs` |

### DeleteBreakType

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteBreakType(DeleteBreakTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeleteBreakTypeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteBreakTypeRequest` | `src/Square/Requests/Labor/DeleteBreakTypeRequest.cs` |
| `DeleteBreakTypeResponse` | `src/Square/Models/DeleteBreakTypeResponse.cs` |

### DeleteShift

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteShift(DeleteShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeleteShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteShiftRequest` | `src/Square/Requests/Labor/DeleteShiftRequest.cs` |
| `DeleteShiftResponse` | `src/Square/Models/DeleteShiftResponse.cs` |

### GetBreakType

- **Auth**: `options.BearerAuth`
- **Signature**: `GetBreakType(GetBreakTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetBreakTypeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetBreakTypeRequest` | `src/Square/Requests/Labor/GetBreakTypeRequest.cs` |
| `GetBreakTypeResponse` | `src/Square/Models/GetBreakTypeResponse.cs` |

### GetEmployeeWage

- **Auth**: `options.BearerAuth`
- **Signature**: `GetEmployeeWage(GetEmployeeWageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetEmployeeWageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetEmployeeWageRequest` | `src/Square/Requests/Labor/GetEmployeeWageRequest.cs` |
| `GetEmployeeWageResponse` | `src/Square/Models/GetEmployeeWageResponse.cs` |

### GetShift

- **Auth**: `options.BearerAuth`
- **Signature**: `GetShift(GetShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetShiftRequest` | `src/Square/Requests/Labor/GetShiftRequest.cs` |
| `GetShiftResponse` | `src/Square/Models/GetShiftResponse.cs` |

### GetTeamMemberWage

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTeamMemberWage(GetTeamMemberWageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetTeamMemberWageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTeamMemberWageRequest` | `src/Square/Requests/Labor/GetTeamMemberWageRequest.cs` |
| `GetTeamMemberWageResponse` | `src/Square/Models/GetTeamMemberWageResponse.cs` |

### ListBreakTypes

- **Auth**: `options.BearerAuth`
- **Signature**: `ListBreakTypes(ListBreakTypesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListBreakTypesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBreakTypesOperationRequest` | `src/Square/Requests/Labor/ListBreakTypesOperationRequest.cs` |
| `ListBreakTypesResponse` | `src/Square/Models/ListBreakTypesResponse.cs` |

### ListEmployeeWages

- **Auth**: `options.BearerAuth`
- **Signature**: `ListEmployeeWages(ListEmployeeWagesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `employee_id` ← `EmployeeId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListEmployeeWagesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEmployeeWagesOperationRequest` | `src/Square/Requests/Labor/ListEmployeeWagesOperationRequest.cs` |
| `ListEmployeeWagesResponse` | `src/Square/Models/ListEmployeeWagesResponse.cs` |

### ListTeamMemberWages

- **Auth**: `options.BearerAuth`
- **Signature**: `ListTeamMemberWages(ListTeamMemberWagesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `team_member_id` ← `TeamMemberId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListTeamMemberWagesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTeamMemberWagesOperationRequest` | `src/Square/Requests/Labor/ListTeamMemberWagesOperationRequest.cs` |
| `ListTeamMemberWagesResponse` | `src/Square/Models/ListTeamMemberWagesResponse.cs` |

### ListWorkweekConfigs

- **Auth**: `options.BearerAuth`
- **Signature**: `ListWorkweekConfigs(ListWorkweekConfigsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListWorkweekConfigsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWorkweekConfigsOperationRequest` | `src/Square/Requests/Labor/ListWorkweekConfigsOperationRequest.cs` |
| `ListWorkweekConfigsResponse` | `src/Square/Models/ListWorkweekConfigsResponse.cs` |

### SearchShifts

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchShifts(SearchShiftsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchShiftsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchShiftsOperationRequest` | `src/Square/Requests/Labor/SearchShiftsOperationRequest.cs` |
| `SearchShiftsRequest` | `src/Square/Models/SearchShiftsRequest.cs` |
| `SearchShiftsResponse` | `src/Square/Models/SearchShiftsResponse.cs` |

### UpdateBreakType

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateBreakType(UpdateBreakTypeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdateBreakTypeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBreakTypeOperationRequest` | `src/Square/Requests/Labor/UpdateBreakTypeOperationRequest.cs` |
| `UpdateBreakTypeRequest` | `src/Square/Models/UpdateBreakTypeRequest.cs` |
| `UpdateBreakTypeResponse` | `src/Square/Models/UpdateBreakTypeResponse.cs` |

### UpdateShift

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateShift(UpdateShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdateShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateShiftOperationRequest` | `src/Square/Requests/Labor/UpdateShiftOperationRequest.cs` |
| `UpdateShiftRequest` | `src/Square/Models/UpdateShiftRequest.cs` |
| `UpdateShiftResponse` | `src/Square/Models/UpdateShiftResponse.cs` |

### UpdateWorkweekConfig

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateWorkweekConfig(UpdateWorkweekConfigOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdateWorkweekConfigResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWorkweekConfigOperationRequest` | `src/Square/Requests/Labor/UpdateWorkweekConfigOperationRequest.cs` |
| `UpdateWorkweekConfigRequest` | `src/Square/Models/UpdateWorkweekConfigRequest.cs` |
| `UpdateWorkweekConfigResponse` | `src/Square/Models/UpdateWorkweekConfigResponse.cs` |

