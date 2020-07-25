# unit-test-example
Unit test example using C#, .NET CORE 3.1 and MSTest.

## Examples

### Simple test

```
[TestMethod]
public void SumTest()
{
    // Arrange
    var x = 1;
    var y = 2;
    var expectedResult = 3;
    var calculator = new CalculatorClass(x, y);

    // Act
    var actualResult = calculator.Sum();

    // Assert
    Assert.AreEqual(expected: expectedResult, actual: actualResult, 
        message: $"The sum of {x} plus {y} should be {expectedResult} and not {actualResult}.");
}
```

### Test with DataRow attribute

```
[DataTestMethod]
[DataRow(1, 1, 0)]
[DataRow(3, 2, 1)]
[DataRow(2, 3, -1)]
public void MinusTest(int x, int y, int expectedResult)
{
    // Arrange            
    var calculator = new CalculatorClass(x, y);

    // Act
    var actualResult = calculator.Minus();

    // Assert
    Assert.AreEqual(expected: expectedResult, actual: actualResult,
        message: $"{x} minus {y} should be {expectedResult} and not {actualResult}.");
}
```

### Test using the ExpectedException attribute

```
[TestMethod]
[ExpectedException(typeof(DivideByZeroException))]
public void DivideByZeroShouldThrowsAnDivideByZeroException()
{
    // Arrange            
    var calculator = new CalculatorClass(x: 1, y: 0);

    // Act
    calculator.Divide();
}
```