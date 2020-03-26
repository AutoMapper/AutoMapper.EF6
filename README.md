# AutoMapper.EF6
Extensions for AutoMapper and EF6

[![NuGet](http://img.shields.io/nuget/v/AutoMapper.EF6.svg)](https://www.nuget.org/packages/AutoMapper.EF6/)

This contains some useful extensions I've used with AutoMapper and EF6. Instead of this:

```csharp
Mapper.CreateMap<Employee, EmployeeDto>()
  .ForMember(d => d.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

var employees = await db.Employees.ProjectTo<EmployeeDto>().ToListAsync();
```

You can do this instead:

```csharp
public class Employee {
  [Computed]
  public string FullName { get { return FirstName + " " + LastName; } }
}
Mapper.CreateMap<Employee, EmployeeDto>();

var employees = await db.Employees.ProjectToListAsync<EmployeeDto>();
```

This package wraps up calling `ProjectTo`, the DelegateDecompiler Decompile/DecompileAsync methods, and then the LINQ methods to execute the queryable (ToList, ToArray, Single, SingleOrDefault etc).
