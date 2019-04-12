# Ribosome
Ribosome is a new code generation tools that will help you achieve success with your software projects, by generating for you the 3 commons layers of a software : DAL, API, the link between.

He's working with AspNetCore and EntityFrameworkCore and he will be compatible with AspMvc, WebApi and EntityFramework 6 soon.

## Philosophy
Ribosome do only what you tell him what to do, no more, no less :
+ He delivers only the generic code of a software, business code will always remain to be the team project jobs.
+ Tell Ribosome how to architect the code, because there is no unique software architecture that have all the answers.
+ He write the code like a human with quality and as little as possible tech debt in mind, so that you can maintain it easily.

## What you get
Layers that Ribosome can generate for you :

1. Create a Data Access Layer (DAL) with an existing or a new DB
	+ Expose more than 13 methods for each DB Objects 
	+ Synchronize by delta data cluster
	+ Have an audit-trail

2. Expose a CRUD API Restfull with
	+ Swagger compatible
	+ HATEOAS link 
	+ Versionning
	+ Paginate
	+ Sorts
	+ Filters... with the respect of RFC 2616
	
3. Build the link between DAL and API to get a working software!

Every layers manage logging events and are async compatible.

## Getting started
[Go to the wiki](https://github.com/synodetechnologies/Ribosome/wiki)
