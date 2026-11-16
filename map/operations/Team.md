<!-- Generated file — do not edit; regenerated with the SDK. -->

# Team — operations

Accessor: `client.Team` · Source: `src/Square/Api/Team.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkCreateTeamMembers

- **Auth**: `options.BearerAuth`
- **Signature**: `BulkCreateTeamMembers(BulkCreateTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkCreateTeamMembersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateTeamMembersOperationRequest` | `src/Square/Requests/Team/BulkCreateTeamMembersOperationRequest.cs` |
| `BulkCreateTeamMembersRequest` | `src/Square/Models/BulkCreateTeamMembersRequest.cs` |
| `BulkCreateTeamMembersResponse` | `src/Square/Models/BulkCreateTeamMembersResponse.cs` |

### BulkUpdateTeamMembers

- **Auth**: `options.BearerAuth`
- **Signature**: `BulkUpdateTeamMembers(BulkUpdateTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpdateTeamMembersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateTeamMembersOperationRequest` | `src/Square/Requests/Team/BulkUpdateTeamMembersOperationRequest.cs` |
| `BulkUpdateTeamMembersRequest` | `src/Square/Models/BulkUpdateTeamMembersRequest.cs` |
| `BulkUpdateTeamMembersResponse` | `src/Square/Models/BulkUpdateTeamMembersResponse.cs` |

### CreateTeamMember

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateTeamMember(CreateTeamMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTeamMemberResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTeamMemberOperationRequest` | `src/Square/Requests/Team/CreateTeamMemberOperationRequest.cs` |
| `CreateTeamMemberRequest` | `src/Square/Models/CreateTeamMemberRequest.cs` |
| `CreateTeamMemberResponse` | `src/Square/Models/CreateTeamMemberResponse.cs` |

### RetrieveTeamMember

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveTeamMember(RetrieveTeamMemberRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`
- **Returns**: `RetrieveTeamMemberResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTeamMemberRequest` | `src/Square/Requests/Team/RetrieveTeamMemberRequest.cs` |
| `RetrieveTeamMemberResponse` | `src/Square/Models/RetrieveTeamMemberResponse.cs` |

### RetrieveWageSetting

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveWageSetting(RetrieveWageSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`
- **Returns**: `RetrieveWageSettingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveWageSettingRequest` | `src/Square/Requests/Team/RetrieveWageSettingRequest.cs` |
| `RetrieveWageSettingResponse` | `src/Square/Models/RetrieveWageSettingResponse.cs` |

### SearchTeamMembers

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchTeamMembers(SearchTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTeamMembersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTeamMembersOperationRequest` | `src/Square/Requests/Team/SearchTeamMembersOperationRequest.cs` |
| `SearchTeamMembersRequest` | `src/Square/Models/SearchTeamMembersRequest.cs` |
| `SearchTeamMembersResponse` | `src/Square/Models/SearchTeamMembersResponse.cs` |

### UpdateTeamMember

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateTeamMember(UpdateTeamMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`, `Body`
- **Returns**: `UpdateTeamMemberResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTeamMemberOperationRequest` | `src/Square/Requests/Team/UpdateTeamMemberOperationRequest.cs` |
| `UpdateTeamMemberRequest` | `src/Square/Models/UpdateTeamMemberRequest.cs` |
| `UpdateTeamMemberResponse` | `src/Square/Models/UpdateTeamMemberResponse.cs` |

### UpdateWageSetting

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateWageSetting(UpdateWageSettingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`, `Body`
- **Returns**: `UpdateWageSettingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWageSettingOperationRequest` | `src/Square/Requests/Team/UpdateWageSettingOperationRequest.cs` |
| `UpdateWageSettingRequest` | `src/Square/Models/UpdateWageSettingRequest.cs` |
| `UpdateWageSettingResponse` | `src/Square/Models/UpdateWageSettingResponse.cs` |

