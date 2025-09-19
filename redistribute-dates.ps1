# Redistribute commit dates in PowerShell (bulletproof version)
# Run: powershell -ExecutionPolicy Bypass -File redistribute-dates.ps1

# ==== SETTINGS (edit these) ====
$YourName  = "Corey Crooks"
$YourEmail = "your-email@example.com"   # must match GitHub profile email
# ================================

# Get all commit SHAs (oldest first)
$commits = git rev-list --reverse HEAD
$total = $commits.Count
Write-Host "Found $total commits."

# Start from today
$currentDate = Get-Date

# Helper: is weekend?
function Is-Weekend($date) {
    return ($date.DayOfWeek -eq "Saturday" -or $date.DayOfWeek -eq "Sunday")
}

# Generate a list of new dates
$dates = @()
$i = 0
while ($i -lt $total) {
    # Step back 1–3 days randomly
    $step = Get-Random -Minimum 1 -Maximum 4
    $currentDate = $currentDate.AddDays(-$step)

    # Skip weekends 80% of time
    if (Is-Weekend $currentDate) {
        if ((Get-Random -Minimum 0 -Maximum 10) -ge 2) {
            while (Is-Weekend $currentDate) {
                $currentDate = $currentDate.AddDays(-1)
            }
        }
    }

    # Occasionally group multiple commits on same day
    if ((Get-Random -Minimum 0 -Maximum 10) -lt 2) {
        $groupSize = Get-Random -Minimum 2 -Maximum 5
        for ($g=0; $g -lt $groupSize -and $i -lt $total; $g++) {
            $dates += $currentDate
            $i++
        }
    } else {
        $dates += $currentDate
        $i++
    }
}

# Reverse (so dates match oldest→newest order)
$dates = $dates[($dates.Length-1)..0]

Write-Host "Generated $($dates.Length) dates. Rewriting commits..."

# Rewrite each commit
$newBranch = "rebased-dates"
git checkout --orphan $newBranch

for ($j=0; $j -lt $commits.Length; $j++) {
    $sha = $commits[$j]
    $date = $dates[$j].ToString("yyyy-MM-dd HH:mm:ss")
    Write-Host "Rewriting commit $($j+1)/$total ($sha) → $date"

    # Checkout commit tree
    git checkout $sha -- .

    # Apply new metadata
    $env:GIT_AUTHOR_NAME     = $YourName
    $env:GIT_AUTHOR_EMAIL    = $YourEmail
    $env:GIT_AUTHOR_DATE     = $date
    $env:GIT_COMMITTER_NAME  = $YourName
    $env:GIT_COMMITTER_EMAIL = $YourEmail
    $env:GIT_COMMITTER_DATE  = $date

    git commit -m "$(git log -1 --pretty=%B $sha)"
    git rm -r --cached . > $null 2>&1
}

Write-Host "All commits rewritten onto branch '$newBranch'."
Write-Host "Next step: run this command to update your GitHub repo:"
Write-Host "    git push --force origin $newBranch:main"
