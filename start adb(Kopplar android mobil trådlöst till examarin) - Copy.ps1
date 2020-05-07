# Get script path
$scriptpath = Split-Path $MyInvocation.MyCommand.Path

# Start docker DB container
invoke-expression "cmd /c start powershell -Command {Set-Location 'C:\Program Files (x86)\Android\android-sdk\platform-tools\'; .\adb connect 192.168.4.41}"