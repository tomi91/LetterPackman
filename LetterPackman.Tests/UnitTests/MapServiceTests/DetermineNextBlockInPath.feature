Feature: DetermineNextBlockInPath

Determines next block in path

@unit
Scenario: Valid next block - start
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | H | - | - | A  | C | D | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | G  |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	And previous block is: @
	And current block is: @
	When I execute the DetermineNextBlockInPath function
	Then result should be: H

@unit
Scenario: Valid next block - start bottom
    Given I have a map
        |    |   |    |   |   |   |   |    |   |    |
        | @  |   |    |   |   |   |   |    |   |    |
        | Q  |   | +  | - | C | - | - | +  |   |    |
        | A  |   | \| |   |   |   |   | \| |   |    |
        | +  | - | -  | - | B | - | - | +  |   |    |
        |    |   | \| |   |   |   |   |    |   | x  |
        |    |   | \| |   |   |   |   |    |   | \| |
        |    |   | +  | - | - | - | D | -  | - | +  |
	And previous block is: @
	And current block is: @
	When I execute the DetermineNextBlockInPath function
	Then result should be: Q

@unit
Scenario: Valid next block - right
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | - | - | - | A  | C | D | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | G  |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	And previous block is: A
	And current block is: C
	When I execute the DetermineNextBlockInPath function
	Then result should be: D

@unit
Scenario: Valid next block - left
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | - | - | - | A  | C | D | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | G  |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	And previous block is: D
	And current block is: C
	When I execute the DetermineNextBlockInPath function
	Then result should be: A

@unit
Scenario: Valid next block - bottom
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | - | - | - | A  | - | - | Z | Y  |
        |   |   |   |   |    |   |   |   | T  |
        | x | - | B | - | +  |   |   |   | \| |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	And previous block is: Z
	And current block is: Y
	When I execute the DetermineNextBlockInPath function
	Then result should be: T

@unit
Scenario: Valid next block - top
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | - | - | - | A  | - | - | Z | Y  |
        |   |   |   |   |    |   |   |   | T  |
        | x | - | B | - | +  |   |   |   | \| |
        |   |   |   |   | D  |   |   |   | \| |
        |   |   |   |   | P  | V | - | - | +  |
	And previous block is: V
	And current block is: P
	When I execute the DetermineNextBlockInPath function
	Then result should be: D

@unit
Scenario: Valid next block - bottom direction change
    Given I have a map
        |   |   |   |   |   |    |   |   |
        | @ | - | - | A | C | +  |   |   |
        |   |   |   |   |   | T  |   |   |
        |   |   |   |   |   | \| |   |   |
        |   |   |   |   |   | B  | - | x |
	And previous block is: C
	And current block is: +
	When I execute the DetermineNextBlockInPath function
	Then result should be: T
