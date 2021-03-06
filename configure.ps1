﻿Write-Host "Starting updates..."

$filePath = 'template\\microservice\\test\\Web\\Atomiv.Template.Web.RestApi.IntegrationTest\\appsettings.Test.json'

Write-Host "File path is: $filePath"

$filePathExists = Test-Path -Path $filePath

if(!$filePathExists)
{
	Write-Error -Message "File path does not exist: $filePath"  -ErrorAction Stop
}

$connection = 'Server=(local)\SQL2017;Database=Atomiv.Template;User ID=sa;Password=Password12!;MultipleActiveResultSets=True;'

Write-Host "Connection is: $connection"

$json = (Get-Content -Path $filePath) | ConvertFrom-Json

Write-Host "JSON is: $json"

$json.ConnectionStrings.DefaultConnection = $connection

Write-Host "Updated JSON is $json"

$json | ConvertTo-Json | Set-Content $filePath

Write-Host "File has been updated"

$Env:ASPNETCORE_ENVIRONMENT="Staging"

Write-Host "Set ENVIRONMENT"