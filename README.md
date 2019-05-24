# Ribosome
Ribosome is a new AI code generation at your service that will help you achieve success with your software projects, by generating for you the 3 commons layers of a software : Data managing, API exposition, the link between. You give him the specifications and he writes the code for you a functionnal application in a few minutes.

He's working with AspNetCore and EntityFrameworkCore and he's compatible with AspMvc, WebApi and EntityFramework 6.

## Philosophy
You are the architect that give him the specifications and he writes the code for you., Ribosome do only what you tell him what to do, no more, no less :
+ He delivers only the generic code of a software, business code will always remain to be the team project dev.
+ You tell Ribosome how to architect the code, because there is no unique software architecture that have all the answers.
+ He writes the code like a human with quality and as little as possible tech debt in mind, so that you can maintain and extend it easily.


## What you get
Layers that Ribosome can generate for you :

1. Data Cluster Manager with an existing or a new DB that :
	+ Contain a full working DAL
	+ All CRUD methods are driven by a fluent state machine
	+ Synchronize data cluster by delta
	+ Expose more than 13 methods for each DB Objects 
	+ Have an audit-trail

2. API Cluser Manager with :
	+ Ressources oriented with CRUD methods that use HTTP verbs... with the respect of the RFC 2616
	+ Managing clusters ressources
	+ Swagger compatible
	+ APIRestfull level 5 : Versionning, pagination, sorts, filters, HATEOAS links...
	+ Can be used directly with ASP / Angular
	
3. The link between DAL and API to get a working software, that is compatible with [SOA](https://en.wikipedia.org/wiki/Service-oriented_architecture)/[ROA](https://en.wikipedia.org/wiki/Resource-oriented_architecture)/[Microservices](https://en.wikipedia.org/wiki/Microservices) architecture!
The application can also be used with a data lake.

Every layers manage logging events and are async compatible. Also everything is extendable if you want to specify the behaviors of the written application.

## Getting started
[Go to the wiki](https://github.com/synodetechnologies/Ribosome/wiki)
