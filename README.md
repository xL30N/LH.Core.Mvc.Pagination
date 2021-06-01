# LH.Core.Mvc.Pagination
MVC package for pagination

```csharp
int totalItems = 100;
int pageSize = 10;
int currentPage = 1;

PaginatedList list = new PaginatedList(totalItems, currentPage, pageSize);
```

## Taghelper

```csharp
@addTagHelper *, LH.Core.Mvc.Pagination
```

```csharp
<pagination Page="@Model.PageIndex" TotalPages="@Model.TotalPages">
```

Additional route data can also be provided to the tag helper if required.

```csharp
<pagination Page="@Model.PageIndex" TotalPages="@Model.TotalPages" RouteValues="@new {}">
```