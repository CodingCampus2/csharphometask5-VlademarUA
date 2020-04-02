# Task 5

## Prerequisites:
Read .NET Book Zero until Chapter 19.

## Description:
Deadly Virus 2
Virus story from task1 continues...
Your task is to create a SuperVirus class that derives from [Task5.Virus] following next rules. New virus should be:
- twice as mortal as the old one
- named extra scary - "supervirus" instead of simple "virus" at the end of the name
Also when new super virus emerges (during construction):
- the parent should be defeated by setting the [Task5.Virus.Alive] to false. It's only possibe through [Task5.Virus] constructor that takes bool as a state of liveliness.
- DateTimeOfCreation should be set to current UTC date and time

## Goal:
Create and return an instance of class derived from [Task5.Virus] following the rules mentioned in the description.

## Example input: 
task.KillProbability: 0.3575393
task.VirusName: "Sweetwatervirus""
task.VictimName: "Susan"
UTC time: 02.04.2020 13:15:06

## Example derived class fields' results of get:
virus.Alive: false
virus.Name: "Sweetwatersupervirus"
virus.DateTimeOfCreation: 02.04.2020 13:15:06
virus.KillProbability: 0.7150786
virus.VictimName: "Susan"

## Task clarifications:
- All settable fields of your supervirus instance will be set to random values during the test
- KillProbality shouldn't be greater then 1.0

## Credits:
https://covid19.com.ua/