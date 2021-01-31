

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

# 第三章 变量和表达式

## C#的基本语法

- **空白字符**：C#编译器不考虑代码中的空格、回车符、制表符，它们统称为空白字符

- **分号**：C#代码由一系列语句组成，每条语句以一个分号结束。一行可以有多条语句

- **块结构**：C#是一种块结构的语言，所有语句都是代码块的一部分。使用花括号来界定代码块，代码块中可以包含任意多行语句。代码块末尾不需要加分号

- **注释**

  - 单行注释

    ```c#
    // 这是单行注释
    ```

  - 多行注释

    ```c#
    /*这是
    多行注释
    */
    ```

  - 第三类注释

    ```c#
    ///这是第三类注释，通过配置Visual Studio可以在编译项目时提取注释后面的文本
    ///创建一个特殊格式的文本文件，该文件可以用来创建文档
    ```

- **大小写敏感**：C#语言是严格区分大小写的

## 变量及其用法

### 简单类型

> 简单类型就是组成应用程序中基本构件的类型，例如数值和布尔值。与复杂类型不同，简单类型没有子类型或特性，大多数简单类型都是存储数值的。

#### 整数类型

|  类型  |     别名      |                允许的值                 |
| :----: | :-----------: | :-------------------------------------: |
| sbyte  | System.SByte  |                -128~127                 |
|  byte  |  System.Byte  |                  0~255                  |
| short  | System.Int16  |              -32768~32767               |
| ushort | System.UInt16 |                 0~65535                 |
|  int   | System.Int32  |         -2147483648~2147483647          |
|  uint  | System.UInt32 |              0~4294967295               |
|  long  | System.Int64  | -9223372036854775808~922372036854775807 |
| ulong  | System.UInt64 |         0~18446744073709551615          |

- $2^8=256$
- $2^{16} = 65536$
- $2^{32} = 4294967296$
- $2^{32} =  18446744073709551616$

这些类型中的每一种都利用了`.NET Framework`中定义的标准类型，使用标准类型可以在语言之间交互操作。在C#中这些类型的名称是Framework中定义的类型的别名。

#### 浮点类型

|  类型   |      别名      | m的最小值 | m的最大值 | e的最小值 | e的最大值 |     近似的最小值      |     近似的最大值     |
| :-----: | :------------: | :-------: | :-------: | :-------: | :-------: | :-------------------: | :------------------: |
|  float  | System.Single  |    $0$    | $2^{24}$  |  $-149$   |   $104$   | $1.5\times 10^{-45}$  |  $3.4\times10^{38}$  |
| double  | System.Double  |    $0$    | $2^{53}$  |  $-1057$  |   $970$   | $5.0\times 10^{-324}$ | $1.7\times 10^{308}$ |
| decimal | System.Decimal |    $0$    | $2^{96}$  |   $-28$   |    $0$    | $1.0\times 10^{-28}$  | $7.9\times 10^{28}$  |

- float和double存储浮点数的方式为$\pm m \times 2^e$
- decimal存储浮点数的方式为$\pm m\times 10^e$

#### 文本和布尔类型

|  类型  |      别名      |                 允许的值                 |
| :----: | :------------: | :--------------------------------------: |
|  char  |  System.Char   | 一个Unicode字符，存储在0~65535之间的整数 |
|  bool  | System.Boolean |           布尔值：true或false            |
| string | System.String  |               一个字符序列               |

- string的字符数量没有上限，因为它可以使用可变大小的内存

### 变量的命名

- 变量的第一个字母必须是字符、下划线或@
- 其后的字符可以是字母、下划线或数字

### 字面值

|        类型         |  类别  |          后缀           |       实例/允许的值       |
| :-----------------: | :----: | :---------------------: | :-----------------------: |
|        bool         |  布尔  |           无            |        true和false        |
| int,uint,long,ulong |  整数  |           无            |            100            |
|     uint,ulong      |  整数  |           u,U           |           100U            |
|     long,ulong      |  整数  |           l,L           |           100L            |
|        ulong        |  整数  | ul,uL,Ul,UL,lu,lU,Lu,LU |           100UL           |
|        float        |  实数  |           f,F           |           1.5F            |
|       double        |  实数  |        无, d, D         |            1.5            |
|       decimal       |  实数  |          m, M           |           1.5M            |
|        char         |  字符  |           无            |       'a'或转义序列       |
|       string        | 字符串 |           无            | 'a...a'，可以包含转义序列 |

#### 二进制字面值与数字分隔符

- 二进制模式匹配和位掩码

