Feature: SearchingBrand

As User I should see brand's products when I'm searching existing brand

@Search
Scenario: SearchningBrand
	Given I should see Main page
	When I search <brand>
	Then I should see products of the <brand>
	Examples: 
	|brand|
	|"Burberry"|
