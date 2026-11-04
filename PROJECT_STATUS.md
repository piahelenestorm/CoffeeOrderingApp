\# Coffee Ordering App – Project Status



\*\*Last updated:\*\* 2026-11-04



\## Project goal



Build a fullstack coffee ordering application while improving skills in C#, ASP.NET Core, databases, Angular and Git.



\## Tech stack



\- Backend: C#, .NET 10, ASP.NET Core Web API with Controllers

\- Frontend: Angular 22, TypeScript, RxJS Observables and Signals

\- Database: SQL Server LocalDB and Entity Framework Core

\- Testing: xUnit

\- Tools: Visual Studio Community for backend, VS Code for frontend, Git and GitHub



\## Current phase



Phase 1 – Development environment and Git setup.



\## Completed



\- Verified Visual Studio Community and ASP.NET development tools

\- Verified .NET SDK 10.0.403

\- Verified SQL Server LocalDB

\- Verified Node.js 24.15.0 and npm 11.12.1

\- Verified Angular CLI 22.1.8

\- Verified Git 2.51.0

\- Configured Git with a private GitHub noreply email

\- Created `CoffeeOrderingApp` with `backend` and `frontend` folders

\- Initialized Git repository with `main` as the default branch

\- Created `README.md`

\- Created `.gitignore`



\## Current task



\- Create `PROJECT\_STATUS.md`

\- Make the first Git commit



\## Next tasks



\- Connect the repository to GitHub

\- Create ASP.NET Core Web API using Controllers in Visual Studio Community

\- Learn basic C# concepts and debug the first API endpoint



\## Learning principles



\- Explain every code example, including the filename, location and purpose

\- Compare C# with TypeScript and Angular where helpful

\- Practice debugging with breakpoints

\- Use oral-exam questions to check understanding

\- Keep the application simple: no admin panel and no payment integration



\## Concepts learned



\- Git repository

\- Branch and feature branch

\- Merge

\- Untracked files

\- Gitignore



\## Git status



\- Branch: `main`

\- First commit: Not created yet

\- GitHub: Not connected yet


## Session 1 – First ASP.NET Core Web API

**Status:** Completed

### What We Accomplished
- Initialized a Git repository with `main` as the default branch.
- Created a GitHub repository and pushed the initial commit.
- Created `CoffeeOrderingApp.API` in Visual Studio Community.
- Configured the project to use .NET 10, ASP.NET Core Web API, and Controllers.
- Added `nuget.org` as a NuGet package source to resolve a package restore error.
- Successfully built the backend project.
- Started the API with debugging enabled.
- Confirmed that the API was listening on HTTP and HTTPS.
- Tested `https://localhost:7005/WeatherForecast` and received a JSON response.
- Stopped the debugging session successfully.

### Concepts Learned
- Git repositories, branches, staging, commits, and pushing to GitHub.
- The differences between Build, Start Debugging, and Start Without Debugging.
- Why a successful build does not guarantee correct runtime behavior.
- The basics of localhost, HTTP endpoints, routing, and JSON responses.
- How to use Visual Studio's Output window to inspect application startup.
- Why a 404 response at `/` is expected when no route is configured for that URL.

### Learning Guidelines
- Explain every new file, its full path, where to create it, and its purpose.
- Explain code step by step, including relevant C# concepts.
- Always explain which Build, Run, or Debug action to use and why.
- Compare C# concepts with Angular and TypeScript when helpful.
- Introduce debugging techniques early and practice them regularly.
- Ask one interview-style comprehension question at a time.
- Use English for project documentation, commit messages, and code comments.

### Next Session
- Explore the generated ASP.NET Core project structure.
- Review `Program.cs`, `WeatherForecast.cs`, and `WeatherForecastController.cs`.
- Learn foundational C# concepts using the existing project code.
- Begin replacing the WeatherForecast example with Coffee Ordering functionality.

