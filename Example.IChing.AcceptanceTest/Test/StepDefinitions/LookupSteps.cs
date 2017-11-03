using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

using Example.IChing.Divination;

namespace Example.IChing.AcceptanceTest.Test.StepDefinitions
{
    [Binding]
    public class LookupSteps
    {

        private const string HexagramKey = "hexagram";

        [Given(@"the hexagram from top to bottom is ""(.*)""")]
        public void GivenTheHexagramFromTopToBottomIs(string p0)
        {
            Hexagram hexagram = new Hexagram(p0);
            ScenarioContext.Current.Add(HexagramKey, hexagram);
        }
        
        [Then(@"its number is (.*)")]
        public void ThenItsNumberIs(int p0)
        {
            Hexagram hexagram = ScenarioContext.Current.Get<Hexagram>(HexagramKey);
            int hexagramNumber = hexagram.Number;
            Assert.AreEqual(
                expected: p0, 
                actual: hexagramNumber);
        }
    }
}


//Given(/^the hexagram from top to bottom is "([^"]*)"$/) do |hexagram_string_representation|
//  @hexagram = Hexagram.new hexagram_string_representation
//end

//Then(/^its number is (#{CAPTURE_A_NON_NEGATIVE_INTEGER})$/) do |number|
//  expect(@hexagram.number).to eq(number)
//end