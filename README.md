# TODO Makiwara
This code is a [Code Makiwara](http://github.com/MitchDenny/Makiwara/). It demonstrates a combination of technologies and patterns applied to a specific problem domain. You are free to fork this repository and create your own Makiwara.

## Problem Domain
This problem domain for this Makiwara is a TODO list application. This problem domain has the following concepts.

1. Tasks; simple items with a name and a description.
2. Users; people to which tasks can be assigned.
3. Tags; strings which allow us to group tasks together.
4. States; the state that a task is in.

## Software Patterns
This Makiwara makes use of the following formal, or informal patterns.

1. Domain Driven Design; this sample uses domain driven design to model its objects.
2. Repository Pattern; this sample uses the repository pattern to manage persistence.
3. Model-View-Controller Pattern; this sample uses the MVC pattern to manage interactions with the domain model from the UI.
4. Model-View-ViewModel Pattern; this sample uses MVVM to shield the domain model from UI implementation concerns.

## Technologies Used
This Makiware makes use of the following technologies.

1. ASP.NET MVC 4.0; the ASP.NET MVC framework provides the building blocks for building this Makiwara.
2. Entity Framework 5.0; Entity Framework provides the ORM capability for this Makiwara.
3. Twitter Bootstrap 2.2.2; provides the client UI layout grid and basic elements for this Makiwara.
4. Knockout; provides a way of binding data from JSON objects to the UI elements.
5. SQL Server LocalDB; where we store the task data when the application runs.

## Instructions
If you want to work with this Makiwara, here is what you need to do.

1. Clone the repository down to a machine with Visual Studio 2012.
2. Open the Todo.sln file inside Visual Studio 2012.
3. Hit F5 to run the application. We use LocalDB so no configuration is necesary.
4. Use the application and set breakpoints.

## About
This Makiwara was created by [Mitch Denny](http://blog.mitchdenny.com). It was based on the the [Code Makiwara](http://github.com/MitchDenny/Makiwara/).
