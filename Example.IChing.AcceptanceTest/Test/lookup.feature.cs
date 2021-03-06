﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Example.IChing.AcceptanceTest.Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Lookup")]
    public partial class LookupFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "lookup.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Lookup", "  Each hexagram has a name and a number. This conversion seems completely arbitra" +
                    "ry \r\n  and nobody knows how this was defined.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Lookup hexagram number")]
        [NUnit.Framework.TestCaseAttribute("uuuuuu", "1", null)]
        [NUnit.Framework.TestCaseAttribute("bbbbbb", "2", null)]
        [NUnit.Framework.TestCaseAttribute("bubbbu", "3", null)]
        [NUnit.Framework.TestCaseAttribute("ubbbub", "4", null)]
        [NUnit.Framework.TestCaseAttribute("bubuuu", "5", null)]
        [NUnit.Framework.TestCaseAttribute("uuubub", "6", null)]
        [NUnit.Framework.TestCaseAttribute("bbbbub", "7", null)]
        [NUnit.Framework.TestCaseAttribute("bubbbb", "8", null)]
        [NUnit.Framework.TestCaseAttribute("uubuuu", "9", null)]
        [NUnit.Framework.TestCaseAttribute("uuubuu", "10", null)]
        [NUnit.Framework.TestCaseAttribute("bbbuuu", "11", null)]
        [NUnit.Framework.TestCaseAttribute("uuubbb", "12", null)]
        [NUnit.Framework.TestCaseAttribute("uuuubu", "13", null)]
        [NUnit.Framework.TestCaseAttribute("ubuuuu", "14", null)]
        [NUnit.Framework.TestCaseAttribute("bbbubb", "15", null)]
        [NUnit.Framework.TestCaseAttribute("bbubbb", "16", null)]
        [NUnit.Framework.TestCaseAttribute("buubbu", "17", null)]
        [NUnit.Framework.TestCaseAttribute("ubbuub", "18", null)]
        [NUnit.Framework.TestCaseAttribute("bbbbuu", "19", null)]
        [NUnit.Framework.TestCaseAttribute("uubbbb", "20", null)]
        [NUnit.Framework.TestCaseAttribute("ububbu", "21", null)]
        [NUnit.Framework.TestCaseAttribute("ubbubu", "22", null)]
        [NUnit.Framework.TestCaseAttribute("ubbbbb", "23", null)]
        [NUnit.Framework.TestCaseAttribute("bbbbbu", "24", null)]
        [NUnit.Framework.TestCaseAttribute("uuubbu", "25", null)]
        [NUnit.Framework.TestCaseAttribute("ubbuuu", "26", null)]
        [NUnit.Framework.TestCaseAttribute("ubbbbu", "27", null)]
        [NUnit.Framework.TestCaseAttribute("buuuub", "28", null)]
        [NUnit.Framework.TestCaseAttribute("bubbub", "29", null)]
        [NUnit.Framework.TestCaseAttribute("ubuubu", "30", null)]
        [NUnit.Framework.TestCaseAttribute("buuubb", "31", null)]
        [NUnit.Framework.TestCaseAttribute("bbuuub", "32", null)]
        [NUnit.Framework.TestCaseAttribute("uuuubb", "33", null)]
        [NUnit.Framework.TestCaseAttribute("bbuuuu", "34", null)]
        [NUnit.Framework.TestCaseAttribute("ububbb", "35", null)]
        [NUnit.Framework.TestCaseAttribute("bbbubu", "36", null)]
        [NUnit.Framework.TestCaseAttribute("uububu", "37", null)]
        [NUnit.Framework.TestCaseAttribute("ububuu", "38", null)]
        [NUnit.Framework.TestCaseAttribute("bububb", "39", null)]
        [NUnit.Framework.TestCaseAttribute("bbubub", "40", null)]
        [NUnit.Framework.TestCaseAttribute("ubbbuu", "41", null)]
        [NUnit.Framework.TestCaseAttribute("uubbbu", "42", null)]
        [NUnit.Framework.TestCaseAttribute("buuuuu", "43", null)]
        [NUnit.Framework.TestCaseAttribute("uuuuub", "44", null)]
        [NUnit.Framework.TestCaseAttribute("buubbb", "45", null)]
        [NUnit.Framework.TestCaseAttribute("bbbuub", "46", null)]
        [NUnit.Framework.TestCaseAttribute("buubub", "47", null)]
        [NUnit.Framework.TestCaseAttribute("bubuub", "48", null)]
        [NUnit.Framework.TestCaseAttribute("buuubu", "49", null)]
        [NUnit.Framework.TestCaseAttribute("ubuuub", "50", null)]
        [NUnit.Framework.TestCaseAttribute("bbubbu", "51", null)]
        [NUnit.Framework.TestCaseAttribute("ubbubb", "52", null)]
        [NUnit.Framework.TestCaseAttribute("uububb", "53", null)]
        [NUnit.Framework.TestCaseAttribute("bbubuu", "54", null)]
        [NUnit.Framework.TestCaseAttribute("bbuubu", "55", null)]
        [NUnit.Framework.TestCaseAttribute("ubuubb", "56", null)]
        [NUnit.Framework.TestCaseAttribute("uubuub", "57", null)]
        [NUnit.Framework.TestCaseAttribute("buubuu", "58", null)]
        [NUnit.Framework.TestCaseAttribute("uubbub", "59", null)]
        [NUnit.Framework.TestCaseAttribute("bubbuu", "60", null)]
        [NUnit.Framework.TestCaseAttribute("uubbuu", "61", null)]
        [NUnit.Framework.TestCaseAttribute("bbuubb", "62", null)]
        [NUnit.Framework.TestCaseAttribute("bububu", "63", null)]
        [NUnit.Framework.TestCaseAttribute("ububub", "64", null)]
        public virtual void LookupHexagramNumber(string hexagram, string number, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lookup hexagram number", exampleTags);
#line 6
  this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given(string.Format("the hexagram from top to bottom is \"{0}\"", hexagram), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.Then(string.Format("its number is {0}", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
