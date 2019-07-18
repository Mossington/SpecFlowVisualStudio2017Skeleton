Feature: ExampleFeatureFile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Test
Scenario: Can navigate to the Act Consultancy Website via Google Chrome
	Given I input the Aat Consultancy url in to google chrome
	Then i am on the Act Consultancy webpage

@Test @Firefox
Scenario: Can navigate to the Act Consultancy Website via Firefox
	Given I input the Aat Consultancy url in to FireFox
	Then i am on the Act Consultancy webpage

@Test @InternetExplorer
Scenario: Can navigate to the Act Consultancy Website via Internet Explorer
	Given I input the Aat Consultancy url in to Internet Explorer
	Then i am on the Act Consultancy webpage
