<!-- Generated file — do not edit; regenerated with the SDK. -->

# Labor — operations

Accessor: `client.Labor` · Source: `src/Square/Api/Labor.cs` · 27 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkPublishScheduledShifts

- **Auth**: `options.BearerAuth`
- **Signature**: `BulkPublishScheduledShifts(BulkPublishScheduledShiftsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkPublishScheduledShiftsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkPublishScheduledShiftsOperationRequest` | `src/Square/Requests/Labor/BulkPublishScheduledShiftsOperationRequest.cs` |
| `BulkPublishScheduledShiftsRequest` | `src/Square/Models/BulkPublishScheduledShiftsRequest.cs` |
| `BulkPublishScheduledShiftsResponse` | `src/Square/Models/BulkPublishScheduledShiftsResponse.cs` |

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

### CreateScheduledShift

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateScheduledShift(CreateScheduledShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateScheduledShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateScheduledShiftOperationRequest` | `src/Square/Requests/Labor/CreateScheduledShiftOperationRequest.cs` |
| `CreateScheduledShiftRequest` | `src/Square/Models/CreateScheduledShiftRequest.cs` |
| `CreateScheduledShiftResponse` | `src/Square/Models/CreateScheduledShiftResponse.cs` |

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

### CreateTimecard

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateTimecard(CreateTimecardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTimecardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTimecardOperationRequest` | `src/Square/Requests/Labor/CreateTimecardOperationRequest.cs` |
| `CreateTimecardRequest` | `src/Square/Models/CreateTimecardRequest.cs` |
| `CreateTimecardResponse` | `src/Square/Models/CreateTimecardResponse.cs` |

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

### DeleteTimecard

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteTimecard(DeleteTimecardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DeleteTimecardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteTimecardRequest` | `src/Square/Requests/Labor/DeleteTimecardRequest.cs` |
| `DeleteTimecardResponse` | `src/Square/Models/DeleteTimecardResponse.cs` |

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
- **Signature**: `ListBreakTypes(ListBreakTypesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListBreakTypesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBreakTypesRequest` | `src/Square/Requests/Labor/ListBreakTypesRequest.cs` |
| `ListBreakTypesResponse` | `src/Square/Models/ListBreakTypesResponse.cs` |

### ListEmployeeWages

- **Auth**: `options.BearerAuth`
- **Signature**: `ListEmployeeWages(ListEmployeeWagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `employee_id` ← `EmployeeId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListEmployeeWagesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEmployeeWagesRequest` | `src/Square/Requests/Labor/ListEmployeeWagesRequest.cs` |
| `ListEmployeeWagesResponse` | `src/Square/Models/ListEmployeeWagesResponse.cs` |

### ListTeamMemberWages

- **Auth**: `options.BearerAuth`
- **Signature**: `ListTeamMemberWages(ListTeamMemberWagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `team_member_id` ← `TeamMemberId`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListTeamMemberWagesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTeamMemberWagesRequest` | `src/Square/Requests/Labor/ListTeamMemberWagesRequest.cs` |
| `ListTeamMemberWagesResponse` | `src/Square/Models/ListTeamMemberWagesResponse.cs` |

### ListWorkweekConfigs

- **Auth**: `options.BearerAuth`
- **Signature**: `ListWorkweekConfigs(ListWorkweekConfigsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListWorkweekConfigsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWorkweekConfigsRequest` | `src/Square/Requests/Labor/ListWorkweekConfigsRequest.cs` |
| `ListWorkweekConfigsResponse` | `src/Square/Models/ListWorkweekConfigsResponse.cs` |

### PublishScheduledShift

- **Auth**: `options.BearerAuth`
- **Signature**: `PublishScheduledShift(PublishScheduledShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `PublishScheduledShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublishScheduledShiftOperationRequest` | `src/Square/Requests/Labor/PublishScheduledShiftOperationRequest.cs` |
| `PublishScheduledShiftRequest` | `src/Square/Models/PublishScheduledShiftRequest.cs` |
| `PublishScheduledShiftResponse` | `src/Square/Models/PublishScheduledShiftResponse.cs` |

### RetrieveScheduledShift

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveScheduledShift(RetrieveScheduledShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RetrieveScheduledShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveScheduledShiftRequest` | `src/Square/Requests/Labor/RetrieveScheduledShiftRequest.cs` |
| `RetrieveScheduledShiftResponse` | `src/Square/Models/RetrieveScheduledShiftResponse.cs` |

### RetrieveTimecard

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveTimecard(RetrieveTimecardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RetrieveTimecardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTimecardRequest` | `src/Square/Requests/Labor/RetrieveTimecardRequest.cs` |
| `RetrieveTimecardResponse` | `src/Square/Models/RetrieveTimecardResponse.cs` |

### SearchScheduledShifts

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchScheduledShifts(SearchScheduledShiftsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchScheduledShiftsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchScheduledShiftsOperationRequest` | `src/Square/Requests/Labor/SearchScheduledShiftsOperationRequest.cs` |
| `SearchScheduledShiftsRequest` | `src/Square/Models/SearchScheduledShiftsRequest.cs` |
| `SearchScheduledShiftsResponse` | `src/Square/Models/SearchScheduledShiftsResponse.cs` |

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

### SearchTimecards

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchTimecards(SearchTimecardsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTimecardsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTimecardsOperationRequest` | `src/Square/Requests/Labor/SearchTimecardsOperationRequest.cs` |
| `SearchTimecardsRequest` | `src/Square/Models/SearchTimecardsRequest.cs` |
| `SearchTimecardsResponse` | `src/Square/Models/SearchTimecardsResponse.cs` |

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

### UpdateScheduledShift

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateScheduledShift(UpdateScheduledShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdateScheduledShiftResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateScheduledShiftOperationRequest` | `src/Square/Requests/Labor/UpdateScheduledShiftOperationRequest.cs` |
| `UpdateScheduledShiftRequest` | `src/Square/Models/UpdateScheduledShiftRequest.cs` |
| `UpdateScheduledShiftResponse` | `src/Square/Models/UpdateScheduledShiftResponse.cs` |

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

### UpdateTimecard

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateTimecard(UpdateTimecardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdateTimecardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTimecardOperationRequest` | `src/Square/Requests/Labor/UpdateTimecardOperationRequest.cs` |
| `UpdateTimecardRequest` | `src/Square/Models/UpdateTimecardRequest.cs` |
| `UpdateTimecardResponse` | `src/Square/Models/UpdateTimecardResponse.cs` |

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

