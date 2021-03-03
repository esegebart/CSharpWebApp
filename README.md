## Vermeer Web App

## Motivation
This coding challenge was very exciting to work on as it truly aligns with what I want to do in software development. I really wanted to keep working on it, but I had spent 
more than the time allotted to work on it. Web apps are something I have done one other time, so the material looked very familiar, but putting it together was another step.
This was very exciting as I want to be in application development and my current situation is more in DevOps, Embedded Systems, and Testing. Thank you for the opportunity to grow!

I have used MVC before in a SmartHome thermostat I designed in school, you can view that here https://github.com/esegebart/SmartHomeThermostat_JavaFX.
(This was when I was first learning GIT so my files are all added manually and hard to navigate and I unfortunately broke the computer with that project on it 
so here are some code samples:
Main.java - https://github.com/esegebart/SmartHomeThermostat_JavaFX/blob/master/Main.java
HolidayController - https://github.com/esegebart/SmartHomeThermostat_JavaFX/blob/master/HolidayController.java
IncrementTempController - https://github.com/esegebart/SmartHomeThermostat_JavaFX/blob/master/IncrementTempController.java
ProgramScreen - https://github.com/esegebart/SmartHomeThermostat_JavaFX/blob/master/ProgramScreen.java
This was coded using Java 8 and JavaFx for the GUI)

## Code style
Since professional design and functionality was important to this project, I tried to hack a solution out first, but ran out of time.

## What My Next Steps Would Be
I would figure out next how to implement and onClick listener to my Submit button that would use the GitHub Api and build a table with HTML for my data to be displayed in.
I would need to make sure my Json was deserialized and parsed. The data would then update in my list of results. I try to focus on small steps, like TDD, and get the smallest
thing working possible first and then build on that.
 
## Screenshots
The two search bars I was trying to hack out. 
![image](https://user-images.githubusercontent.com/36378900/109737449-b444a400-7b8b-11eb-8d73-582ed88c3072.png)

## Tech/framework used

<b>Built with</b>
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Octokit](https://github.com/octokit/octokit.net) - An attempt to use!
- [Newtonsoft.json](https://www.newtonsoft.com/json) - To try and serialize my json data!
- [Visual Studio Professional 2019](https://visualstudio.microsoft.com/downloads/)
- [Ajax/jQuery](https://api.jquery.com/category/ajax/)

## Features
### Products Search Bar
I tried to hardcode some products into a fixed array in the Controller, whereas in the real world, I would query a database or use an external data source. I wanted to return
a list of products as an IEnumerable and get the product by entering 1, 2, 3. The HTTP page was trying to use Ajax to call the web API and implement jQuery to make Ajax calls
to update the page. 

### GitHub Search
I then used my Products MVC to try and implement the GitHub search. I created a class with the information I wanted to display in my Models (Repositories, list of 
repositories), in my ProductsController I tried to add an ActionResult Index() which would use the web client to get the repositories from GitHub and deserialize them 
to return them in the View.

## Code Example
Trying to use the WebClient to get the repos from the GitHub API and deserialize them to list on the page.
![image](https://user-images.githubusercontent.com/36378900/109737509-cb839180-7b8b-11eb-8b4a-26ebae693213.png)

## Installation
Provide step by step series of examples and explanations about how to get a development env running.

## API Reference
https://api.github.com/search/users?q=example

## Tests
I did not make it to the testing.

