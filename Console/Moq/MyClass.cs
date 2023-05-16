public class MyClass
{
    private readonly IMyInterface _myInterface;

    public MyClass(IMyInterface myInterface)
    {
        _myInterface = myInterface;
    }

    public string MyMethod()
    {
        return _myInterface.MethodName();
    }
}