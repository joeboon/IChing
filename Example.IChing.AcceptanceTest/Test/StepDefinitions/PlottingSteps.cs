using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using Example.IChing.Divination;
using NUnit.Framework;

namespace Example.IChing.AcceptanceTest.Test.StepDefinitions
{
    [Binding]
    public class PlottingSteps
    {

        private const string ScoreKey = "score";

        [Given(@"the score is ""(.*)""")]
        public void GivenTheScoreIs(int p0)
        {
            ScenarioContext.Current.Add(ScoreKey, p0);
        }
        
        [Then(@"the monogram should be ""(.*)""")]
        public void ThenTheMonogramShouldBe(string p0)
        {
            // Arrange
            int score = ScenarioContext.Current.Get<int>(ScoreKey);
            // Act
            MonogramPlotter plotter = new MonogramPlotter(score);
            string monogram = plotter.ToString();
            // Assert
            Assert.AreEqual(
                expected: p0,
                actual: monogram);
        }
    }
}


//Given /^the score is "(#{CAPTURE_A_NON_NEGATIVE_INTEGER})"$/ do |score|
//  @score = score
//end

//Then /^the monogram should be "([^"]*)"$/ do |monogram|
//  expect(MonogramPlotter.new(@score).to_s).to eq(monogram)
//end