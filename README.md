# [Anagram Checker](https://github.com/ayohana/anagram.git/)

#### C# Basics & Behavior Driven Development Exercise for [Epicodus](https://www.epicodus.com/), 03.03.2020

#### By [**Adela Darmansyah**](https://ayohana.github.io/portfolio/)

## Description

**This C# console application checks a list of words for anagrams.** An anagram is a word that you can rearrange the letters and it becomes a new word. For example, "bread" is an anagram of "beard". A user can input multiple words into a list and the application will let the user know which of the list of words were anagrams.

## Specs

<details>
  <summary>Click to expand!</summary>

| Spec | `Console` Input | `Console` Output |
| :-------------     | :------------- | :------------- |
| **Program Gathers & Displays User Input of a Single Word** | bread | bread |
| **Program Gathers & Displays User Input of Multiple Words** | bread beard | bread beard |
| **Program Checks for Anagrams and Display the Anagrams** | bread beard bun | bread beard |
| **Program Disregards Special Characters** | bread, beard, bun? | bread beard |

</details>

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this [repository](https://github.com/ayohana/anagram.git/)
* Open the `Command Line Interface`.
  * Navigate into the `Anagram` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
  * Navigate into the `Anagram.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
  * Navigate into the `Anagram.Solution` directory.
    * Type in the command `dotnet run` to run the application.
    * Type in the command `dotnet test` to run the tests.

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com.

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Markdown

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**