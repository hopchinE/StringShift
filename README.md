## Intro

This is a basic C# command line app which will accept a string and an integer value, then shift the provided string to the right by the integer provided

## Prerequisites 

In order to run this you should have atleasr .Net version 9 installed on your machine

## Building

To build the executable of this application you'll need to run the following command, which assumes you're running from the root directory of the project

> dotnet publish .\StringShift\StringShift.csproj

This will then build an exe file in a newly created directory located in .\StringShift\bin\Release\net9.0\win-x64\publish\ which can then be run either from the commandline or by double clicking the exe file