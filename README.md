# _WordCounter_

#### _This application counts the number of times a specified word appears in a sentence, 4 Oct 2019_

#### By _**Christopher Burge**_

## Specifications

| Behavior | Input | Output |
| -------- | :---------: | :---------: |
| The program will split a phrase into an array of words | 'walk the dog' | 'walk', 'the', 'dog' |
**This is the simplest possible behavior because it sets the sentence up for being able to iterate through each individual word**
| The program will count the times a word appears in a sentence | 'the' and 'walk the dog' | 'The word 'the' is used '1' time |
| The program will not count partial matches | 'the' and 'The dog went down there.' | The word 'the' is used '1' time |
| The program will look for multiple matches | ' the' and 'walk the dog down the street.' | The word 'the' is used '2' times |


## Setup/Installation Requirements

* _Clone this repository and navigate to the "hangman" project directory_
* _Navigate to "WordCounter"_
* _Run the command "dotnet restore"_
* _Run the command "dotnet run"_

## Technologies Used

_C#, .NET_

### License

*Open-source*

Copyright (c) 2019 **_Christopher Burge_**