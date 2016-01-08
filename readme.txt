install dnvm if not already
    @powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"
 install DNX for .net core
    dnvm upgrade -r coreclr
    
 install DNX for full .net framework
    dnvm upgrade -r clr
    
run 'dnu restore' in the src folder
run 'dnu web' to launch the web application
browser to http://localhost:5000 to see the application welcome page