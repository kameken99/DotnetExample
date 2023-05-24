using AutoMapper;
using Moq;

public static class EntryPoint
{
    public static void TestMoq()
    {
        // Create a mock object and set up a method to return a value
        var mock = new Mock<IMyInterface>();
        mock.Setup(x => x.MethodName()).Returns("Mocked result");

        // Create an instance of the class under test and pass the mock object, then call the method.
        var mockedObject = mock.Object;
        var sut = new MyClass(mockedObject);
        var result = sut.MyMethod();

        // Verify that the method was called once
        mock.Verify(x => x.MethodName(), Times.Once);

        Console.WriteLine(result);
    }
    
    public static void TestAutoMapper()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        var mapper = config.CreateMapper();
        
        var source = new SourceObject { Id = 1, Name = "Source" };
        var destination = mapper.Map<DestinationObject>(source);
        
        Console.WriteLine(destination.Id);
        Console.WriteLine(destination.Name);
    }
}