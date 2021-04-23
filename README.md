# V1C8
Модуль для работы с 1С8.3 через COMConnections.
[![MIT License](https://img.shields.io/badge/license-MIT-red.svg)](https://github.com/sabatex/V1C8/blob/master/LICENSE.TXT)
[![NuGet Badge](https://buildstats.info/nuget/sabatex.V1C8)](https://www.nuget.org/packages/sabatex.V1C8/)

Install
Package Manager> Install-Package sabatex.V1C8 -Version 5.0.1
or
> dotnet add package sabatex.V1C8 --version 5.0.1
or in *.csproj
<PackageReference Include="sabatex.V1C8" Version="5.0.1" />

как пользоваться?
<code>
// создаём соединение
using (var globalContext = COMObject1C8.CreateConnection("ConnectionString1C8")
{
    // получаем документ 
    var doc = globalContext.GetProperty<ICOMObject1C8>("Documents").GetProperty<ICOMObject1C8>("РасходнаяНакладная").Method<ICOMObject1C8>("FindByNumber", "0000001", new DateTime(2021,01,01));
    

}
</code>
ICOMObject1C8 визначає методи:
    GetProperty<T>("PropertyName") - отримати властивість
    Set
    
