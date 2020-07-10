# Bridge pattern

## Intent

- Decouple an abstraction from its implementation

## Checklist

- Decide if 2 orthogonal dimensions exist in the domain
    * abstraction/platform
    * domain/infrastructure
    * interface/implementation
    * front-end/back-end
- Design the separation of concerns:
    * what does the client want
    * what do the platforms provide
- Design a platform-oriented interface that is minimal, necessary, and sufficient. Its goal is to decouple the abstraction from the platform.
- Define a derived class of that interface for each platform.
- Create the abstraction base class that "has a" platform object and delegates the platform-oriented functionality to it.
- Define specializations of the abstraction class if desired.