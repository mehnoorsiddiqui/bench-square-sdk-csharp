<!-- Generated file — do not edit; regenerated with the SDK. -->

# Catalog — operations

Accessor: `client.Catalog` · Source: `src/Square/Api/Catalog.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BatchDeleteCatalogObjects

- **Auth**: `options.BearerAuth`
- **Signature**: `BatchDeleteCatalogObjects(BatchDeleteCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchDeleteCatalogObjectsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchDeleteCatalogObjectsOperationRequest` | `src/Square/Requests/Catalog/BatchDeleteCatalogObjectsOperationRequest.cs` |
| `BatchDeleteCatalogObjectsRequest` | `src/Square/Models/BatchDeleteCatalogObjectsRequest.cs` |
| `BatchDeleteCatalogObjectsResponse` | `src/Square/Models/BatchDeleteCatalogObjectsResponse.cs` |

### BatchRetrieveCatalogObjects

- **Auth**: `options.BearerAuth`
- **Signature**: `BatchRetrieveCatalogObjects(BatchRetrieveCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchRetrieveCatalogObjectsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchRetrieveCatalogObjectsOperationRequest` | `src/Square/Requests/Catalog/BatchRetrieveCatalogObjectsOperationRequest.cs` |
| `BatchRetrieveCatalogObjectsRequest` | `src/Square/Models/BatchRetrieveCatalogObjectsRequest.cs` |
| `BatchRetrieveCatalogObjectsResponse` | `src/Square/Models/BatchRetrieveCatalogObjectsResponse.cs` |

### BatchUpsertCatalogObjects

- **Auth**: `options.BearerAuth`
- **Signature**: `BatchUpsertCatalogObjects(BatchUpsertCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchUpsertCatalogObjectsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BatchUpsertCatalogObjectsOperationRequest` | `src/Square/Requests/Catalog/BatchUpsertCatalogObjectsOperationRequest.cs` |
| `BatchUpsertCatalogObjectsRequest` | `src/Square/Models/BatchUpsertCatalogObjectsRequest.cs` |
| `BatchUpsertCatalogObjectsResponse` | `src/Square/Models/BatchUpsertCatalogObjectsResponse.cs` |

### CatalogInfo

- **Auth**: `options.BearerAuth`
- **Signature**: `CatalogInfo(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CatalogInfoResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CatalogInfoResponse` | `src/Square/Models/CatalogInfoResponse.cs` |

### CreateCatalogImage

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateCatalogImage(CreateCatalogImageOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateCatalogImageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCatalogImageOperationRequest` | `src/Square/Requests/Catalog/CreateCatalogImageOperationRequest.cs` |
| `CreateCatalogImageRequest` | `src/Square/Models/CreateCatalogImageRequest.cs` |
| `CreateCatalogImageResponse` | `src/Square/Models/CreateCatalogImageResponse.cs` |

### DeleteCatalogObject

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteCatalogObject(DeleteCatalogObjectRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ObjectId`
- **Returns**: `DeleteCatalogObjectResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCatalogObjectRequest` | `src/Square/Requests/Catalog/DeleteCatalogObjectRequest.cs` |
| `DeleteCatalogObjectResponse` | `src/Square/Models/DeleteCatalogObjectResponse.cs` |

### ListCatalog

- **Auth**: `options.BearerAuth`
- **Signature**: `ListCatalog(ListCatalogOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `types` ← `Types`, `catalog_version` ← `CatalogVersion`
- **Returns**: `ListCatalogResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCatalogOperationRequest` | `src/Square/Requests/Catalog/ListCatalogOperationRequest.cs` |
| `ListCatalogResponse` | `src/Square/Models/ListCatalogResponse.cs` |

### RetrieveCatalogObject

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveCatalogObject(RetrieveCatalogObjectOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ObjectId`
- **Query params (wire ← C#)**: `include_related_objects` ← `IncludeRelatedObjects`, `catalog_version` ← `CatalogVersion`, `include_category_path_to_root` ← `IncludeCategoryPathToRoot`
- **Returns**: `RetrieveCatalogObjectResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveCatalogObjectOperationRequest` | `src/Square/Requests/Catalog/RetrieveCatalogObjectOperationRequest.cs` |
| `RetrieveCatalogObjectResponse` | `src/Square/Models/RetrieveCatalogObjectResponse.cs` |

### SearchCatalogItems

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchCatalogItems(SearchCatalogItemsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchCatalogItemsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCatalogItemsOperationRequest` | `src/Square/Requests/Catalog/SearchCatalogItemsOperationRequest.cs` |
| `SearchCatalogItemsRequest` | `src/Square/Models/SearchCatalogItemsRequest.cs` |
| `SearchCatalogItemsResponse` | `src/Square/Models/SearchCatalogItemsResponse.cs` |

### SearchCatalogObjects

- **Auth**: `options.BearerAuth`
- **Signature**: `SearchCatalogObjects(SearchCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchCatalogObjectsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchCatalogObjectsOperationRequest` | `src/Square/Requests/Catalog/SearchCatalogObjectsOperationRequest.cs` |
| `SearchCatalogObjectsRequest` | `src/Square/Models/SearchCatalogObjectsRequest.cs` |
| `SearchCatalogObjectsResponse` | `src/Square/Models/SearchCatalogObjectsResponse.cs` |

### UpdateCatalogImage

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateCatalogImage(UpdateCatalogImageOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ImageId`
- **Returns**: `UpdateCatalogImageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCatalogImageOperationRequest` | `src/Square/Requests/Catalog/UpdateCatalogImageOperationRequest.cs` |
| `UpdateCatalogImageRequest` | `src/Square/Models/UpdateCatalogImageRequest.cs` |
| `UpdateCatalogImageResponse` | `src/Square/Models/UpdateCatalogImageResponse.cs` |

### UpdateItemModifierLists

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateItemModifierLists(UpdateItemModifierListsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UpdateItemModifierListsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateItemModifierListsOperationRequest` | `src/Square/Requests/Catalog/UpdateItemModifierListsOperationRequest.cs` |
| `UpdateItemModifierListsRequest` | `src/Square/Models/UpdateItemModifierListsRequest.cs` |
| `UpdateItemModifierListsResponse` | `src/Square/Models/UpdateItemModifierListsResponse.cs` |

### UpdateItemTaxes

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateItemTaxes(UpdateItemTaxesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UpdateItemTaxesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateItemTaxesOperationRequest` | `src/Square/Requests/Catalog/UpdateItemTaxesOperationRequest.cs` |
| `UpdateItemTaxesRequest` | `src/Square/Models/UpdateItemTaxesRequest.cs` |
| `UpdateItemTaxesResponse` | `src/Square/Models/UpdateItemTaxesResponse.cs` |

### UpsertCatalogObject

- **Auth**: `options.BearerAuth`
- **Signature**: `UpsertCatalogObject(UpsertCatalogObjectOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UpsertCatalogObjectResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpsertCatalogObjectOperationRequest` | `src/Square/Requests/Catalog/UpsertCatalogObjectOperationRequest.cs` |
| `UpsertCatalogObjectRequest` | `src/Square/Models/UpsertCatalogObjectRequest.cs` |
| `UpsertCatalogObjectResponse` | `src/Square/Models/UpsertCatalogObjectResponse.cs` |

