@ECHO OFF
echo Deploying Addins to PMN

rmdir PlanMyNight.Web\Views\Areas\* /s /q

call PackageAddin PlanMyNight.AddIns.EmailItinerary PlanMyNight.Web\Areas
call PackageAddin PlanMyNight.AddIns.PrintItinerary PlanMyNight.Web\Areas
call PackageAddin PlanMyNight.AddIns.Share PlanMyNight.Web\Areas