using TodoList.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

This adds the `DataContext` to the dependency injection container and sets up an in-memory database for simplicity.

### 3. **Register the `ToDoItem` Class to the DataContext**
- The `ToDoItem` class has already been registered as part of the `DataContext` class:
  
  ```csharp
  public DbSet<ToDoItem> ToDoItems { get; set; }
