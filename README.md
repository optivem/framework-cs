## Atomiv

[![Build Status](https://img.shields.io/appveyor/ci/optivem/framework-dotnetcore.svg)](https://ci.appveyor.com/project/optivem/framework-dotnetcore)
[![Build Status](https://dev.azure.com/optivem/Optivem%20Framework/_apis/build/status/optivem.framework-dotnetcore?branchName=develop)](https://dev.azure.com/optivem/Optivem%20Framework/_build/latest?definitionId=1&branchName=develop)
[![Build Status](https://dev.azure.com/optivem/Optivem%20Framework/_apis/build/status/optivem.framework-dotnetcore?branchName=master)](https://dev.azure.com/optivem/Optivem%20Framework/_build/latest?definitionId=1&branchName=master)
[![MIT License](http://img.shields.io/badge/license-MIT-brightgreen.svg)](http://opensource.org/licenses/MIT)

Welcome to the Atomiv! The Atomiv was created to help you increase code quality, help you deliver products faster to customers and reduce your overall software development cost. This documentation page will show you how to get up-and-running with the Atomiv in your .NET Core 2.2 software projects. 

## Table of Contents

* [Introduction](#introduction)
* [Getting Started](#getting-started)
* [Technical Reference](#technical-reference)
* [Getting support](#support)
* [License](#license)

## Introduction

Atomiv was created to accelerate the development of enterprise applications, so that you can quickly create new projects for your customers.

The Atomiv is founded upon Clean Architecture principles and supports:
* Modularity & re-usability
* Extensibility & flexibility
* Maintainability & testibility
* Scalability and portability

The architecture consists of the following layers:
* Core Layer (contains Domain and Application)
* Infrastructure Layer (contains third-party libraries and frameworks, integration with external systems)
* Dependency Injection Layer (used to setup the compostion root)
* Web Layer (contains the REST API and presentation)
* Test Layer (contains Unit, Integration and System tests)

## Technical Reference

### Atomiv Core

* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Core.Common.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Core.Common) Optivem.Atomiv.Core.Common
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Core.Domain.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Core.Domain) Optivem.Atomiv.Core.Domain
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Core.Application.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Core.Application) Optivem.Atomiv.Core.Application
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Core.Application.Interface.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Core.Application.Interface) Optivem.Atomiv.Core.Application.Interface
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Core.All.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Core.All) Optivem.Atomiv.Core.All

### Atomiv Infrastructure

* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.AspNetCore.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.AspNetCore) Optivem.Atomiv.Infrastructure.AspNetCore
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.AutoMapper.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.AutoMapper) Optivem.Atomiv.Infrastructure.AutoMapper
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.CsvHelper.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.CsvHelper) Optivem.Atomiv.Infrastructure.CsvHelper
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.EntityFrameworkCore.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.EntityFrameworkCore) Optivem.Atomiv.Infrastructure.EntityFrameworkCore
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.FluentValidation.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.FluentValidation) Optivem.Atomiv.Infrastructure.FluentValidation
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.MediatR.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.MediatR) Optivem.Atomiv.Infrastructure.MediatR
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.NewtonsoftJson.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.NewtonsoftJson) Optivem.Atomiv.Infrastructure.NewtonsoftJson
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.Selenium.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.Selenium) Optivem.Atomiv.Infrastructure.Selenium
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Infrastructure.System.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Infrastructure.System) Optivem.Atomiv.Infrastructure.System
	
<!-- Infrastructure.EPPlus -->

### Atomiv Dependency Injection

* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Common.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Common) Optivem.Atomiv.DependencyInjection.Common
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Core.Domain.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Core.Domain) Optivem.Atomiv.DependencyInjection.Core.Domain
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Core.Application.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Core.Application) Optivem.Atomiv.DependencyInjection.Core.Application
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Infrastructure.AutoMapper.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Infrastructure.AutoMapper) Optivem.Atomiv.DependencyInjection.Infrastructure.AutoMapper
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Infrastructure.EntityFrameworkCore.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Infrastructure.EntityFrameworkCore) Optivem.Atomiv.DependencyInjection.Infrastructure.EntityFrameworkCore
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Infrastructure.FluentValidation.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Infrastructure.FluentValidation) Optivem.Atomiv.DependencyInjection.Infrastructure.FluentValidation
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Infrastructure.MediatR.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Infrastructure.MediatR) Optivem.Atomiv.DependencyInjection.Infrastructure.MediatR
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.DependencyInjection.Infrastructure.NewtonsoftJson.svg)](https://www.nuget.org/packages/Optivem.Atomiv.DependencyInjection.Infrastructure.NewtonsoftJson) Optivem.Atomiv.DependencyInjection.Infrastructure.NewtonsoftJson


    <!-- 
	Infrastructure.AspNetCore
	'src\DependencyInjection\Infrastructure\CsvHelper\Optivem.Atomiv.DependencyInjection.Infrastructure.CsvHelper.csproj',		
    # 'src\DependencyInjection\Infrastructure\EPPlus\Optivem.Atomiv.DependencyInjection.Infrastructure.EPPlus.csproj',
    # 'src\DependencyInjection\Infrastructure\Selenium\Optivem.Atomiv.DependencyInjection.Infrastructure.Selenium.csproj',		
    # 'src\DependencyInjection\Infrastructure\System\Optivem.Atomiv.DependencyInjection.Infrastructure.System.csproj',	
	-->

### Atomiv Web

* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Web.AspNetCore.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Web.AspNetCore) Optivem.Atomiv.Web.AspNetCore

### Atomiv Test

* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Test.AspNetCore.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Test.AspNetCore) Optivem.Atomiv.Test.AspNetCore
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Test.EntityFrameworkCore.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Test.EntityFrameworkCore) Optivem.Atomiv.Test.EntityFrameworkCore
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Test.FluentAssertions.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Test.FluentAssertions) Optivem.Atomiv.Test.FluentAssertions
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Test.MicrosoftExtensions.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Test.MicrosoftExtensions) Optivem.Atomiv.Test.MicrosoftExtensions
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Test.Selenium.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Test.Selenium) Optivem.Atomiv.Test.Selenium
* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Test.Xunit.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Test.Xunit) Optivem.Atomiv.Test.Xunit

### Optivem Template

* [![NuGet](https://img.shields.io/nuget/v/Optivem.Atomiv.Templates.svg)](https://www.nuget.org/packages/Optivem.Atomiv.Templates) Optivem.Atomiv.Templates

## Getting support

To report any issues and bugs, or if you have any suggestions for improvements and new features, please create a ticket using the Issue Tracker: [github.com/optivem/framework-dotnetcore/issues](https://github.com/optivem/framework-dotnetcore/issues).

<a name="license" />
## License

Licensed under the [MIT license](http://opensource.org/licenses/mit-license.php). This means you're free to use it for commercial and non-commercial purposes.

## Copyright

Copyright © 2020 [Optivem](https://www.optivem.com/) All Rights Reserved.
