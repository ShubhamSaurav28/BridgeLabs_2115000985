//using System;
//using NUnit.Framework;

//public class ExceptionHandling
//{
//    public int Divide(int a, int b)
//    {
//        if (b == 0)
//            throw new ArithmeticException("Cannot divide by zero.");
//        return a / b;
//    }
//}

//[TestFixture]
//public class ExceptionHandlingTests
//{
//    private ExceptionHandling _handler;

//    [SetUp]
//    public void Setup() => _handler = new ExceptionHandling();

//    [Test]
//    public void Divide_ByZero_ThrowsException()
//    {
//        Assert.Throws<ArithmeticException>(() => _handler.Divide(10, 0));
//    }
//}