- C#7中的二进制字面值

  ```c#
  int [] numbers = [1, 2, 4, 8, 16];
  int [] numbers  = [ob00001, ob00010, ob00100, ob01000, ob10000];
  ```

- C#7中的数字分隔符

  ```c#
  int [] numbers = [32, 64, 128];
  int [] numbers = [ob0010_0000, ob0100_0000, ob1000_0000];
  public const double Pi = 3.141_592_653_589_793_238_462_643_383_279_502;
  ```

#### 字符串字面值

**字符串字面值的转义序列**

| 转义序列 |    产生的字符    | 字符从Unicode值 |
| :------: | :--------------: | :-------------: |
|   \\'    |      单引号      |     0x0027      |
|   \\"    |      双引号      |     0x0022      |
|   \\\    |      反斜杠      |     0x005C      |
|   \\0    |       null       |     0x0000      |
|   \\a    | 警告（产生蜂鸣） |     0x0007      |
|   \\b    |       退格       |     0x0008      |
|   \\f    |       换页       |     0x000C      |
|   \\n    |       换行       |     0x000A      |
|   \\r    |       回车       |     0x000D      |
|   \\t    |    水平制表符    |     0x0009      |
|   \\v    |    垂直制表符    |     0x000B      |

- 字符的Unicode值指的是字符在Unicode字符集中的十六进制值值
- 转移序列包括标准的\\字符后面跟一个u和一个4位十六进制值

```c#
"Benjamin\'s string"
"Benjmin\u0027s string"
```

**一字不变地引用字符串**

反斜杠

```c#
@“C:\Users\srxh\Desktop\C_Sharp_Learn”
"C:\\Users\\srxh\\Desktop\\C_Sharp_Learn"
```

多行字符串

```c#
@"A short list；
item 1
item 2"
```

字符串是引用类型，本章中的其他类型都是值类型，所以字符串也可以被赋值为null值，表示字符串变量不引用字符串（或其他东西）

## 表达式及其用法

- 把操作数（变量和字面值）和运算符组合起来就可以创建表达式，它是计算的基本构件，C#中包含许多执行这类处理的运算符
- 运算符包括：数学运算符、逻辑运算符、赋值运算符、其他复杂的二进制运算符
- 预算符大致分为三类：一元运算符（几个）、二元运算符（最常见）、三元运算符（只有一个，即条件运算符）

### 数学运算符

#### 二元运算符

$+$：数学加法，字符串连接

$-$：数学减法

$*$：数学乘法

$/$：数学除法

$\%$：取余数

#### 一元运算符

$+$：某数乘以1

$-$：某数乘以-1

#### 递增和递减运算符

```c#
var1 = var2 ++; // var1值为var2, var2递增1
var1 = var2 --; // var1值为var2, var2递减1
var1 = ++ var2; // var1值为var2 + 1, var2递增1
var1 = -- var2; // var1值为var2 - 1, var2递减1
```

### 赋值运算符

$=$：

```c#
var1 = var2;
```

$-=$：

```c#
var1 -= var2;// var1 = var1 - var2
```

$+=$：

```c#
var1 += var2;// var1 = var1 + var2
```

$*=$：

```c#
var1 *= var2;// var1 = var1 * var2
```

$/=$：

```c#
var1 /= var2;// var1 = var1 / var2
```

$\%=$：

```c#
var1 %= var2;// var1 = var1 % var2
```

### 运算符的优先级

**运算符由高到低**：

| 运算符                                 |
| -------------------------------------- |
| ++, --（用作前缀）；+, -（一元运算符） |
| *, /, %                                |
| +, -                                   |
| =, *=, /=, %=, +=, -=                  |
| ++, --（用作后缀）                     |

括号可以重写运算符优先级

### 名称空间

> 名称空间是.NET中提供应用程序代码容器的方式，这样就可以唯一地标识代码及其内容。名称空间也用作`.NET Framework`中给项分类的一种方式。大多数项都是类型定义，例如System.Int32

- namesapce关键字为花括号中的代码块显式定义名称空间
- C#代码包含在全局名称空间中，对于包含在这段代码中的项，全局名称空间中的其他代码只要通过名称进行引用，就可以访问它们
- 在名称空间代码的外部使用名称空间中的名称，就必须写出该名称空间中的限定名称
  - 限定名称包括它所有的分层信息，在不同名称空间级别之间使用句点字符 
