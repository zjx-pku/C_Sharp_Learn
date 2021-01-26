[TOC]



# 第一章  C#简介

## `.NET Framework`的含义

`.NET Framework`是Microsoft为开发应用程序而创建的一个具有革命意义的平台

- 可以运行在多个操作系统上：`Windows`,`Windows Mobile`, `Linux`, `macOS`
- 未限制应用程序的类型：`桌面应用程序`、`Windows桌面应用程序（UWP）`、`云/Web应用程序`、`Web API`、`其他各种类型的应用程序`
  - 对于Web、云和Web API应用程序，按照定义是多平台的应用程序，因为任何带有Web浏览器的系统都可以访问
- 可以用于各种语言：`C#`, `C++`, `F#`, `JavaScript`, `Visual Basic`, `COBOL`及其他旧语言

### `.NET Framework`的内容

- ``.NET Framwork`主要包含一个庞大的`代码库`，可以在客户端或服务器语言中通过面向对象编程技术（Object-Oriented Programming, OOP）来使用这些代码。
- **模块**：代码库分为多个不同的模块，这样就可以根据希望得到的结果来选择使用其中的各个部分，一些模块还分为更具体的子模块。主要是为了满足不同的操作系统可以根据各自的特征支持其中的部分或全部模块。
- **通用类型系统(Common Type System, CTS)**：部分`.NET Framwork`库定义了一些基本类型，类型是数据的一种表达方式，指定最基本类型有助于`.NET Framwork`的各种语言之间进行交互操作，这称为通用类型系统
- **.NET 公共语言运行库(Common Language Runtime, CLR)**：除了基本类型库之外，``.NET Framwork`还包含.NET公共语言运行库，负责管理用.NET库开发的所有应用程序的执行。

### `.NET Standard`和`.NET Core`

- **开源分支**：Github上，项目可以被分支并在多个平台上定制运行。`.NET Compact Framework`和`.NET Micro Framework`是`.NET Framework`的分支，每个`.NET Framework`的分支都有一个具体的需求和目标，正是这些需求和目标催生了对应的分支。
  - `.NET Core`是进行跨平台代码开发的最优化解决方案
- **基类库(Base Class Libraries, BCL)**：`.NET Framework`中包含一组基类库(BCL)，这些库中包含的API用于大多数开发人员需要完成的基本功能。在不同版本的`.NET Framework`中这些功能的实现是不同的。因此需要开发人员根据应用程序运行的平台，针对对应用程序的不同分支或版本去学习、开发和管理多个基类库(BCL)。分支概念导致了更多`.NET Framework`版本的出现，因此需要一组基本编程API来处理各种分支和版本。
  - `.NET Standard`可以解决上述问题，它是一个类库，它提供的API支持使用了`.NET Platform`的应用程序的任何分支和版本

### 使用`.NET Framework`和`.NET Core`编写应用程序

- **实质**：使用`.NET Framework`和`.NET Core`编写应用程序就是使用支持`.NET Framework`的任何一种语言使用`.NET代码库·`编写代码。

- **IDE**：本书使用Visual Studio进行开发，是一种强大的集成开发环境，支持C#（以及托管和非托管C++，Visual Basic和其他一些语言）。这个环境的优点是便于将.NET 功能集成到代码中，我们创建的代码完全是C#代码，但是使用了`.NET Framework`，并在需要的时候利用了Visual Studio中的其他工具

- **编译**：为了执行C#代码，必须把它们转换为目标操作系统能理解的语言，即**本机代码(native code)**。这一过程叫做**编译(compiling)代码**，由编译器执行。在`.NET Framework`和`.NET Core`下，这个过程包括两个阶段：

  1. **CIL和JIT**

     - 使用`.NET Framework`和`.NET Core`库编写的代码$\longrightarrow$通用中间语言(common Intermediate Language, CIL)$\longrightarrow$本机代码(native code)
     - **通用中间语言(common Intermediate Language, CIL)**：并非专门用于任何一种操作系统，也并非专门用于C#，其他.NET语言也会在第一阶段编译为这种语言。开发C#应用程序时，这个编译步骤由Visual Studio完成
     - **Just-in-time编译器**：JIT负责把CIL编译为专用于OS和目标机器架构的本机代码，这样OS才能够执行应用程序

  2. **程序集(assembly)**

     - 编译应用程序时，所创建的CIL代码存储在一个程序集中.程序集中包括可执行的应用程序文件(`.exe`)、其他应用程序使用的库(`.dll`)、元信息（程序集包含的信息）、一些可选资源（CIl使用的其他数据：声音文件和图片等）

       - 元信息允许程序集是完全自描述的，不需要其他信息就可以使用程序集。也就是说，我们不会遇到没有把需要的数据添加到系统注册表中这样的问题，而在使用其他平台进行开发时这个问题常常会出现

       - 部署应用程序只需要把文件复制到远程计算机上，因为不需要目标系统上的其他信息。

         > 针对`.NET Framework`的应用程序，只需要从该目录中运行可执行文件即可（假定安装了.NET CIL），而针对`.NET Core`的应用程序，运行 该程序需要的所有模块都包含在部署包内，不需要进行其他配置

     - **全局程序集缓存(Global Assembly Cache, GAC)**：在`.NET Framework`中一些代码可以被多个应用程序重用，这些可重用的代码放在所有应用程序都可以访问的地方，也就是全局程序集缓存。只需要把包含代码的程序集放在该缓存的目录下即可实现把代码放在缓存中。

  3. **托管代码**

     - **托管功能：**将代码编译为本机代码后，CLR/CoreCLR还需要管理正在执行的代码，方式是管理内存、处理安全性以及允许进行跨语言调试等。在C#中，我们编写的代码将使用CLR/CoreCLR的托管功能让.NET处理与操作系统的任何交互

  4. **垃圾回收**

     - 托管代码的最重要的功能是垃圾回收，这一.NET方法可以确保应用程序不在使用某些内存时就会完全释放这些内存

  5. **把它们组合在一起**

     - 使用.NET兼容语言（如C#）编写*应用程序代码*
     - 将代码编译为*CIL*，存储在程序集中
     - 在执行代码时（如果这是一个可执行文件就自动运行，或者在其他代码使用它时运行），首先必须使用JIT编译器将代码编译为*本机代码*
     - 在托管的CLR/CoreCLR环境中*运行本机代码*以及其他应用程序或进程

  6. **链接(Linking)**

     - 在上述第2步中的C#代码未必在一个单独的文件中，可以把应用程序代码放在多个源代码文件中，再把它们编译到一个单独的程序集中，这个过程叫做链接(linking)

