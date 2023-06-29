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
namespace SpaceBattle.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ДвижениеКорабляFeature : object, Xunit.IClassFixture<ДвижениеКорабляFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SpaceBattle.feature"
#line hidden
        
        public ДвижениеКорабляFeature(ДвижениеКорабляFeature.FixtureData fixtureData, SpaceBattle_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "", "Движение корабля", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Игровой объект может перемещаться по прямой")]
        [Xunit.TraitAttribute("FeatureTitle", "Движение корабля")]
        [Xunit.TraitAttribute("Description", "Игровой объект может перемещаться по прямой")]
        public void ИгровойОбъектМожетПеремещатьсяПоПрямой()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Игровой объект может перемещаться по прямой", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
    testRunner.Given("космический корабль находится в точке пространства с координатами (12, 5)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 5
    testRunner.And("имеет мгновенную скорость (-5, 3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 6
    testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 7
    testRunner.Then("космический корабль перемещается в точку пространства с координатами (7, 8)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно определить текущее положение игрового объекта в пространстве, то " +
            "перемещение по прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Движение корабля")]
        [Xunit.TraitAttribute("Description", "Если невозможно определить текущее положение игрового объекта в пространстве, то " +
            "перемещение по прямой невозможно")]
        public void ЕслиНевозможноОпределитьТекущееПоложениеИгровогоОбъектаВПространствеТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно определить текущее положение игрового объекта в пространстве, то " +
                    "перемещение по прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 11
    testRunner.Given("космический корабль, положение в пространстве которого невозможно определить", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 12
    testRunner.And("имеет мгновенную скорость (-5, 3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 13
    testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 14
    testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно определить мгновенную скорость игрового объекта, то перемещение п" +
            "о прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Движение корабля")]
        [Xunit.TraitAttribute("Description", "Если невозможно определить мгновенную скорость игрового объекта, то перемещение п" +
            "о прямой невозможно")]
        public void ЕслиНевозможноОпределитьМгновеннуюСкоростьИгровогоОбъектаТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно определить мгновенную скорость игрового объекта, то перемещение п" +
                    "о прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 18
    testRunner.Given("космический корабль находится в точке пространства с координатами (12, 5)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 19
    testRunner.And("скорость корабля определить невозможно", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 20
    testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 21
    testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если невозможно изменить положение игрового объекта в пространстве, то перемещени" +
            "е по прямой невозможно")]
        [Xunit.TraitAttribute("FeatureTitle", "Движение корабля")]
        [Xunit.TraitAttribute("Description", "Если невозможно изменить положение игрового объекта в пространстве, то перемещени" +
            "е по прямой невозможно")]
        public void ЕслиНевозможноИзменитьПоложениеИгровогоОбъектаВПространствеТоПеремещениеПоПрямойНевозможно()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если невозможно изменить положение игрового объекта в пространстве, то перемещени" +
                    "е по прямой невозможно", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
    testRunner.Given("космический корабль находится в точке пространства с координатами (12, 5)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 26
    testRunner.And("имеет мгновенную скорость (-5, 3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 27
    testRunner.And("изменить положение в пространстве космического корабля невозможно", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 28
    testRunner.When("происходит прямолинейное равномерное движение без деформации", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 29
    testRunner.Then("возникает ошибка Exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ДвижениеКорабляFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ДвижениеКорабляFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
