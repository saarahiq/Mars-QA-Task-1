Feature: LanguageFeature

As a Mars website user
I would like to add, update and delete language on my profile details page
so that I can manage my languages on my profile successfully

@tag1
Scenario: Add new Language to Profile
	Given I click on Add New button
	When I enter '<Language>' and '<Level>' 
	And I click on Add button
	Then I should see '<Notification>' 

Examples: 
| Language | Level  | Notification                             |
| English  | Fluent | English has been added to your languages |
| French   | Basic  | French has been added to your languages  |