# _WordCounter_

#### _This application counts the number of times a specified word appears in a sentence, 4 Oct 2019_

#### By _**Christopher Burge**_

## Description

_This console application is for a word counter. A user is prompted for a sentence or phrase, as well as a word. The user is then returned the number of times that word is used in the sentence. The application accounts for puncutation, but it does not account for a plural version of that word._

## Specifications

| Behavior | Input | Output |
| -------- | :---------: | :---------: |
| The program will split a phrase into an array of words | 'walk the dog' | 'walk', 'the', 'dog' |
**This is the simplest possible behavior because it sets the sentence up for being able to iterate through each individual word**
| The program will count the times a word appears in a sentence | 'the' and 'walk the dog' | '1' |
| The program will not count partial matches | 'the' and 'The dog went down there.' | '1' |
| The program will look for multiple matches | 'the' and 'walk the dog down the street.' | '2' |
| The program will ignore punctuation | 'dog' and 'Take the dog to play with another dog.' | '2' |


## Setup/Installation Requirements

* _Clone this repository using this link: https://github.com/burgechris/WordCounter.git_
* _Navigate to "WordCounter"_
* _Run the command "dotnet restore"_
* _Run the command "dotnet run"_

## Technologies Used

_C#, .NET_

### License

*Open-source*

Copyright (c) 2019 **_Christopher Burge_**