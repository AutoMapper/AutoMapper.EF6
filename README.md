# AutoMapper.EF6
Extensions for AutoMapper and EF6

This contains some useful extensions I've used with AutoMapper and EF6. Instead of this:

```
Mapper.CreateMap<Employee, EmployeeDto>()
  .ForMember(d => d.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

var employees = await db.Employees.ProjectTo<EmployeeDto>().ToListAsync();
```

You can do this instead:

```
public class Employee {
  [Computed]
  public string FullName { get { return FirstName + " " + LastName; } }
}
Mapper.CreateMap<Employee, EmployeeDto>();

var employees = await db.Employees.ProjectToListAsync<EmployeeDto>();
```

This package wraps up calling `ProjectTo`, the DelegateDecompiler Decompile/DecompileAsync methods, and then the LINQ methods to execute the queryable (ToList, ToArray, Single, SingleOrDefault etc).
