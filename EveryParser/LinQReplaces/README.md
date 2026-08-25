# LinQReplaces

Custom extensions that deliberately deviate from `System.Linq`. Do not add
`System.Linq`-equivalent duplicates here without reading this first.

## Kept on purpose

| Class | Why it exists |
|---|---|
| `TSelect` | Returns an **eager** `List<TResult>` (materialized immediately), unlike `Enumerable.Select`. The evaluation pipeline stores results in node values and type-checks them with `is List<object>` - lazy enumerables would break these checks. |
| `TSequenceEqual` | Compares element-wise via `EqualityHelper.AreEqual` (semantic equality: numbers by value, strings ordinal). `Enumerable.SequenceEqual` with the default comparer would compare boxed values by reference/type. |
| `TReverse` | Convenience overloads (`ToReverse`) for lists and strings returning a new list/string. |

## Removed

`TAll` and `TAny` were plain re-implementations of `Enumerable.All`/`Any`
without any semantic difference and have been replaced by `System.Linq`.
