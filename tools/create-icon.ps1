# Generates the NuGet package icon (icon.png) for EveryParser.Net.
# Run from anywhere: powershell -File tools\create-icon.ps1
Add-Type -AssemblyName System.Drawing

$size = 256
$bmp = New-Object System.Drawing.Bitmap($size, $size)
$g = [System.Drawing.Graphics]::FromImage($bmp)
$g.SmoothingMode = [System.Drawing.Drawing2D.SmoothingMode]::AntiAlias
$g.TextRenderingHint = [System.Drawing.Text.TextRenderingHint]::AntiAlias

# Rounded rectangle background
$path = New-Object System.Drawing.Drawing2D.GraphicsPath
$m = 12   # margin
$r = 56   # corner radius
$x = $m; $y = $m; $w = $size - 2 * $m; $h = $size - 2 * $m
$path.AddArc($x, $y, $r, $r, 180, 90)
$path.AddArc($x + $w - $r, $y, $r, $r, 270, 90)
$path.AddArc($x + $w - $r, $y + $h - $r, $r, $r, 0, 90)
$path.AddArc($x, $y + $h - $r, $r, $r, 90, 90)
$path.CloseFigure()

$brush = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::FromArgb(255, 40, 53, 147))
$g.FillPath($brush, $path)

# Draw "f(x)"
$font = New-Object System.Drawing.Font('Georgia', 68, [System.Drawing.FontStyle]::Bold)
$fmt = New-Object System.Drawing.StringFormat
$fmt.Alignment = [System.Drawing.StringAlignment]::Center
$fmt.LineAlignment = [System.Drawing.StringAlignment]::Center
$box = New-Object System.Drawing.RectangleF(0, 0, $size, $size)
$g.DrawString('f(x)', $font, [System.Drawing.Brushes]::White, $box, $fmt)

$g.Dispose()
$out = Join-Path $PSScriptRoot '..\icon.png'
$bmp.Save($out, [System.Drawing.Imaging.ImageFormat]::Png)
$bmp.Dispose()
Write-Host "Icon written to $out"