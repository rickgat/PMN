function SearchUninstall($SearchFor)
{
$uninstall = "HKLM:SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\"
$uninstallObjects = ls -path $uninstall ;
$found = $FALSE;

foreach($uninstallEntry in  $uninstallObjects)
{
   $entryProperty = Get-ItemProperty -path registry::$uninstallEntry
   if($entryProperty.DisplayName -like $searchFor)
    {       
       $found = $TRUE;
       break;
    }
}

$found;
}

SearchUninstall -SearchFor 'Microsoft Visual Studio 2010 Tools for ASP.NET MVC 1.1';