- using语句本身不能访问另一个名称空间中的名称，除非名称空间中的代码已某种方式链接到项目上，或者代码是在该项目的源文件中定义的，或者是在链接到该项目的其他代码中定义的，否则就不能访问其中包含的名称。另外，如果包含名称空间的代码连接到项目上，那么无论是否使用using，都可以访问其中包含的名称。using语句便于我们访问这些名称，减少代码量以及提高可读性

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
```

- 以`using`关键字开头的5段代码声明在这段C#代码中使用System, System.Collections.Generic, System.Linq, System.Text, System.Threading.Tasks名称空间，它们可以在该文件的所有名称空间中访问，不必进行限定

- System名称空间是`.NET Framework`应用程序的根名称空间，包含控制台应用程序需要的所有基本功能

- 其他四个名称空间常用于控制台应用程序，所有该程序包含了它们

- C#6新增了`using static`关键字，允许把静态成员直接包含到C#程序的作用域中

  ```c#
  ...
  using static Syatem.Console;
  ...
  {
      ...
      WriteLine("不需要添加静态类名System.Console");
      ...
  }
  ```

  ## 总结

  |    主题    |                             要点                             |
  | :--------: | :----------------------------------------------------------: |
  | C#基本语法 | C#是一种区分大小写的语言，每行代码都已分号结束，如果代码太长或者想要标识嵌套的块，可以缩进代码行以便阅读。使用//或/**/语法可以包含不便宜的注释。代码块可以隐藏到区域中，也是为了方便阅读。 |
  |    变量    | 变量是有名称和类型的数据块，`.NET Framework`定义了大量简单类型，例如数字和字符串（文本）类型，以供使用。变量只有经过声明和初始化后才能使用。可以把字面值付给变量，以初始化它们。变量还可以在单个步骤中声明和初始化 |
  |   表达式   | 表达式利用运算符和操作数来加你离，其中运算符对操作数执行操作，运算符有3种，一元、二元、三元运算符。它们分别操作1，2，3个操作数。数学运算符对数值执行操作，赋值运算符把表达式的结果放在变量种。运算符有固有的优先级，优先级确定了运算符在表达式中的处理顺序 |
  |  名称空间  | .NET应用程序中定义的所有名称，包括变量名都包含在名称空间中。名称空间采用层次结构，我们通常需要根据包含的名称空间来限定名称，以便访问它们。 |

  

# 第四章 流程控制

## 布尔逻辑的用法

**布尔比较运算符**

| 运算符 | 类别 |     示例表达式      |
| :----: | :--: | :-----------------: |
|   ==   | 二元 | var1 = var2 == var3 |
|   !=   | 二元 | var1 = var2 != var3 |
|   >    | 二元 | var1 = var2 > var3  |
|   >=   | 二元 | var1 = var2 >= var3 |
|   <    | 二元 | var1 = var2 < var3  |
|   <=   | 二元 | var1 = var2 <= var3 |

**条件布尔运算符**

|       运算符       | 类别 |      示例表达式       |
| :----------------: | :--: | :-------------------: |
|  &&（条件逻辑与）  | 二元 |  var1 = var2 && var3  |
| \|\|（条件逻辑或） | 二元 | var1 = var2 \|\| var3 |

- &&的运算结果与&相同，但是性能更好
- ||的运算结果与|相同，但是性能更好

#### 布尔按位运算符和赋值运算符

|     运算符     | 类别 |  示例表达式   |
| :------------: | :--: | :-----------: |
|  &=（逻辑与）  | 二元 | var1 &= var2  |
| \|=（逻辑或）  | 二元 | var1 \|= var2 |
| ^=（逻辑异或） | 二元 | var1 ^= var2  |

#### 运算符优先级的更新

略

## 如何控制代码的分支

### 三元运算符

**基本语法**：

```
<test> ? <resultIsTrue> : <resultIsFalse>
```

如果`test`语句真值为`True`则为`<resultIsTrue>`语句，否则为`<resultIsFalse>`语句

**示例**

```c#
bool isLessThan10 = myInteger < 10;
string myStr = isLessThan10 ? "The integer is less than 10" : "The integer is greater than 10 or equal to 10";
```

### if语句

**基本语法**

```c#
if (<test>)
{
    <code executed if <test> is true>;
}
else
{
    <code executed if >test> is false>;
}
```

**示例**

```c#
string resultString;
if (myInteger < 10)
    resultString = "The integer is less than 10";
else
    resultString = "The integer is greater than 10 or equal to 10";
