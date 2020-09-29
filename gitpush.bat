@ECHO OFF

if "%~1"=="" SET CommitMessage=update
if "%~1" NEQ "" SET CommitMessage=%1

git add .

git commit -m %CommitMessage%

git push


set PathCurrentDirectory=%~dp0

for %%I in (.) do set CurrentDirectory=%%~nxI

for %%a IN ("%PathCurrentDirectory:~0,-1%") DO set PathParentCurrentDirectory=%%~dpa

set DeploymentFilesDirectory=%PathCurrentDirectory%build\wwwroot

set GitHubIoDirectory=%PathParentCurrentDirectory%%CurrentDirectory%.github.io

dotnet publish --configuration Release --output build

robocopy "%DeploymentFilesDirectory%" "%GitHubIoDirectory%" /e

cd %GitHubIoDirectory%

git add .

for /f "tokens=2-4 delims=/ " %%a in ('date /t') do (set date=%%c-%%a-%%b)
for /f "tokens=1-2 delims=/:" %%a in ("%TIME%") do (set time=%%a%%b)

git commit -m "commit-%date%-%time%"

git push

cd %PathCurrentDirectory%

exit /b