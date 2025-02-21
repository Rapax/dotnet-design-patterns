The Decorator design pattern is a structural pattern that allows behavior to be added to an object dynamically at runtime without modifying its structure. It is commonly used to extend the functionalities of objects in a flexible and reusable way.

Key Concepts:
1.	Component (Interface/Abstract Class): Defines the common interface for objects that can be decorated.
2.	Concrete Component (Actual Object): The original object that needs additional behavior.
3.	Decorator (Abstract Class): Inherits from the component and contains a reference to a component object.
4.	Concrete Decorators: Implement additional behaviors and enhance the original object dynamically.

When to Use the pattern:
- When you need to add responsibilities dynamically to individual objects without affecting other instances. 
- When subclassing leads to an explosion of classes due to multiple combinations of functionalities. 
- When you want to adhere to the Open/Closed Principle (open for extension but closed for modification). 
- When modifications must be reversible and optional at runtime.

Advantages of the pattern:
- Flexible Extension: Behaviors can be added or removed dynamically at runtime. 
- Single Responsibility Principle (SRP): Keeps different functionalities separate in different decorator classes. 
- Avoids Class Explosion: Prevents the need for multiple subclasses to achieve different combinations of behaviors. 
- Supports Composition over Inheritance: Allows functionalities to be mixed and matched without creating large inheritance trees.

When NOT to Use the pattern:
- When behavior changes must apply to all instances of a class (use inheritance instead). 
- When the system is already complex and adding decorators would increase confusion. 
- When there is tight coupling between the decorated component and its decorators.

Real-World Usage:
- GUI Frameworks (e.g., Windows Forms, WPF): A TextBox can be decorated with a BorderDecorator, ScrollbarDecorator, etc. 
- Logging: A Logger can be decorated with a TimestampDecorator or FileLoggingDecorator. 
- Compression & Encryption Streams: FileStream can be wrapped with CompressionStream, then EncryptionStream. 
- Middleware in ASP.NET Core: An HTTP request pipeline uses decorators to add functionalities like authentication, logging, etc.