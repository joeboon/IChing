using Example.IChing.Divination;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Example.IChing.AcceptanceTest.Test.StepDefinitions
{
    [Binding]
    public class ChangingSteps
    {

        const string ScoreKey = "score";

        [Given(@"the monogram is ""(.*)""")]
        public void GivenTheMonogramIs(string monogram)
        {
            int score;
            switch (monogram)
            {
                case ".---": score = 9; break;
                case "- -": score = 8; break;
                case "---": score = 7; break;
                case ".- -": score = 6; break;
                default: score = 0; break;
            }
            ScenarioContext.Current.Add(ScoreKey, score);
        }

        [Then(@"the present should be ""(.*)""")]
        public void ThenThePresentShouldBe(string present)
        {
            int score = ScenarioContext.Current.Get<int>(ScoreKey);
            Assert.AreEqual(
                expected: present,
                actual: (new MonogramPlotter(score).Present()));
        }
        
        [Then(@"the future should be ""(.*)""")]
        public void ThenTheFutureShouldBe(string future)
        {
            int score = ScenarioContext.Current.Get<int>(ScoreKey);
            Assert.AreEqual(
                expected: future,
                actual: (new MonogramPlotter(score).Future()));
        }
    }
}


//Given /^the monogram is "([^"]*)"$/ do |monogram|
//  @score = case monogram
//             when '.---'
//               9
//             when '- -'
//               8
//             when '---'
//               7
//             when '.- -'
//               6
//           end
//end

//Then /^the present should be "([^"]*)"$/ do |present|
//  expect(MonogramPlotter.new(@score).present).to eq(present)
//end

//Then /^the future should be "([^"]*)"$/ do |future|
//  expect(MonogramPlotter.new(@score).future).to eq(future)
//end