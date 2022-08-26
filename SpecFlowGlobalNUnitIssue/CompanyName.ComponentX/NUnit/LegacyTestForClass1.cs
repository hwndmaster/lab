using NUnit.Framework;

//
//   PROBLEM: This is a sample legacy test class (one of zillions in a real huge project),
//         Where the NUnit test fixtures are residing together with the production code.
//         All the legacy tests have ".NUnit" suffix in their namespace, which breaks integration with
//         SpecFlow, as in the generated files it uses the following qualification to declare tests:
//           [NUnit.Framework.TestFixtureAttribute()]
//         Which therefore leads to the following build error:
//           error CS0234: The type or namespace name 'Framework' does not exist in the namespace 'CompanyName.ComponentX.NUnit' (are you missing an assembly reference?)
//
//   IDEA: To start moving NUnit tests from their current projects to newly created projects,
//         dedicated only for tests (to separate them from production code).
//
//   NOTE: Renaming the namespace to something like CompanyName.ComponentX.NUnitXXX helps,
//         but doesn't solve the original issue.
//         There must be a way to add "global::NUnit..." in the generated Feature1.feature.cs file.
//
//   REF:  Related issue on GitHub: https://github.com/SpecFlowOSS/SpecFlow/issues/2376
namespace CompanyName.ComponentX.NUnit;

[TestFixture]
public class LegacyTestForClass1
{
    [Test]
    public void TestFoo()
    {
        // Some test implementation

        Assert.IsTrue(true);
    }
}
