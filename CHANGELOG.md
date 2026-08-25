# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.2.0] - Unreleased

### Added
- Async calculation API: `CalculateAsync`, `CalculateDecimalAsync`, `CalculateBooleanAsync`,
  `CalculateStringAsync`, `CalculateDateTimeAsync` and `CalculateArrayAsync`
  (instance and static variants) with optional `CancellationToken`.
- String concatenation with `+`: `"Hello " + "World"` and mixed forms like
  `"x" + 2.5` now work (numbers are formatted culture-invariant).
- `CalculateArray` now reports an error (`ErrorCode.IsNotArray`) when the formular
  result is not an array instead of returning `null` without any error.
- Release workflow that builds, tests and publishes the NuGet package on tag push (`v*`).
- Grammar source `EveryGrammar.g4` is part of the repository again and can be verified
  against the generated parser with `tools/verify-grammar.ps1`.

### Fixed
- `CalculationErrors` no longer throws a `NullReferenceException` when accessed before
  the first calculation.
- `4!` returned 14 instead of 24.
- Factorial of negative numbers and values above 20 now produce an error
  instead of silently returning a wrong result.
- Array operations materialize their results eagerly, preventing deferred-execution issues.

### Changed
- GitHub Actions updated to current action versions; CodeQL workflow moved to v3.
- Removed the stale Azure Pipelines configuration.
- The NuGet package now contains XML documentation files.
- Removed redundant LINQ replacements (`TAll`, `TAny`) in favor of `System.Linq`;
  kept `TSelect`, `TSequenceEqual` and `TReverse` for semantic reasons
  (see `EveryParser/LinQReplaces/README.md`).

## [1.1.0] - 2023

### Added
- EOF syntax check to detect trailing syntax errors.
- Alias for percentage number value.

## [1.0.7] - 2023

### Fixed
- Equality check between values and arrays.

## [1.0.6] - 2023

### Added
- Markdown documentation to the project.

## [1.0.5] - 2023

- Maintenance release.
