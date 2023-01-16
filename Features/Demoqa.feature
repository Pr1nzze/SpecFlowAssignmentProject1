Feature: Demoqa

Background: 
     Given I am on demoqa site


@Demoqa @RegressionTest
Scenario: [Demoqa registration test]
    When I Click on Elements
    And I Click on text Box
    And I Enter FirstName
    And I Enter Email
    And I Enter Current Address
    And I Enter Permanent Address
    And I Click Submit
    Then the form is submited
