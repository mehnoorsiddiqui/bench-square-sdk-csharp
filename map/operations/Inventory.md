<!-- Generated file — do not edit; regenerated with the SDK. -->

# Inventory — operations

Accessor: `client.Inventory` · Source: `src/Square/Api/Inventory.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchChangeInventory

- **Auth**: `options.BearerAuth`
- **Signature**: `BatchChangeInventory(BatchChangeInventoryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchChangeInventoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchChangeInventoryOperationRequest` | `src/Square/Requests/Inventory/BatchChangeInventoryOperationRequest.cs` |
| `BatchChangeInventoryRequest` | `src/Square/Models/BatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryResponse` | `src/Square/Models/BatchChangeInventoryResponse.cs` |

### BatchRetrieveInventoryChanges

- **Auth**: `options.BearerAuth`
- **Signature**: `BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryChangesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryChangesOperationRequest` | `src/Square/Requests/Inventory/BatchRetrieveInventoryChangesOperationRequest.cs` |
| `BatchRetrieveInventoryChangesRequest` | `src/Square/Models/BatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesResponse` | `src/Square/Models/BatchRetrieveInventoryChangesResponse.cs` |

### BatchRetrieveInventoryCounts

- **Auth**: `options.BearerAuth`
- **Signature**: `BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryCountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveInventoryCountsOperationRequest` | `src/Square/Requests/Inventory/BatchRetrieveInventoryCountsOperationRequest.cs` |
| `BatchRetrieveInventoryCountsRequest` | `src/Square/Models/BatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsResponse` | `src/Square/Models/BatchRetrieveInventoryCountsResponse.cs` |

### DeprecatedBatchChangeInventory

- **Auth**: `options.BearerAuth`
- **Signature**: `DeprecatedBatchChangeInventory(DeprecatedBatchChangeInventoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchChangeInventoryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedBatchChangeInventoryRequest` | `src/Square/Requests/Inventory/DeprecatedBatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryRequest` | `src/Square/Models/BatchChangeInventoryRequest.cs` |
| `BatchChangeInventoryResponse` | `src/Square/Models/BatchChangeInventoryResponse.cs` |

### DeprecatedBatchRetrieveInventoryChanges

- **Auth**: `options.BearerAuth`
- **Signature**: `DeprecatedBatchRetrieveInventoryChanges(DeprecatedBatchRetrieveInventoryChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryChangesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedBatchRetrieveInventoryChangesRequest` | `src/Square/Requests/Inventory/DeprecatedBatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesRequest` | `src/Square/Models/BatchRetrieveInventoryChangesRequest.cs` |
| `BatchRetrieveInventoryChangesResponse` | `src/Square/Models/BatchRetrieveInventoryChangesResponse.cs` |

### DeprecatedBatchRetrieveInventoryCounts

- **Auth**: `options.BearerAuth`
- **Signature**: `DeprecatedBatchRetrieveInventoryCounts(DeprecatedBatchRetrieveInventoryCountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveInventoryCountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedBatchRetrieveInventoryCountsRequest` | `src/Square/Requests/Inventory/DeprecatedBatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsRequest` | `src/Square/Models/BatchRetrieveInventoryCountsRequest.cs` |
| `BatchRetrieveInventoryCountsResponse` | `src/Square/Models/BatchRetrieveInventoryCountsResponse.cs` |

### DeprecatedRetrieveInventoryAdjustment

- **Auth**: `options.BearerAuth`
- **Signature**: `DeprecatedRetrieveInventoryAdjustment(DeprecatedRetrieveInventoryAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AdjustmentId`
- **Returns**: `RetrieveInventoryAdjustmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedRetrieveInventoryAdjustmentRequest` | `src/Square/Requests/Inventory/DeprecatedRetrieveInventoryAdjustmentRequest.cs` |
| `RetrieveInventoryAdjustmentResponse` | `src/Square/Models/RetrieveInventoryAdjustmentResponse.cs` |

### DeprecatedRetrieveInventoryPhysicalCount

- **Auth**: `options.BearerAuth`
- **Signature**: `DeprecatedRetrieveInventoryPhysicalCount(DeprecatedRetrieveInventoryPhysicalCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PhysicalCountId`
- **Returns**: `RetrieveInventoryPhysicalCountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeprecatedRetrieveInventoryPhysicalCountRequest` | `src/Square/Requests/Inventory/DeprecatedRetrieveInventoryPhysicalCountRequest.cs` |
| `RetrieveInventoryPhysicalCountResponse` | `src/Square/Models/RetrieveInventoryPhysicalCountResponse.cs` |

### RetrieveInventoryAdjustment

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveInventoryAdjustment(RetrieveInventoryAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AdjustmentId`
- **Returns**: `RetrieveInventoryAdjustmentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryAdjustmentRequest` | `src/Square/Requests/Inventory/RetrieveInventoryAdjustmentRequest.cs` |
| `RetrieveInventoryAdjustmentResponse` | `src/Square/Models/RetrieveInventoryAdjustmentResponse.cs` |

### RetrieveInventoryChanges

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveInventoryChanges(RetrieveInventoryChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CatalogObjectId`
- **Query params (wire ← C#)**: `location_ids` ← `LocationIds`, `cursor` ← `Cursor`
- **Returns**: `RetrieveInventoryChangesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryChangesRequest` | `src/Square/Requests/Inventory/RetrieveInventoryChangesRequest.cs` |
| `RetrieveInventoryChangesResponse` | `src/Square/Models/RetrieveInventoryChangesResponse.cs` |

### RetrieveInventoryCount

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveInventoryCount(RetrieveInventoryCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CatalogObjectId`
- **Query params (wire ← C#)**: `location_ids` ← `LocationIds`, `cursor` ← `Cursor`
- **Returns**: `RetrieveInventoryCountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryCountRequest` | `src/Square/Requests/Inventory/RetrieveInventoryCountRequest.cs` |
| `RetrieveInventoryCountResponse` | `src/Square/Models/RetrieveInventoryCountResponse.cs` |

### RetrieveInventoryPhysicalCount

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveInventoryPhysicalCount(RetrieveInventoryPhysicalCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PhysicalCountId`
- **Returns**: `RetrieveInventoryPhysicalCountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryPhysicalCountRequest` | `src/Square/Requests/Inventory/RetrieveInventoryPhysicalCountRequest.cs` |
| `RetrieveInventoryPhysicalCountResponse` | `src/Square/Models/RetrieveInventoryPhysicalCountResponse.cs` |

### RetrieveInventoryTransfer

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveInventoryTransfer(RetrieveInventoryTransferRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferId`
- **Returns**: `RetrieveInventoryTransferResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveInventoryTransferRequest` | `src/Square/Requests/Inventory/RetrieveInventoryTransferRequest.cs` |
| `RetrieveInventoryTransferResponse` | `src/Square/Models/RetrieveInventoryTransferResponse.cs` |

