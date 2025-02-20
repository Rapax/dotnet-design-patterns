

Behavioral Pattern: Strategy

Also known as Policy. The most of commonly used behavioral pattern.

When to Use the Strategy Pattern?
- When you have multiple variations of an algorithm and want to switch between them dynamically. 
- When you want to avoid using long if-else or switch statements to select behavior. 
- When you want to encapsulate and isolate algorithms to make them more maintainable.

Advantages of the Strategy Pattern:
 - Encapsulation – Each strategy is in a separate class, making the code cleaner. 
 - Open/Closed Principle – You can add new strategies without modifying existing code. 
 - Runtime Flexibility – Change behavior dynamically without modifying the client code.

When NOT to Use?

- If you have a fixed algorithm that doesn’t require multiple variations. 
- When performance is a concern (due to additional object creation and method calls).

Real-World Use Cases:
 - Sorting Algorithms (Bubble Sort, Quick Sort, Merge Sort)
 - Payment Processing (Credit Card, PayPal, Crypto)
 - Compression Algorithms (ZIP, RAR, GZIP)
 - Logging Mechanisms (Console, File, Database)