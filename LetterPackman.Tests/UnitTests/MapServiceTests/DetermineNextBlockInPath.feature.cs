﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTests.MapServiceTests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DetermineNextBlockInPath")]
    public partial class DetermineNextBlockInPathFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "DetermineNextBlockInPath.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UnitTests/MapServiceTests", "DetermineNextBlockInPath", "Determines next block in path", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - start")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_Start()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - start", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table16.AddRow(new string[] {
                            "@",
                            "H",
                            "-",
                            "-",
                            "A",
                            "C",
                            "D",
                            "-",
                            "+"});
                table16.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "|"});
                table16.AddRow(new string[] {
                            "x",
                            "-",
                            "B",
                            "-",
                            "+",
                            "",
                            "",
                            "",
                            "G"});
                table16.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "|"});
                table16.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "+",
                            "-",
                            "-",
                            "-",
                            "+"});
#line 7
    testRunner.Given("I have a map", ((string)(null)), table16, "Given ");
#line hidden
#line 14
 testRunner.And("previous block is: @", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("current block is: @", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("result should be: H", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - start bottom")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_StartBottom()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - start bottom", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table17.AddRow(new string[] {
                            "@",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table17.AddRow(new string[] {
                            "Q",
                            "",
                            "+",
                            "-",
                            "C",
                            "-",
                            "-",
                            "+",
                            "",
                            ""});
                table17.AddRow(new string[] {
                            "A",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "",
                            "|",
                            "",
                            ""});
                table17.AddRow(new string[] {
                            "+",
                            "-",
                            "-",
                            "-",
                            "B",
                            "-",
                            "-",
                            "+",
                            "",
                            ""});
                table17.AddRow(new string[] {
                            "",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "x"});
                table17.AddRow(new string[] {
                            "",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "|"});
                table17.AddRow(new string[] {
                            "",
                            "",
                            "+",
                            "-",
                            "-",
                            "-",
                            "D",
                            "-",
                            "-",
                            "+"});
#line 21
    testRunner.Given("I have a map", ((string)(null)), table17, "Given ");
#line hidden
#line 30
 testRunner.And("previous block is: @", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("current block is: @", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("result should be: Q", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - right")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_Right()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - right", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table18.AddRow(new string[] {
                            "@",
                            "-",
                            "-",
                            "-",
                            "A",
                            "C",
                            "D",
                            "-",
                            "+"});
                table18.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "|"});
                table18.AddRow(new string[] {
                            "x",
                            "-",
                            "B",
                            "-",
                            "+",
                            "",
                            "",
                            "",
                            "G"});
                table18.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "|"});
                table18.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "+",
                            "-",
                            "-",
                            "-",
                            "+"});
#line 37
    testRunner.Given("I have a map", ((string)(null)), table18, "Given ");
#line hidden
#line 44
 testRunner.And("previous block is: A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("current block is: C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("result should be: D", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - left")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_Left()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - left", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table19.AddRow(new string[] {
                            "@",
                            "-",
                            "-",
                            "-",
                            "A",
                            "C",
                            "D",
                            "-",
                            "+"});
                table19.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "|"});
                table19.AddRow(new string[] {
                            "x",
                            "-",
                            "B",
                            "-",
                            "+",
                            "",
                            "",
                            "",
                            "G"});
                table19.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "|"});
                table19.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "+",
                            "-",
                            "-",
                            "-",
                            "+"});
#line 51
    testRunner.Given("I have a map", ((string)(null)), table19, "Given ");
#line hidden
#line 58
 testRunner.And("previous block is: D", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("current block is: C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("result should be: A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - bottom")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_Bottom()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - bottom", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 64
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table20.AddRow(new string[] {
                            "@",
                            "-",
                            "-",
                            "-",
                            "A",
                            "-",
                            "-",
                            "Z",
                            "Y"});
                table20.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "T"});
                table20.AddRow(new string[] {
                            "x",
                            "-",
                            "B",
                            "-",
                            "+",
                            "",
                            "",
                            "",
                            "|"});
                table20.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "|",
                            "",
                            "",
                            "",
                            "|"});
                table20.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "+",
                            "-",
                            "-",
                            "-",
                            "+"});
#line 65
    testRunner.Given("I have a map", ((string)(null)), table20, "Given ");
#line hidden
#line 72
 testRunner.And("previous block is: Z", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("current block is: Y", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then("result should be: T", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - top")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_Top()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - top", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table21.AddRow(new string[] {
                            "@",
                            "-",
                            "-",
                            "-",
                            "A",
                            "-",
                            "-",
                            "Z",
                            "Y"});
                table21.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "T"});
                table21.AddRow(new string[] {
                            "x",
                            "-",
                            "B",
                            "-",
                            "+",
                            "",
                            "",
                            "",
                            "|"});
                table21.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "D",
                            "",
                            "",
                            "",
                            "|"});
                table21.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "P",
                            "V",
                            "-",
                            "-",
                            "+"});
#line 79
    testRunner.Given("I have a map", ((string)(null)), table21, "Given ");
#line hidden
#line 86
 testRunner.And("previous block is: V", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("current block is: P", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.Then("result should be: D", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid next block - bottom direction change")]
        [NUnit.Framework.CategoryAttribute("unit")]
        public void ValidNextBlock_BottomDirectionChange()
        {
            string[] tagsOfScenario = new string[] {
                    "unit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid next block - bottom direction change", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 92
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""});
                table22.AddRow(new string[] {
                            "@",
                            "-",
                            "-",
                            "A",
                            "C",
                            "+",
                            "",
                            ""});
                table22.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "T",
                            "",
                            ""});
                table22.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "|",
                            "",
                            ""});
                table22.AddRow(new string[] {
                            "",
                            "",
                            "",
                            "",
                            "",
                            "B",
                            "-",
                            "x"});
#line 93
    testRunner.Given("I have a map", ((string)(null)), table22, "Given ");
#line hidden
#line 99
 testRunner.And("previous block is: C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And("current block is: +", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.When("I execute the DetermineNextBlockInPath function", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("result should be: T", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
