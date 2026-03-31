
/*     Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
      
       Because EF Core follows "Conventions" — built-in rules that automatically treat
       any property named "Id" or "{ClassName}Id" as the Primary Key.
       This is called "Mapping by Convention" — no attributes or Fluent API needed.
 
       Q2: Why is "Country" nullable in the database while "Price" is not?

       "Price" is of type decimal — a value type in C# that cannot be null by default,
       so EF Core maps it as NOT NULL in the database.
       "Country" is of type string? — the "?" means it is explicitly nullable in C#,
       so EF Core maps it as NULL in the database.   
*/


using System;

namespace BookstoreSystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