```

**使用if判断更多条件**

```c#
if (var1 == 1)
{
    // Do somthing.
}
else
{
    if (var < 1)
    {
        // Do somthing
    }
    else
    {
        // Do somthing
    }
}
```

```c#
if (var1 == 1)
{
    // Do somthing
}
else if (var1 < 1)
{
    // Do somthing
}
else
{
    // Do somthing
}
```

### switch语句

```c#
switch (<testVal>)
{
    case <comparisonVal1>:
        <code to execute if <testVal> == <comparisonVal1>>;
        break;
    case <comparisonVal2>；
        <code to execute if <testVal> == <comparisonVal2>>;
        break;
    ...
    default:
        <code to execute if <testVal> != <comparisionVals>;
        break;
}
```

- `testVal`中的值与`comarisonVals`分别进行比较，如果有一个匹配，就执行为该匹配提供的语句；如果没有匹配但是有`default`语句，就执行这部分的代码。
- 执行完每部分的代码后都要有一个`break`语句，将中断switch语句执行该结构后面的语句

## 如何编写循环代码

### do循环

```c#
do
{
    <code to be looped>
} while(<Test>);
```

### while循环

```c#
while (<Test>)
{
    <code to looped>
}
```

### for循环

```c#
for(<initialization>; <condition>; <operation>)
{
    <code to loop>
}
```

等价于

```c#
<initialization>;
while(<condition>)
{
    <code to loop>;
    <operation>;
}
```

### 循环的中断

- `break：`立即终止循环
- `continue：`立即终止当前的循环（执行下一次循环）
- `return：`跳出循环及包含该循环的函数

### 无限循环

```c#
while true
{
    //code to loop
}
```

```c#
int i = 1;
while(i <= 10)
{
    if ((i % 2) == 0)
        continue;
    WriteLine($"{i++}")
}
```

> 存疑：第四章习题2

## 本章要点

|   主题   |                             要点                             |
| :------: | :----------------------------------------------------------: |
| 布尔逻辑 | 布尔逻辑使用布尔值(true 和false)计算条件。布尔运算符用于比较数值，返回布尔结果。一些布尔运算符也用于对数值的底层位结构执行按位操作，还有一些专门的按位运算符。 |
|   分支   | 可使用布尔逻辑控制程序流。计算结果为布尔值的表达式可用确定是否执行某个代码块，可以使用if语句或三元运算符(?:)进行简单的分支，或者使用switch语句同时检查多个条件 |
|   循环   | 循环允许根据指定的条件多次执行代码块。使用do循环和while循环可在布尔表达式为true时执行代码，使用for循环可在循环代码中包含一个计数器。循环可以使用continue中断当前的迭代，或使用break完全中断。一些循环只能在用户强制中断时结束，这些循环称为无限循环。 |

# 第五章 变量的更多内容

## 如何在类型之间进行隐式和显式转换

### 隐式转换

- 无论什么变量类型，所有的数据都是一系列的位，变量的含义是通过解释这些数据的方式来确定的
- **方式**：直接进行赋值

```c#
ushort destinationVar;
char sourceVar = 'a';
destinationVar = sourceVar;
WriteLine($"sourceVar:{sourceVar}");          //输出a
WriteLine($"destinationVar:{destinationVar}");//输出97
```

- **条件**：转化为的类型所存储的数字的范围要比被转化的类型所存储的数字的范围要大
  - char类型用一个数字表示Unicode字符集中的一个字符，char和ushort都存储0~65535之间的数字

### 显式转换

- **适用范围**：转化为的类型所存储的数字的范围要比被转化的类型所存储的数字的范围要小，但是被转化的数字在将要转化为的类型所存储的数字的范围之内，这时可以进行强制转换

```c#
byte destinationVar;
short sourceVar = 7;
destinationVar = (byte) sourceVar;
WriteLine($"desinationVar {destinationVar}"); // 7
WriteLine($"sourceVar {sourceVar}"); // 7
```

- **方式：**在被转化数字前面添加将要转化为的类型，之后进行赋值

### 溢出检查

- 转化为的类型所存储的数字的范围要比被转化的类型所存储的数字的范围要小，被转化的数字也在将要转化为的类型所存储的数字的范围之外，这时进行强制转换（显式转换）将会出现溢出的现象。
- 对于为表达式设置的所谓溢出检查上下文，需要用到两个关键字：`checked`和`unchecked`

```c#
byte destinationVar;
short sourceVar = 281;
destinationVar = checked((byte) sourceVar);
WriteLine($"desinationVar {destinationVar}");
WriteLine($"sourceVar {sourceVar}");
```

- `checked`会检查在类型转换中是否出现数据溢出的现象，如果出现的话程序会崩溃
- `unchecked`不会检查在类型转换中是否出现数据溢出的现象

也可以在Visual Studio中进行设置，让IDE检查是否在类型转换中出现数据溢出的现象，这时就不用`checked`关键字

具体设置方法如下：
$$
项目\rightarrow 属性\rightarrow 生成\rightarrow高级\rightarrow检查运算上溢/下溢
$$

> 这一设置可能会对程序执行速度带来一定的影响，因此当不再需要时就禁用这个设置。

### 使用`Convert`命令进行显式转换

前面的很多代码中都使用`ToDouble`将输入的字符串转化为`Double`类型的浮点数，但是字符串必须是一个数值的有效表达方式

- `可选符号（加号或减号）`+`0位或多位数字`+`可选句点`+`0位或多位数字`+`可选的e或E`+`可选符号（加号或减号）`+`一位或多位数字`
- 除了可能还有空格（在序列前或后），不能有其他字符

> 使用`Convert`进行转换，总是要进行溢出检查，`checked`和`unchecked`关键字以及上面配置的属性设置不起作用。

## 如何创建和使用枚举类型

```c#
enum <typeName> : <underlyingType>
{
    <value1> = <actualVal1>,
    <value2> = <actualVal2>,
    ...
    <valueN> = <actualValN>
}
```

- 未赋值的任何值会自动获得一个初始值，这个初始值是比上一明确声明的值大1
- 可以使用一个值作为另一个的基础值：`<value2> = <value1>`

**注意**

- 类型的定义代码放在名称空间中，与Main函数并列。

- `<valueN>`的类型为`<underlyingType>`

- 枚举类型直接输出为对应的名称

  - ```c#
    origination myDirection;
    myDirection = origination.north;
    WriteLine($"myDirection = {myDirection}"); // 输出为myDirection = north
    ```

    

- 类型转换

  ```
  enum origination : byte
  {
      north = 1,
      south = 2,
      west = 3,
      east = 4
  }
  ```

  - 枚举类型转化为基本类型

    - ```c#
      origination myDirection;
      myDirection = origination.north;
      byte myDirectionByte = (byte) myDirection; //  myDirectionByte = 1
      ```

  - 枚举类型转化为字符串类型

    - ```c#
      origination myDirection;
      myDirection = origination.north;
      string myString = Convert.ToString(myDirection); //myDirectionString = "north"
      ```

  - 基本类型转化为枚举类型

    - ```
      byte myByte = 1;
      myDirection = (origination) myByte;
      ```

  - 字符串类型转化为枚举类型

    - ```c#
      string myString = "north";
      origination myDirection = (origination) Enum.Parse(typeof(origination), myString);
      ```

## 如何创建和使用结构类型

```c#
struct <typeName>
{
    <accessibility1> <type1> <name1>;
    <accessibility2> <type2> <name2>;
    ...
}
```

- 结构类型也放在名称空间内，与Main函数并列
- 通过使用`.`来对结构内的属性进行i引用

## 如何创建和使用数组

### 数组的声明

**方式**

```c#
<baseType> [] <name> = new <baseType> [ArraySize] {..,..,...}; 
```

**示例**

```c#
int [] myArray = new int [5]; //数组大小(可以略过这一步，直接赋给数组内容)，
myArray = {1,2,3,4,5}; //数组内容
```

- 需要注意的是：第一行数组大小传入的参数是字面值或者常量

```c#
const int i = 5;
int [] myArray = new int [i];
```

### foreach循环

foreach循环可以使用一种简便的语法可以定位数组中的每个元素：

- 只能对数组内容进行访问，不能改变任何元素的值

**方式**

```c#
foreach (<baseType> <name> in <array>)
{
    //can use <name> for each element
}
```

**示例**

```c#
foreach(string friendName in friendsName)
{
    WriteLine(friendName);
}
```

### 使用switch case表达式进行模式匹配

C#7中可以基于变量的类型在switch case中进行模式匹配

```c#
switch(<testVar>)
{
    case int value:
        <code to execute if <testVar> is an int>;
        bresk;
    case string s when s.Length == 0:
        <code to execute if <testVar> is an string and the length of it is 0>;
        break;
    case null:
        <code to execute if <testVar> is null>;
        break;
    default:
        <code to execute if <testVar> != comparisonVals>;
        bresk;
}
```

- case关键字后面紧跟的是想要检查的变量类型，之后是一个声明的变量。`<testVar>`的值将保存到声明的变量中
- C#7中的when关键字修饰符应用到了switchh case表达式中，when关键字修饰符允许扩展或添加一些额外的条件，以执行case语句中的代码

### 多维数组（矩形数组）

#### 声明与初始化

**方法**

```c#
<baseType> [,] <name> = new <baseType> [i,j]; //n个逗号声明n+1维数组
//上面示例中声明了二维数组，第一层有i个数组，每个数组有j个元素
```

**示例**

```c#
double [,] doubleArray = new double [2,3];
doubleArray = {{1,2,3},{4,5,6}};
```

#### 引用

**方法**

```c#
<name>[a,b];
```

**示例**

```c#
doubleArray[0,1];//2
```

#### 遍历

```c#
foreach(double number in doubleArray)
{
    WriteLine($"{nnumber}");
}
//遍历顺序为doubleArray[0,0],doubleArray[0,1]...doubleArray[1,2]
```

### 数组的数组（锯齿数组）

#### 声明

**方法**

```c#
<baseType> []...[] jaggedArray;//有多少括号就是几维的
```

**示例**

```c#
int [][] jaggedArray;
```

#### 初始化

**示例**

初始化需要层层初始化：

```c#
int [][] jaggedArray;
jaggedArray = new int [2][];
jaggedArray[0] = new int [3];
jaggedArray[1] = new int [4];
```

也可以使用下面的方式

```c#
int [][] jaggedArray;
jaggedArray = new int [2][] {
    new int [] {1,2,3},
    new int [] {4,5,6,7}
};
```

#### 遍历

遍历也需要层层遍历

```c#
int [][] divisors1To10 = new int [10][];
divisors1To10 = {
    new int [] {1},
    new int [] {1,2},
    new int [] {1，2，3},
    new int [] {1,2,3,4},
    new int [] {1,2,3,4,5},
    new int [] {1,2,3,4,5,6},
    new int [] {1,2,3,4,5,6,7},
    new int [] {1,2,3,4,5,6,7,8},
    new int [] {1,2,3,4,5,6,7,8,9},
    new int [] {1,2,3,4,5,6,7,8,9,10}
}
foreach( int [] divisorOfInt in divisors1To10)
{
    foreach(int divisor in divisorOfInt)
    {
        WriteLine($"{divisor}");
    }
}
```



## 如何处理字符串

### string类型可以看作char变量的只读数组

使用下面的语法访问每个字符，不能对字符串进行改写！

```c#
string myString = "A String";
char myChar = myString[1];//mychar为' '
```

获得char数组

```c#
string myString = "A String";
char [] myChars = myString.ToCharArray();
```

### 遍历字符串

```c#
foreach(char myChar in myString)
{
    WriteLine($"{myChar}");
}
```

### 字符串长度

```c#
int stringLength = myString.Length;//字符串长度
```

### 字符串大小写

```c#
myUpperString = myString.ToUpper();//字符串全部字符大写
myLowerString = myString.ToLower();//字符串全部字符小写
```

- `ToUpper()`和`ToLower()`并不会改变`myString`

### 删除字符串前后的空格

```c#
string userResponse = ReadLine();
userResponse = userResponse.Trim();//删除字符串前后的空格
userResponse = userResponse。TrimStart();//删除字符串前的空格
userResponse = userResponse.TrimEnd();//删除字符串后的空格
```

### 删除字符串中指定的字符

```c#
char [] trimChars = [' ', 'e', 's'];
string userResponse = ReadLine();
userResponse = userResponse.Trim(trimChars);//删除字符串中指定的字符
userResponse = userResponse.TrimStart(trimChars);//删除字符串前出现的连续的指定字符，直到下一个字符不在trimChars内
userResponse = userResponse.TrimEnd(trimChars);//删除字符串后出现的连续的指定字符，直到下一个字符不在trimChars内
```

### 向字符串中添加指定字符

```c#
myString = "Bob";
myString = myString.PadLeft(10,'-');//在字符串左边添加字符-直至字符串长度为10
myString = myString.PadRight(13, ' ');//在字符串右边添加空格直至字符串长度为13
```

## 总结

|   主题   |                             要点                             |
| :------: | :----------------------------------------------------------: |
| 类型转换 | 值可以从一种类型转换为另一种类型，但是在转换时应该遵循一些规则。隐式转换是自动进行的，但只有当源值类型的所有可能值都在目标值类型中使用时，才能进行隐式转换。也可以进行显式转换，但是可能得不到期望的值，甚至会出错 |
|   枚举   | 枚举是包含一组离散值的类型，每个离散值都有一个名称。枚举用关键词`enum`定义，以便在代码中理解它们，因为它们枚举的可读性都很强。枚举有基本的数值类型（默认为`int`），可使用枚举值的这个属性在枚举值和数值之间转换，或者标识枚举值。 |
|   结构   | 结构是同时包含几个不同值的类型。结构使用`struct`关键字定义。包含在结构中的每个值都有类型和名称，存储在结构中的每个值的类型不一定相同。 |
|   数组   | 数组是同类型数值的集合。数组有固定的大小或长度，确定了数组可以包含多少个值。可以定义多维数组或锯齿数组来保存不同数量和形状的数据。还可以使用`foreach`循环来迭代数组中的值 |

# 第六章 函数

## 如何定义和使用既不接受任何数据也不返回任何数据的简单函数

```c#
static void <functionName>()
{
    //code to execute without any return 
}
```

### 关键字`static`和`void`

- `static`与面向对象的概念相关，后面会进行讨论
- `void`表示函数没有返回值

### 函数名

- 函数名采用`PascalCase`形式进行编写
- 函数名后跟()，并且在调用函数时不仅要添加函数名也要添加()

### 要执行的代码块

- 要执行的代码块放在大括号内，

### 对Main函数的解释

- 定义的函数的位置与Main函数的位置并列
- Main函数是控制台应用程序的入口点函数，当执行C#应用程序时，就会调用它包含的入口点函数，这个函数执行完毕后，应用程序就终止了。所有C#代码必须有一个入口点

## 如何在函数中传入和传出数据

### 返回值

```c#
static <returnType> <FunctionName>()
{
    //code to execute
    return <returnValue>;
}
```

- 返回值`<returnValue>`的类型必须为`<returnType>`
- 函数在任何情况下结束都必须有`return`，不能存在任何一种情况函数执行完成后没有`return`语句

**只执行一行代码（return）的函数可以这样编写**

```c#
static <returnTyoe> <FunctionName> () => <returnValue>;
```

### 参数

```c#
static <returnType> <FunctionName> (<paramType> <paramName>, ...)
{
    //code to execute
    return <returnValue>;
}
```

- 函数在定义时指定接受的参数列表以及这些参数的类型
- 函数在调用的时候提供匹配的实参列表

#### 参数匹配

调用函数的时候必须使提供的参数与函数定义中指定的参数完全匹配：匹配参数的类型、个数和顺序

#### 参数数组

C#允许为函数指定一个特殊参数，这个参数必须是函数定义的最后一个参数，称为参数数组。参数数组允许使用个数不定的参数来调用函数，可以使用`params`关键字定义它们。

参数数组可以简化代码，因为在调用代码时不必传递数组，而是传递同类型的几个参数

```c#
static <returnType> <FunctionName> (<p1type> <p1Name>...,
                                    params <type> [] <name>)
{
    ...
    return <returnValue>;
}
```

调用函数：

```c#
<FunctionName> (<p1>,...,<val1>,<val2>...)
```

- `p1`...的类型为`p1type`...
- `val1`,`val2`...的类型为`type`

### 引用参数和值参数

#### 值参数

> **值参数：**在使用参数时，是把一个值传递给函数所使用的一个变量。在函数中对此变量的任何修改都不影响函数调用中指定的参数。

**函数**

```c#
static void ShowDouble(int val)
{
    val *= 2;
    WriteLine($"val doubled = {val}");
}
```

**调用**

```c#
int num = 2;
int doubleNum;
doubleNum = ShowDouble(num);
WriteLine($"num = {num}, doubleNum = {doubleNum}");// num为2,doubleNum为4
```

#### 引用参数

> **引用参数：**函数处理的变量与函数调用中使用的变量相同，而不仅仅是值相同的变量。对该变量的任何修改都会影响用作参数的变量值

**函数**

```c#
static void ShowDouble(ref int val)
{
    val *= 2;
    WriteLine($"val doubled = {val}");
}
```

**调用**

```c#
int num = 2;
int doubleNum;
doubleNum = ShowDouble(ref num);
WriteLine($"num = {num}, doubleNum = {doubleNum}");// num为4,doubleNum为4
```

- `num`不能是常量：`const int num`是错误的
- `num`必须经过初始化

#### ref用于返回值

**函数定义**

```c#
static ref int ShowDouble(ref int val)
{
    val *= 2;
    return ref val;
}
```

- 函数返回值为`ref int`
- 函数参数类型为`ref int`
- 函数返回值前面必须带上`ref`

#### ref用作局部变量

```c#
int myNum = 2;
ref int myRefNum = ref myNum;
```

- 定义引用时要`ref int`
- 赋值时要在变量前添加`ref`

#### ref返回array

```c#
static ref int ReturnByRef()
{
    int [] array = {2};
    return ref array[0];
}
```

- `array`是引用类型，在没有参数声明的情况下使用`ref`关键字可以返回`arrays`

> 虽然strings是引用类型，但是属于特例，因为它们是不可改变的，修改它们会产生新的string，原有的string则会被解除分配。如果试图通过ref返回string，C#编译器Roslyn会报错。

### 输出参数

除了按引用传递值外，还可以使用`out`关键字，指定所给参数是一个**输出参数**。

#### `out`关键字的使用方法：

在函数定义和函数调用中用作参数的修饰符（同`ref`类似），也有不同：

- 把未赋值的用作`ref`参数是非法的，但是可以把未赋值的变量用作`out`参数
- 调用代码时可以使用已经赋值的变用作`out`参数，但是存储在该变量中的值在函数执行的时候会丢失

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex05
{
    class Program
    {
        static int MaxValue(int [] array, out int maxIndex)//函数声明的时候带上out
        {
            int maxValue = array[0];
            maxIndex = 0;					//初始化
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 6, 9 };
            WriteLine($"The maxValue is {MaxValue(array, out int maxIndex)}.");//函数调用的时候也要带上out
            WriteLine($"The index of the maxValue(first occurrence) is {maxIndex}.");
            ReadLine();
        }
    }
}

```



