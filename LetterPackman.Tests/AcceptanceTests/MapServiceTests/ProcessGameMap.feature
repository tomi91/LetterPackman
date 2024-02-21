Feature: ProcessGameMap

Follow a path of characters & collect letters

@unit
Scenario: Valid maps - A basic example
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | - | - | - | A  | - | - | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | C  |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	When I execute the ProcessGameMap function
	Then result should be Letters: ACB
	And result should be Path as characters: @---A---+|C|+---+|+-B-x

@unit
Scenario: Valid maps - Go straight through intersections
    Given I have a map
        |    |   |    |   |   |   |   |    |   |    |
        | @  |   |    |   |   |   |   |    |   |    |
        | \| |   | +  | - | C | - | - | +  |   |    |
        | A  |   | \| |   |   |   |   | \| |   |    |
        | +  | - | -  | - | B | - | - | +  |   |    |
        |    |   | \| |   |   |   |   |    |   | x  |
        |    |   | \| |   |   |   |   |    |   | \| |
        |    |   | +  | - | - | - | D | -  | - | +  |
	When I execute the ProcessGameMap function
	Then result should be Letters: ABCD
	And result should be Path as characters: @|A+---B--+|+--C-+|-||+---D--+|x

@unit
Scenario: Valid maps - Letters may be found on turns
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        | @ | - | - | - | A  | - | - | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | \| |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | C  |
	When I execute the ProcessGameMap function
	Then result should be Letters: ACB
	And result should be Path as characters: @---A---+|||C---+|+-B-x

@unit
Scenario: Valid maps - Do not collect a letter from the same location twice
    Given I have a map
        |   |   |   |   |     |   |     |   |     |     |     |   |     |
        |   |   |   |   | +   | - | O   | - | N   | -   | +   |   |     |
        |   |   |   |   | \|  |   |     |   |     |     | \|  |   |     |
        |   |   |   |   | \|  |   |     |   | +   | -   | I   | - | +   |
        | @ | - | G | - | O   | - | +   |   | \|  |     | \|  |   | \|  |
        |   |   |   |   | \|  |   | \|  |   | +   | -   | +   |   | E   |
        |   |   |   |   | +   | - | +   |   |     |     |     |   | S   |
        |   |   |   |   |     |   |     |   |     |     |     |   | \|  |
        |   |   |   |   |     |   |     |   |     |     |     |   | x   |
	When I execute the ProcessGameMap function
	Then result should be Letters: GOONIES
	And result should be Path as characters: @-G-O-+|+-+|O||+-O-N-+|I|+-+|+-I-+|ES|x

@unit
Scenario: Valid maps - Keep direction, even in a compact space
    Given I have a map
        |   |    |   |   |   |   |   |   |
        |   | +  | - | L | - | + |   |   |
        |   | \| |   |   | + | A | - | + |
        | @ | B  | + |   | + | + |   | H |
        |   | +  | + |   |   |   |   | x |
	When I execute the ProcessGameMap function
	Then result should be Letters: BLAH
	And result should be Path as characters: @B+++B|+-L-+A+++A-+Hx

@unit
Scenario: Valid maps - Ignore stuff after end of path
    Given I have a map
        |   |   |   |   |   |    |   |   |   |   |   |   |   |   |   |   |
        | @ | - | A | - | - | +  |   |   |   |   |   |   |   |   |   |   |
        |   |   |   |   |   | \| |   |   |   |   |   |   |   |   |   |   |
        |   |   |   |   |   | +  | - | B | - | - | x | - | C | - | - | D |
	When I execute the ProcessGameMap function
	Then result should be Letters: AB
	And result should be Path as characters: @-A--+|+-B--x

@unit
Scenario: Invalid maps - Missing start character
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        |   |   |   | - | A  | - | - | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | C  |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	When I execute the ProcessGameMap function
	Then exception should be generated: Character '@' not found in map.

@unit
Scenario: Invalid maps - Missing end character
    Given I have a map
        |   |   |   |    |   |   |   |    |
        | @ | - | - | A  | - | - | - | +  |
        |   |   |   |    |   |   |   | \| |
        |   | B | - | +  |   |   |   | C  |
        |   |   |   | \| |   |   |   | \| |
        |   |   |   | +  | - | - | - | +  |
	When I execute the ProcessGameMap function
	Then exception should be generated: Character 'x' not found in map.

@unit
Scenario: Invalid maps - Multiple starts1
    Given I have a map
        |   |   |   |   |    |   |   |   |    |
        |   | @ | - | - | A  | - | @ | - | +  |
        |   |   |   |   |    |   |   |   | \| |
        | x | - | B | - | +  |   |   |   | C  |
        |   |   |   |   | \| |   |   |   | \| |
        |   |   |   |   | +  | - | - | - | +  |
	When I execute the ProcessGameMap function
	Then exception should be generated: More that one '@' found in map.

@unit
Scenario: Invalid maps - Multiple starts2
    Given I have a map
        |   |   |   |   |   |   |   |    |
        | @ | - | - | A | - | - | - | +  |
        |   |   |   |   |   |   |   | \| |
        |   |   |   |   |   |   |   | C  |
        |   |   |   |   |   |   |   | x  |
        |   |   |   | @ | - | B | - | +  |
	When I execute the ProcessGameMap function
	Then exception should be generated: More that one '@' found in map.

@unit
Scenario: Invalid maps - Multiple starts3
    Given I have a map
        |   |   |   |   |    |   |   |   |
        |   | @ | - | - | A  | - | - | x |
        |   |   |   |   |    |   |   |   |
        | x | - | B | - | +  |   |   |   |
        |   |   |   |   | \| |   |   |   |
        |   |   |   |   | @  |   |   |   |
	When I execute the ProcessGameMap function
	Then exception should be generated: More that one '@' found in map.

@unit
Scenario: Invalid maps - Fork in path
    Given I have a map
        |   |   |   |    |   |   |   |    |
        |   |   |   |    |   |   | - | B  |
        |   |   |   |    |   |   |   | \| |
        | @ | - | - | A  | - | - | - | +  |
        |   |   |   |    |   |   |   | \| |
        |   |   | x | +  |   |   |   | C  |
        |   |   |   | \| |   |   |   | \| |
        |   |   |   | +  | - | - | - | +  |
	When I execute the ProcessGameMap function
	Then exception should be generated: Fork in path found in map.

@unit
Scenario: Invalid maps - Broken path
    Given I have a map
        |   |   |   |   |   |    |   |   |
        | @ | - | - | A | - | +  |   |   |
        |   |   |   |   |   | \| |   |   |
        |   |   |   |   |   |    |   |   |
        |   |   |   |   |   | B  | - | x |
	When I execute the ProcessGameMap function
	Then exception should be generated: Broken path found in map.

@unit
Scenario: Invalid maps - Multiple starting paths
    Given I have a map
        |   |   |   |   |   |   |   |   |   |
        |   | - | B | - | @ | - | A | - | x |
	When I execute the ProcessGameMap function
	Then exception should be generated: Multiple starting paths found in map.

@unit
Scenario: Invalid maps - Fake turn
    Given I have a map
        |   |   |   |   |   |   |   |   |   |
        | @ | - | A | - | + | - | B | - | x |
	When I execute the ProcessGameMap function
	Then exception should be generated: Fake turn in map.