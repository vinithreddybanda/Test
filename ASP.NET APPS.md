#### ASP.NET Core Web App (Razor Pages)

- Web App project template uses `Razor Pages`
- page-based programming model for building Web UIs 
- `Razor Pages` simplifies the development of `page-focused scenarios`
- allowing developers to define` page-specific logic` within the same file as the `HTML markup`
- It is suitable for building web applications with a simpler structure
- each page is self-contained and designed to `handle requests and responses` directly.

___

#### ASP.NET Core Empty

- no predefined folders or files
- allows developers to add only the components and middleware they need
- ideal for advanced users
- who want complete control over the project structure
- Good when for creating `highly customized applications` from scratch

---

#### ASP.NET Core Web API

- to create `RESTful HTTP services`
- predefined folders and files for `creating and managing API endpoints`
- configured with the necessary `middleware` for building Web APIs
- best suited for building `backend services` that `expose data` and `functionality` through `HTTP endpoints`
- which intended for consumption by `client applications` such as web, mobile, or desktop apps.


#### ASP.NET Core Web API (Native)
- same but runs on specific native platform with optimizations

---

#### ASP.NET Core Web App (Model-View-Controller)
- uses the Model-View-Controller (MVC) architectural pattern
- **Models (data), Views (UI), and Controllers (business logic)**
- building complex web applications with a clear separation of concerns
- where the application logic, UI, and data access layers are distinct.

---

#### Blazor Server App

- creates a Blazor Server application
- Blazor Server allows for the development of interactive web UIs using `C# instead of JavaScript`
- app runs on the **server**, with `UI updates` sent to the `client` via `SignalR`.

---

#### Blazor WebAssembly App

- creates a Blazor WebAssembly application
- runs `C# code directly in the browser` using **WebAssembly**
- The **entire app**, **including .NET runtime**, is **downloaded** and `executed on the client side.`
- It is suitable for building `single-page applications` (SPAs) that **run entirely in the browser**
- providing a rich, responsive user experience similar to JavaScript frameworks like Angular or React.

#### Razor Class Library

- creates a library `containing reusable Razor UI components`
- These components can be `shared across multiple projects`
- Promoting code reuse and modularity
- It is ideal for developing UI components, such as `layouts, partial views, and Razor Pages`, that can be `packaged and reused` in different ASP.NET Core applications.
