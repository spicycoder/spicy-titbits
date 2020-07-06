Feature: Recipes Feature
	In order to easily retrieve recipe details
	As a casual cook
	I want to be have simple API endpoints

Scenario: Read all recipes
	Given An API endpoint for getting Recipes
	When I get the recipes
	Then It should return 3 recipes
