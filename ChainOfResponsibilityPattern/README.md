# Chain of responsibility pattern

## Intent

Chain of responsibility pattern is a behavioural design pattern that lets you pass requests along a chain of handlers.
Upon receiving a request each handler can choose to deal with the request or pass it forward. 

## Applicability

- Use the Chain of Responsibility pattern when your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.
- Use the pattern when it’s essential to execute several handlers in a particular order.
- 