## C#的含义

C#语言是一种类型安全的语言，在类型之间转换时，必须遵守严格的规则。执行相同的任务时，用C#编写的代码往往比C++编写的代码要长，但C#代码更加健壮，调试起来也比较简单，.NET始终可以准送数据的类型

### 用C#可以编写什么样的应用程序

`.NET Framework`没有限制应用程序的类型，C#使用的是`.NET Framework`，因此也没有限制应用程序类型，实际上目前使用.NET Core只可以编写Console和ASP.NET应用程序

- 桌面应用程序：这些应用程序（如Microsoft Office）具有我们很熟悉的Windows外观和操作方式，使用.NET Framework的Windows Presentation Foundation(WPF)模块就可以简便地生成这种应用程序。WPF是一个控件库8，其中的控件（如按钮、工具栏、菜单等）而用于建立Windows用户界面(UI)
- Windows Store应用程序：这是Windows8中引入的一类新的应用程序，此类应用程序主要针对触摸设备设计，通常全屏运行，侧重点在简洁清晰。创建这类应用程序的方式有很多种，包括使用WPF
- 云/Web应用程序：`.NET Framework`和`.NET Core`包括一个动态生成Web内容的强大系统——ASP.NET，允许进行个性化和实现安全性等。另外，这些应用程序可以在云中驻留和访问，例如Microsoft Azure平台
- Web API：这是建立REST风格的HTTP服务的理想框架，支持许多客户端，包括移动设备和浏览器
- WCF服务：这是一种灵活创建各种分布式应用程序的方式，使用WCF服务可以通过局域网或Internet交换几乎各种数据。无论使用声明语言创建WCF服务，也无论WCF服务驻留在什么系统上，都使用一种简单的语法

这些类型的应用程序也可能需要某种形式的数据库访问，这可以通过.NET Framework的Active Data Object .NET(ADO.NET)部分，ADO.NET Entity Framework或C#的LINQ(Language Integrated Query)功能来实现。对于需要数据库访问的.NET Core应用程序将使用ENtity Framework Core库。也可以使用许多其他资源。例如，创建联网组件、输出图形、执行复杂数学任务的工具来实现。

## Visual Studio 2017

## 本章要点

|               主题                |                             要点                             |
| :-------------------------------: | :----------------------------------------------------------: |
| `.NET Framework`和`.NET Core`基础 | `.NET Framework`是Microsoft最新的开发平台，目前的版本是4.7。它包括一个公共类型库(CTS)和一个公共语言类型库(CLR/CoreCLR)。`.NET Framework`应用程序使用面向对象编程的方法论进行编写，通常包含托管代码、托管代码的内存管理有.NET运行库处理，其中包括垃圾回收。 |
|     `.NET Framework`应用程序      | 用`.NET Framework`编写的应用程序首先编译为CIL，在执行应用程序时，JIT把CIL编译为本机代码。应用程序编译后，把不同部分链接到包含CIL的程序集中。 |
|        `.NET Core`应用程序        | `.NET Core`应用程序的工作方式与`.NET Framework`应用程序类似，但不使用CLR，而是使用CoreCLR |
|          `.NET Standard`          | `.NET Standard`提供了一个统一的类库，多个.NET平台（如`.NET Framework`,`.NET Core`,`Xamarin`）都可以将它作为目标 |
|              C#基础               | C#是包含在`.NET Framework`中的一种语言，是已有语言（如C++）的一种演变，可用来编写任意应用程序，包括Web应用程序、跨平台应用程序、桌面应用程序 |
|         集成开发环境(IDE)         | 可在Visual Studio 2017中用C#编写任意类型的.NET应用程序，还可以子免费的但功能稍弱的Community产品中用C#创建.NET应用程序。IDE使用解决方案，解决方案可以包含多个项目。 |

# 第二章 编写C#应用程序

|          主题          |                             要点                             |
| :--------------------: | :----------------------------------------------------------: |
| Visual Studio 2017设置 | 本书需要在第一次运行Visual Studio2017时厕C# Development Setting选项或者重置它们 |
|     控制台应用程序     | 控制台应用程序是最简单的命令行应用程序，本书主要通过它来演示技术。在Visual Studio中创建新项目时，，使用Console Application模板就会创建新的控制台应用程序。要在调试模式下运行项目，可以使用“调试\|开始调试”或者按下F5 |
|        IDE窗口         | 项目内容显示在项目资源管理器窗口中，所选中项的属性在属性窗口中，错误提示在错误列表中 |
|      桌面应用程序      | 桌面应用程序具备标准Windows应用程序的外观和操作方式，包括最大化、最小化和关闭应用程序等大家熟悉的图标。它们是在New Project对话框中使用WPF Application模板创建的 |

