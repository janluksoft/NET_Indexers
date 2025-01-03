# Indexers in C#

.NET9 C# application: "Indexers"  and modern techniques to C# 11.

## Description

This "Indexers" program is written in C# .NET 9 which allows you to use C# 12 language syntax.
Here the program mainly demonstrates the use of indexers in C# through two classes:
`CBaskets` and `CJetEngines`. These classes implement indexers for retrieving and 
modifying elements within a collection based on index or name. Additionally, 
modern C# features are utilized to enhance readability and maintainability.

## Key Features and Techniques Used

### 1. **Indexers**
- Implemented in both `CBaskets` and `CJetEngines` classes.
- Provide access to elements based on an integer index (`this[int index]`).
- Enable retrieval of elements by name (`this[string name]`), using `FirstOrDefault` for efficient lookup.

### 2. **Expression-bodied Members**
- Used to simplify methods, improving readability.
- Example:
  ```csharp
  public void Print(Basket b) =>
      Console.WriteLine($"    Basket Name: {b.Name,-8}, Material: {b.Material,-7}, Weight: {b.Weight,6} kg.");
  ```

### 3. **Readonly Properties**
- Example:
  ```csharp
  public int Size => ListBaskets.Count;
  ```
  This provides a computed property without the need for a backing field.

### 4. **Records**
- Used for defining immutable data structures (`Basket` and `JetEngine`).
- Example:
  ```csharp
  public record Basket(string Name, string Material, double Weight, double Surface, int Persons);
  ```

### 5. **Nullable Types**
- Applied in the `JetEngine` record for `eFuel?` to allow null values.
- Example:
  ```csharp
  public record JetEngine(string Name, double Thrust, eFuel? Fuel, int Blades, double Weight);
  ```

### 6. **Collection Initializers**
- Used for initializing lists in `GetExampleBaskets` and `GetExampleEngines`.
- Example:
  ```csharp
  private List<Basket> GetExampleBaskets() => new()
  {
      new("Bas-N05", "Wicker", 102.2, 4.5, 5),
      new("Bas-N08", "Wicker", 145.2, 6.2, 8)
  };
  ```

### 7. **Interface Default Implementations (C# 8.0)**
- Implemented in the `IPrintJ` interface to provide default behavior.
- Example:
  ```csharp
  static string FixedString(string? xmessage, int xLen) =>
      xmessage?.PadRight(xLen).Substring(0, xLen) ?? string.Empty;
  ```

## Functionality
### `CBaskets` Class
- Stores a collection of `Basket` objects.
- Provides indexers to access baskets by index and name.
- Uses modern C# syntax to improve clarity and efficiency.

### `CJetEngines` Class
- Similar structure to `CBaskets` but for `JetEngine` objects.
- Implements indexers to access jet engines by index and name.

### `IPrintJ` Interface
- Defines a standard for printing elements.
- Implements static helper methods and default implementations for enhanced usability.

## Example Console Output

```
==== Demonstration of using classes with indexers ====

Hot Air Balloon baskets with indexer by [index]:
    Basket Name: Bas-N05 , Material: Wicker , Weight:  102,2 kg.
    Basket Name: Bas-N08 , Material: Wicker , Weight:  145,2 kg.
    Basket Name: Bas-N12 , Material: Wicker , Weight:  221,4 kg.
    Basket Name: Dry-08  , Material: Alu    , Weight:  165,4 kg.
    Basket Name: Dry-14  , Material: Alu    , Weight:  302,4 kg.

Hot Air Balloon baskets with indexer by [name]:
    Basket Name: Dry-08  , Material: Alu    , Weight:  165,4 kg.
    Basket Name: Bas-N12 , Material: Wicker , Weight:  221,4 kg.
    Basket Name: Bas-N05 , Material: Wicker , Weight:  102,2 kg.
    Basket Name: nothing , Material:        , Weight:      0 kg.

JetEngines with indexer by [index]:
    JetEngine Name: CFM56-5A5  , Thrust:   105000 N, Fuel: JetA_1   , Blades: 34, Weight: 2240 kg.
    JetEngine Name: CFM56-5A1  , Thrust:   110000 N, Fuel: JetA_1   , Blades: 38, Weight: 2270 kg.
    JetEngine Name: TRENT-900  , Thrust:   356000 N, Fuel: F_34     , Blades: 24, Weight: 6436 kg.
    JetEngine Name: CF6-80E1A3 , Thrust:   102000 N, Fuel: JetA_1   , Blades: 38, Weight: 2020 kg.
    JetEngine Name: CF6-80E1A4 , Thrust:   102000 N, Fuel: JetA_1   , Blades: 38, Weight: 2120 kg.
    JetEngine Name: CFM56-7B27 , Thrust:   121000 N, Fuel: F_34     , Blades: 28, Weight: 2370 kg.

JetEngines with indexer by [name]:
    JetEngine Name: TRENT-892  , Thrust:   146100 N, Fuel: F_34     , Blades: 24, Weight: 3100 kg.
    JetEngine Name: CF6-80E1A4 , Thrust:   102000 N, Fuel: JetA_1   , Blades: 38, Weight: 2120 kg.
    JetEngine Name: nothing    , Thrust:        0 N, Fuel:          , Blades:  0, Weight: 0 kg.

```

## Summary
This program efficiently demonstrates the use of indexers, records, and modern C# techniques to manage collections of hot air balloon baskets and jet engines. The implementation ensures a clean, structured, and efficient way of accessing and modifying objects.