## 使用变量作用域

### 局部变量

### 全局变量

#### 声明

```c#
static string myString;
```

- 与Main函数并列
- 声明前必须有`static`或者`const`，后者代表变量不可修改

#### 调用

全局变量声明后，在任何位置都可以进行调用

**如果全局变量和局部变量重名**

```c#
Program.myString = "myString in prgram";
```

**不存在局部变量和全局变量重名**

```c#
myString = "myString in program";
```

### 其他结构中变量的作用域

```c#
int i;
string myString = "";
for(i = 0; i < 10; i++)
{
    myString = "Line {Convert.String(i)}";
    WriteLine(${myString});
}
WriteLine($"{myString}");//Line 9
```

- 定义在`for`循环之外的`myString`才能够相当于一个“全局变量”
- `myString`声明后必须进行**赋值**，因为赋值代表着申请一块内存空间。如果赋值在循环内发生，那么该值实际上被定义为一个局部值

### 参数和返回值与全局数据

```c#
class Program
    {
        static void ShowDouble(ref int val)
        {
            val *= 2;
            WriteLine($"val doubled = {val}");
        }
        static void Main(string[] args)
        {
            int val = 3;
            WriteLine($"val = {val}"); //3
            ShowDouble(ref val);       //6
            WriteLine($"val = {val}"); //6
            ReadKey();
        }
    }
```

