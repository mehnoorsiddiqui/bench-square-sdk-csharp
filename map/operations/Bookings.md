<!-- Generated file — do not edit; regenerated with the SDK. -->

# Bookings — operations

Accessor: `client.Bookings` · Source: `src/Square/Api/Bookings.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkRetrieveBookings

- **Auth**: `options.BearerAuth`
- **Signature**: `BulkRetrieveBookings(BulkRetrieveBookingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkRetrieveBookingsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveBookingsOperationRequest` | `src/Square/Requests/Bookings/BulkRetrieveBookingsOperationRequest.cs` |
| `BulkRetrieveBookingsRequest` | `src/Square/Models/BulkRetrieveBookingsRequest.cs` |
| `BulkRetrieveBookingsResponse` | `src/Square/Models/BulkRetrieveBookingsResponse.cs` |

### BulkRetrieveTeamMemberBookingProfiles

- **Auth**: `options.BearerAuth`
- **Signature**: `BulkRetrieveTeamMemberBookingProfiles(BulkRetrieveTeamMemberBookingProfilesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkRetrieveTeamMemberBookingProfilesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveTeamMemberBookingProfilesOperationRequest` | `src/Square/Requests/Bookings/BulkRetrieveTeamMemberBookingProfilesOperationRequest.cs` |
| `BulkRetrieveTeamMemberBookingProfilesRequest` | `src/Square/Models/BulkRetrieveTeamMemberBookingProfilesRequest.cs` |
| `BulkRetrieveTeamMemberBookingProfilesResponse` | `src/Square/Models/BulkRetrieveTeamMemberBookingProfilesResponse.cs` |

### CancelBooking

- **Auth**: `options.BearerAuth`
- **Signature**: `CancelBooking(CancelBookingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`, `Body`
- **Returns**: `CancelBookingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelBookingOperationRequest` | `src/Square/Requests/Bookings/CancelBookingOperationRequest.cs` |
| `CancelBookingRequest` | `src/Square/Models/CancelBookingRequest.cs` |
| `CancelBookingResponse` | `src/Square/Models/CancelBookingResponse.cs` |

### CreateBooking

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateBooking(CreateBookingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateBookingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateBookingOperationRequest` | `src/Square/Requests/Bookings/CreateBookingOperationRequest.cs` |
| `CreateBookingRequest` | `src/Square/Models/CreateBookingRequest.cs` |
| `CreateBookingResponse` | `src/Square/Models/CreateBookingResponse.cs` |

### ListBookings

- **Auth**: `options.BearerAuth`
- **Signature**: `ListBookings(ListBookingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`, `customer_id` ← `CustomerId`, `team_member_id` ← `TeamMemberId`, `location_id` ← `LocationId`, `start_at_min` ← `StartAtMin`, `start_at_max` ← `StartAtMax`
- **Returns**: `ListBookingsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListBookingsOperationRequest` | `src/Square/Requests/Bookings/ListBookingsOperationRequest.cs` |
| `ListBookingsResponse` | `src/Square/Models/ListBookingsResponse.cs` |

### ListLocationBookingProfiles

- **Auth**: `options.BearerAuth`
- **Signature**: `ListLocationBookingProfiles(ListLocationBookingProfilesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListLocationBookingProfilesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLocationBookingProfilesOperationRequest` | `src/Square/Requests/Bookings/ListLocationBookingProfilesOperationRequest.cs` |
| `ListLocationBookingProfilesResponse` | `src/Square/Models/ListLocationBookingProfilesResponse.cs` |

### ListTeamMemberBookingProfiles

- **Auth**: `options.BearerAuth`
- **Signature**: `ListTeamMemberBookingProfiles(ListTeamMemberBookingProfilesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `bookable_only` ← `BookableOnly`, `limit` ← `Limit`, `cursor` ← `Cursor`, `location_id` ← `LocationId`
- **Returns**: `ListTeamMemberBookingProfilesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTeamMemberBookingProfilesOperationRequest` | `src/Square/Requests/Bookings/ListTeamMemberBookingProfilesOperationRequest.cs` |
| `ListTeamMemberBookingProfilesResponse` | `src/Square/Models/ListTeamMemberBookingProfilesResponse.cs` |

### RetrieveBooking

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveBooking(RetrieveBookingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`
- **Returns**: `RetrieveBookingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBookingRequest` | `src/Square/Requests/Bookings/RetrieveBookingRequest.cs` |
| `RetrieveBookingResponse` | `src/Square/Models/RetrieveBookingResponse.cs` |

### RetrieveBusinessBookingProfile

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveBusinessBookingProfile(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RetrieveBusinessBookingProfileResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveBusinessBookingProfileResponse` | `src/Square/Models/RetrieveBusinessBookingProfileResponse.cs` |

### RetrieveLocationBookingProfile

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveLocationBookingProfile(RetrieveLocationBookingProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LocationId`
- **Returns**: `RetrieveLocationBookingProfileResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLocationBookingProfileRequest` | `src/Square/Requests/Bookings/RetrieveLocationBookingProfileRequest.cs` |
| `RetrieveLocationBookingProfileResponse` | `src/Square/Models/RetrieveLocationBookingProfileResponse.cs` |

### RetrieveTeamMemberBookingProfile

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveTeamMemberBookingProfile(RetrieveTeamMemberBookingProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`
- **Returns**: `RetrieveTeamMemberBookingProfileResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTeamMemberBookingProfileRequest` | `src/Square/Requests/Bookings/RetrieveTeamMemberBookingProfileRequest.cs` |
| `RetrieveTeamMemberBookingProfileResponse` | `src/Square/Models/RetrieveTeamMemberBookingProfileResponse.cs` |

### SearchAvailability

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchAvailability(SearchAvailabilityOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchAvailabilityResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchAvailabilityOperationRequest` | `src/Square/Requests/Bookings/SearchAvailabilityOperationRequest.cs` |
| `SearchAvailabilityRequest` | `src/Square/Models/SearchAvailabilityRequest.cs` |
| `SearchAvailabilityResponse` | `src/Square/Models/SearchAvailabilityResponse.cs` |

### UpdateBooking

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateBooking(UpdateBookingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BookingId`, `Body`
- **Returns**: `UpdateBookingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateBookingOperationRequest` | `src/Square/Requests/Bookings/UpdateBookingOperationRequest.cs` |
| `UpdateBookingRequest` | `src/Square/Models/UpdateBookingRequest.cs` |
| `UpdateBookingResponse` | `src/Square/Models/UpdateBookingResponse.cs` |

