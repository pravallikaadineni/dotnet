Feature: productfeature

A short summary of the feature

@tag1
Scenario: AddProductToCart
    Given User gives prodname as 'bat'
    Given User gives qty as 5
    When  prodname not null or empty and qty >0
    Then Successfully added