```c#
    class Program
    {
        static int val;
        static void ShowDouble()
        {
            val *= 2;
            WriteLine($"val douled = {val}");
        }
        static void Main(string[] args)
        {
            val = 3;
            WriteLine($"val = {val}"); //3
            ShowDouble();              //6
            WriteLine($"val = {val}"); //6
            ReadKey();
        }
    }
```

```c#
class Program
    {
        static void ShowDouble(out int val)
        {
            val = 3;
            val *= 2;
            WriteLine($"val douled = {val}");
        }
        static void Main(string[] args)
        {
            int val = 3;
            WriteLine($"val = {val}"); //3
            ShowDouble(out val);       //6
            WriteLine($"val = {val}"); //6
            ReadKey();
        }
    }
```

以上三段代码运行结果相同，但是

- 第二段代码使用全局变量，会对函数的灵活性有行为的限制。要存储结果，就必须总是把这个全局变量值复制到其他变量值中。全局变量还可能在应用程序中的其他地方被代码修改，这会导致预料不到的后果
- 第一段代码使用`ref`，变量`val`成为引用变量
- 第三段代码使用`out`，`ShowDouble`函数运行结束前最后的`val`作为输出参数

### 局部函数

函数定义在Main函数之内，不能从Program类中的其他函数中调用这个函数。函数在声明时不必添加`static`例如：

```c#
class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 5;
            WriteLine($"Main Function = {myNumber}.");
            DoubleInt(myNumber);
            ReadKey();

            void DoubleInt(int val)
            {
                val *= 2;
                WriteLine($"Local Function = {val}.");
            }

        }
    }
```

## 如何结合使用`Main()`函数和命令行参数

- `Main()`函数是C#程序的入口，执行这个函数就是执行应用程序。在执行过程开始时，会执行Main()函数，在Main()函数执行完毕后，执行过程就结束了
- Main()函数的返回值为`void`或者`int`，返回值为int时用于表示应用程序的终止方式。一般来说返回值为0表示应用程序已经执行完毕并安全地终止。通常用作错误提示
- Main()函数有一个可选参数`string[] args`，提供了一种从应用程序的外部接受信息的方法，这些信息在运行应用程序时以命令行参数的形式指定

```c#
static void Main(string[] args);
static void Main();
static int Main(string[] args);
static int Main();
```



## 如何把函数提供为结构类型成员

## 如何使用函数重载

## 如何使用委托