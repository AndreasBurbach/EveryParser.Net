$root = 'C:\Users\burba\repos\EveryParser.Net'
$g4 = Get-Content (Join-Path $root 'EveryParser\EveryGrammar.g4') -Raw
$parser = Get-Content (Join-Path $root 'EveryParser\EveryGrammarParser.cs') -Raw
$lexer = Get-Content (Join-Path $root 'EveryParser\EveryGrammarLexer.cs') -Raw

$missing = @()

# 1) labeled alternatives: '# Label' -> <Label>Context class must exist in parser
$labels = [regex]::Matches($g4, '#\s*([A-Za-z_][A-Za-z0-9_]*)') | ForEach-Object { $_.Groups[1].Value } | Sort-Object -Unique
foreach ($label in $labels)
{
    if ($parser -notmatch [regex]::Escape($label + 'Context'))
    {
        $missing += ('alternative context missing: ' + $label + 'Context')
    }
}

# 2) parser rules: lines like 'name:' at rule level -> Exit<Name> handler in calculator listener
$rules = [regex]::Matches($g4, '(?m)^\s*([a-z][A-Za-z0-9_]*)\s*:') | ForEach-Object { $_.Groups[1].Value } | Sort-Object -Unique
foreach ($rule in $rules)
{
    if ($parser -notmatch [regex]::Escape($rule + 'Context'))
    {
        $missing += ('rule context missing: ' + $rule + 'Context')
    }
}

# 3) lexer tokens: 'NAME: literal;' -> constant in lexer
$tokens = [regex]::Matches($g4, '(?m)^\s*([A-Z][A-Za-z0-9_]*)\s*:') | ForEach-Object { $_.Groups[1].Value } | Sort-Object -Unique
foreach ($token in $tokens)
{
    if ($lexer -notmatch ('\b' + [regex]::Escape($token) + '\s*=\s*[0-9-]+'))
    {
        $missing += ('token constant missing: ' + $token)
    }
}

Write-Output ('alternatives checked: ' + $labels.Count)
Write-Output ('parser rules checked: ' + $rules.Count)
Write-Output ('tokens checked: ' + $tokens.Count)
if ($missing.Count -eq 0)
{
    Write-Output 'RESULT: OK - grammar matches generated code'
}
else
{
    Write-Output ('RESULT: MISMATCHES:')
    $missing | ForEach-Object { Write-Output ('  ' + $_) }
}
