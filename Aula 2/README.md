# Introdução aos testes unitários

_`Unit testing` is an integral part of development when we want to test our code by writing code. (fonte: Hands-On Design Patterns with C# and .NET Core)_

_A `unit test` is a way of testing a unit of code - the smallest piece of code that can be logically isolated in a system. In most programming languages, that is a function, a subroutine, a method or property. (fonte: smartbear)_

## Características de um bom teste unitário (_Clean Code: Unit Tests_)

- _One assert per test_.
- _Readable_.
- _Fast_. `Teste unitários` devem levar muito pouco tempo para serem executado (~ms).
- _Independent_. `Testes unitários` são autónomos, podem ser executados em isolamento e não têm dependências.
- _Repeatable_. A execução de um `teste unitário` deve ser consistente com os seus resultados, ou seja, este retornará sempre o mesmo resultado caso não exista alterações entre execuções.

## Escrever testes unitários

Considere o seguinte fragmento de código:

```c#
class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
```

Em .NET temos 3 opções de _frameworks_ disponíveis: `MSTest`, `NUnit` ou `xUnit`. Por exemplo, vamos criar um projeto de testes unitários, usando a estrutura de teste do `NUnit`:

```c#
[TestFixture]
public class ProgramTests
{
    [Test]
    public void Main_Displays_Hello_World_Using_Console()
    {
        string expected = "Hello World!";
        using (var writer = new StringWriter())
        {
            Console.SetOut(writer);
            Program.Main();

            var result = writer.ToString().Trim();
            Assert.AreEqual(expected, result); // FluentAssertions: result.Should().Be(expected);
        }
    }
}
```

Considere o seguinte fragmento de código:

```c#
public interface IFileSystem
{
    string[] ReadAllLines(string path);
}
public class Calculator
{
    private readonly IFileSystem _fileSystem;
    public Calculator(IFileSystem fileSystem)
    { 
        _fileSystem = fileSystem;
    }

    public double Sum(string path)
    {
        string[] lines = _fileSystem.ReadAllLines(path);
        double sum = 0;
        foreach(var line in lines)
        {
            double value;
            if(!double.TryParse(line, out value))
            {
                throw new ArgumentException($"Invalid line '{line}'!");
            }
            sum += value;
        }

        return sum;
    }
}
```

Por vezes é necessário utilizar um objeto fictício de modo a testar o código sem lidar diretamente com uma dependência existente.

```c#
using NSubstitute;
using FluentAssertions;
[TestFixture]
public class CalculatorTests
{
    IFileSystem _fileSystem;
    Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _fileSystem = Substitute.For<IFileSystem>();
        _calculator = new Calculator(_fileSystem);
    }

    [Test]
    public void Sum_Reads_All_Lines_From_File_And_Sums_Up()
    {
        const string fakePath = @"C:\Numbers.txt";
        _fileSystem.ReadAllLines(fakePath).Returns(new string[] {"10.5", "50.7", "5", "9"});

        double expected = 75.2;

        var result = _calculator.Sum(fakePath);
        result.Should().Be(expected);
    }
}
```

Um `teste unitário` deve ter controlo completo sobre o sistema em teste. Isto pode ser um problema quando o código de produção inclui chamadas para referência estáticas (por exemplo, `DateTime.Now`):

```c#
public class SalesManager
{
    public double GetDiscountedPrice(double price)
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}
```

Vejamos o que acontece quando criámos testes unitários para o método `GetDiscountedPrice(int)`:

```c#
using NSubstitute;
using FluentAssertions;
[TestFixture]
public class SalesManagerTests
{
    SalesManager _salesManager;

    [SetUp]
    public void Setup()
    {
        _salesManager = new SalesManager();
    }

    [Test]
    public void GetDiscountedPrice_NotMonday_Returns_Full_Price()
    {
        double actual = 75.2;
        var result = _salesManager.GetDiscountedPrice(actual);
        result.Should().Be(actual);
    }
    
    [Test]
    public void GetDiscountedPrice_OnMonday_Returns_Half_Price()
    {
        var result = _salesManager.GetDiscountedPrice(50);
        result.Should().Be(25);
    }
}
```

De notar que se o conjunto de testes for executado em uma segunda-feira, o segundo teste será executado com sucesso, mas o primeiro não. Por sua vez, se o conjunto de testes for executado em qualquer outro dia, o primeiro teste será executado com sucesso, mas o segundo não. 

Para resolver estes problemas, vamos encapsular o código em uma interface e fazer a classe `SalesManager` depender dessa interface:

```c#
public interface IDateProvider
{
    DayOfWeek GetDayOfWeek();
}
public class SalesManager
{
    private readonly IDateProvider _dateProvider;
    public SalesManager(IDateProvider dateProvider) => _dateProvider = dateProvider;

    public double GetDiscountedPrice(double price)
    {
        DayOfWeek dayOfWeek = _dateProvider.GetDayOfWeek();
        if (dayOfWeek == DayOfWeek.Monday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}
```

Agora o conjunto de testes tem controlo total sobre `DateTime.Now` e pode definido um valor fictício aquando da evocação do método `GetDayOfWeek()`:

```c#
using NSubstitute;
using FluentAssertions;
[TestFixture]
public class SalesManagerTests
{
    IDateProvider _dateProvider;
    SalesManager _salesManager;

    [SetUp]
    public void Setup()
    {
        _dateProvider = Substitute.For<IDateProvider>();
        _salesManager = new SalesManager();
    }

    [Test]
    public void GetDiscountedPrice_NotMonday_Returns_Full_Price()
    {
        _dateProvider.GetDayOfWeek().Returns(DayOfWeek.Tuesday);
        
        double actual = 75.2;
        var result = _salesManager.GetDiscountedPrice(actual);
        result.Should().Be(actual);
    }
    
    [Test]
    public void GetDiscountedPrice_OnMonday_Returns_Half_Price()
    {
        _dateProvider.GetDayOfWeek().Returns(DayOfWeek.Monday);

        var result = _salesManager.GetDiscountedPrice(50);
        result.Should().Be(25);
    }
}
```

# Ficha de Trabalho Nº2

1.  Crie um projeto em C# que leia uma temperatura em graus _Celsius_ e escreva no ecrã o seu valor em graus _Fahrenheit_. A fórmula de conversão é: `F = (1.8 * C) + 32.0`.

     ```c#
     public interface ITemperature
     {
          double Degrees { get; }
          double Convert();
     }
     ```

     Crie testes unitários para o método _`Convert()`_.

2. Crie uma projeto em C# para fazer registro em log no ecrã ou em um ficheiro. Crie testes unitários.

     ```c#
     public enum LogLevel
     {
         Trace= 0,
         Debug = 1,
         Information = 2,
         Warning = 3,
         Error = 4,
         Critical = 5,
         None = 6
     }
     public interface ILogger
     {
          void Log(LogLevel logLevel, Exception exception);
          void Log(LogLevel logLevel, string message, params object[] params);
          ...
     }
     ```

     ```txt
     2020-03-13 17:41:28,637 DEBUG ConsoleLogger: Started.
     2020-03-13 17:41:29,001 INFO  ConsoleLogger: No data found.
     2020-03-13 17:41:29,987 ERROR ConsoleLogger: System.ArgumentNullException: Value cannot be null. (Parameter 'connectionString').