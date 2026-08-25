# Contributing to EveryParser.Net

Thanks for your interest in contributing! This document describes how to set up
the project, how we work, and what to look out for.

## Development setup

Requirements:
- .NET SDK 8.0
- Java + ANTLR 4.13.2 (only needed when changing the grammar)

```bash
git clone https://github.com/AndreasBurbach/EveryParser.Net.git
cd EveryParser.Net
dotnet build
dotnet test
```

## Project layout

| Path | Content |
|---|---|
| `EveryParser/` | The library (NuGet package) |
| `EveryParser/EveryGrammar.g4` | ANTLR grammar source |
| `EveryParser/LinQReplaces/` | Custom LINQ extensions - read the README there before adding duplicates |
| `EveryParser.Test/` | xUnit test suite |
| `tools/` | Helper scripts (e.g. grammar verification) |

## Regenerating the parser

The generated ANTLR classes are committed to the repository. After changing
`EveryGrammar.g4`, regenerate and commit both together:

```bash
java -jar antlr-4.13.2-complete.jar -Dlanguage=CSharp -o EveryParser EveryGrammar.g4
```

Run `tools/verify-grammar.ps1` to sanity-check that every rule, alternative label
and token of the grammar exists in the generated code.

## Guidelines

- Every bug fix needs a regression test; new features need tests covering
  success and error paths.
- Public API members should have XML documentation.
- Do not use `string + EPDecimal` expressions in listeners - the implicit
  `EPDecimal(string)` conversion silently turns non-numeric strings into NaN
  (see `ConvertScalarToText` in `EveryGrammarCalculatorListener.cs`).
- The `Expression` class is not thread-safe by design; do not add shared mutable
  state.
- Nullable reference types were evaluated and are deliberately **not enabled
  yet**: the generated ANTLR code and ~70 test call sites would produce warnings
  without immediate value. Revisit after the listener cleanup; new library code
  should still avoid returning null without setting errors.

## Submitting changes

1. Fork the repository / create a feature branch.
2. Make your change including tests.
3. Ensure `dotnet build` and `dotnet test` pass.
4. Open a pull request with a clear description of what and why.

## Releases

Releases are triggered by pushing a tag (`v1.2.0` style). The `Release` workflow
builds, tests, packs and publishes the package to NuGet.org (requires the
`NUGET_API_KEY` secret). Bump `<Version>` in `EveryParser.csproj` and update
`CHANGELOG.md` as part of the release change.
