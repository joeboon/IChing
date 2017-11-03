using Example.IChing.Divination;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Example.IChing.AcceptanceTest.Test.StepDefinitions
{
    [Binding]
    public class CastingSteps
    {

        const string CastKey = "cast";

        [When(@"I cast")]
        public void WhenICast()
        {
            Caster caster = new Caster();
            List<int> cast = caster.Cast();
            ScenarioContext.Current.Add(CastKey, cast);
        }
        
        [Then(@"I will get back six monograms")]
        public void ThenIWillGetBackSixMonograms()
        {
            List<int> cast = 
                ScenarioContext.Current.Get<List<int>>(CastKey);
            Assert.AreEqual(
                expected: 6,
                actual: cast.Count);
        }
        
        [Then(@"each will have an integral score between 6 and 9 inclusive")]
        public void ThenEachWillHaveAnIntegralScoreBetweenAndInclusive()
        {
            List<int> cast =
                ScenarioContext.Current.Get<List<int>>(CastKey);
            Assert.That(cast, Is.All.InRange(6, 9));
        }
    }
}


//When /^I cast$/ do
//  my_monogram_values
//end

//Then /^I will get back six monograms$/ do
//  expect(my_monogram_values).to have(6).items
//end

//Then /^each will have an integral score between 6 and 9 inclusive$/ do
//  expect(my_monogram_values).to all be_an(Integer).and be_between(6, 9).inclusive
//end
