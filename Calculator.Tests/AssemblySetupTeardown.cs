[SetUpFixture]
class AssemblySetupTeardown
{
    [OneTimeSetUp]
    public void SetUp()
    {
        Console.WriteLine("Setup started from assembly");
    }

    [OneTimeTearDown] 
    public void TearDown() 
    {
        Console.WriteLine("Teardown started from assembly");
    }
}

