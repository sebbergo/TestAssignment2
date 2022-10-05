# TestAssignment2

## Reflections

### Computer Mouse
First the basics needs to be tested:
- Left/right Mouse Click
- Mouse Wheel up/down
- Mouse Wheel click
- (if any) Side Buttons click
- Sensor under mouse

And after more advanced:
- Latency between click to registered
- Only one click per click, no doubles

### Catastrophic Failure
In 1999, The Mars Climate Orbiter made by Nasa crashed due to a unit measuring conflict. Another story by Nasa where this accured aswell, was when a ballistic anti nuclear defence system was developed. They had to have a mirror at sea level reflect a laserbeam from the top of a mountain in a very specific direction. The problem was, that the mirror read the distance from the mountain as nautical miles, instead of feet. This resulted in the project's failure.

A very easy and simple way to make sure that units aren't confused for different ones, is to make a DTO when sending the data. This way, instead of sending a single data variable of 'integer' or 'long', we can send a DTO object that also stores the type of unit it is. This makes sure that we aren't in doubt of what unit the value is.

## Two Katas

### String Utility
- Methods for this task are in the StringUtility class in the Classes folder
- Tests for these methods are done in the StringUtilityTests in the Test folder

### Bowling Game Kata
- Methods for this task are in the Game class in the Classes folder
- Tests for these methods are done in the GameTests in the Test folder

## Investigation of Tools

### JUnit5
-  @Tag are used to filter which tests are executed for a given test plan. For example, a development team may tag tests with values such as "fast", "slow", "ci-server", etc. and then supply a list of tags to be used for the current test plan, potentially dependent on the current environment.
- @Disabled is used to signal that the annotated test class or test method is currently disabled and should not be executed
- @RepeatedTest is used to signal that the annotated method is a test template method that should be repeated a specified number of times with a configurable display name
- @BeforeEach/@AfterEach is used to signal that the annotated method should be executed before/after each @Test method in the current test class
- @BeforeAll/@AfterAll is used to signal that the annotated method should be executed before/after all @Test method in the current test class
- @DisplayName is used to declare a custom display name for the annotated test class or test method
- @Nested is used to signal that the annotated class is a nested, non-static test class (i.e., an inner class) that can share setup and state with an instance of its enclosing class. The enclosing class may be a top-level test class or another @Nested test class, and nesting can be arbitrarily deep
- @Assumptions in direct contrast to failed assertions, failed assumptions do not result in a test failure; rather, a failed assumption results in a test being aborted

### Mocking Frameworks
My preferred language is C# where we have quite a bit different frameworks for mocking, but have 3 major ones. These are the most popular ones:
- Moq
- NSubstitute
- FakeItEasy

As for which one i prefer the most, I'd have to say Moq as this is the one I've used myself before and have experience with. If I were to rank them based on their syntax, NSubstitute has the most straight forward syntax, as it doesn't use lambda expressions or normal expressions, but just straight forward syntax. But for more advanced mocking I'd stil, use Moq.

#### Moq syntax
```
var mockStockChecker = new Mock<IStockChecker>();
mockStockChecker.Setup(x => x.IsProductInStock()).Returns(true);
var sut = new TheClassIAmTesting(mockStockChecker.Object);
sut.DoSomething();
```
#### NSubsitute syntax
```
var mockStockChecker = Substitute.For<IStockChecker>();
mockStockChecker.IsProductInStock().Returns(true);
var sut = new TheClassIAmTesting(mockStockChecker);
sut.DoSomething();
```
#### FakeItEasy syntax
```
var mockStockChecker = A.Fake<IStockChecker>();
A.CallTo(() => mockStockChecker.IsProductInStock("")).Returns(true);
var sut = new TheClassIAmTesting(mockStockChecker);
sut.DoSomething();
```
