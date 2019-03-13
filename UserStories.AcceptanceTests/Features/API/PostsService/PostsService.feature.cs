// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UserStories.AcceptanceTests.Features.API.PostsService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PostsServiceFeature : Xunit.IClassFixture<PostsServiceFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PostsService.feature"
#line hidden
        
        public PostsServiceFeature(PostsServiceFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostsService", "    In order to test basic functionality\r\n    As a requester\r\n    I want to be co" +
                    "rrectly responsed", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute(DisplayName="The first post given by votes and between dates has expected id and owner")]
        [Xunit.TraitAttribute("FeatureTitle", "PostsService")]
        [Xunit.TraitAttribute("Description", "The first post given by votes and between dates has expected id and owner")]
        [Xunit.TraitAttribute("Category", "Type:API")]
        [Xunit.InlineDataAttribute("2019-03-04", "2019-03-05", "desc", "votes", "54992348", "1048572", new string[0])]
        [Xunit.InlineDataAttribute("2019-03-01", "2019-03-02", "desc", "votes", "54946537", "1602555", new string[0])]
        public virtual void TheFirstPostGivenByVotesAndBetweenDatesHasExpectedIdAndOwner(string fromDate, string toDate, string order, string sort, string post_Id, string user_Id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Type:API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The first post given by votes and between dates has expected id and owner", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FromDate",
                        "ToDate",
                        "Order",
                        "Sort"});
            table1.AddRow(new string[] {
                        string.Format("{0}", fromDate),
                        string.Format("{0}", toDate),
                        string.Format("{0}", order),
                        string.Format("{0}", sort)});
#line 8
    testRunner.Given("The user gets a list of posts with the following properties", ((string)(null)), table1, "Given ");
#line 11
    testRunner.And("The status code of the posts service is \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.Then(string.Format("The first post given has the id \'{0}\' and the owner \'<userd_id>\'", post_Id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Get posts with wrong parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "PostsService")]
        [Xunit.TraitAttribute("Description", "Get posts with wrong parameter")]
        [Xunit.TraitAttribute("Category", "Type:API")]
        [Xunit.InlineDataAttribute("aaaa", "2019-03-05", "desc", "votes", new string[0])]
        public virtual void GetPostsWithWrongParameter(string fromDate, string toDate, string order, string sort, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Type:API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get posts with wrong parameter", null, @__tags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FromDate",
                        "ToDate",
                        "Order",
                        "Sort"});
            table2.AddRow(new string[] {
                        string.Format("{0}", fromDate),
                        string.Format("{0}", toDate),
                        string.Format("{0}", order),
                        string.Format("{0}", sort)});
#line 21
    testRunner.Given("The user gets a list of posts with the following properties", ((string)(null)), table2, "Given ");
#line 24
    testRunner.And("The status code of the posts service is \'Bad Request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PostsServiceFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PostsServiceFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
