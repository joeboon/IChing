using Example.IChing.Divination;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

using Example.IChing;


namespace Example.IChing.AcceptanceTest.Test.StepDefinitions
{
    [Binding]
    public class ScoringSteps
    {

        private const string TossesKey = "tosses";


        [Given(@"the three coin tosses are ""(.*)""")]
        public void GivenTheThreeCoinTossesAre(string p0)
        {
            List<Toss> tosses = new List<Toss>(3);
            foreach (char c in p0)
            {
                tosses.Add(GetTossFromChar(c));
            }
            
            ScenarioContext.Current.Add(TossesKey, tosses);
        }

        [Then(@"the score should be ""(.*)""")]
        public void ThenTheScoreShouldBe(int p0)
        {
            // Arrange
            List<Toss> tosses = (List<Toss>)ScenarioContext.Current.Get<List<Toss>>(TossesKey);
            // Act
            int score = Scorer.Score(tosses);
            // Assert
            Assert.AreEqual(
                expected: p0, 
                actual: score);
        }

        private Toss GetTossFromChar(char t)
        {
            switch (Char.ToLowerInvariant(t)) {
                case 'h': return Toss.Heads;
                case 't': return Toss.Tails;
                default: return Toss.Heads;
            }
        }
    }


}


//Given /^the three coin tosses are "([^"]*)"$/ do |values|
//  @values = values.chars.map do |value|
//    case value
//      when 'h'
//        :heads
//      when 't'
//        :tails
//    end
//  end
//end

//Then /^the score should be "(#{CAPTURE_A_NON_NEGATIVE_INTEGER})"$/ do |score|
//  expect(Scorer.new(@values).score).to eq(score)
//end
