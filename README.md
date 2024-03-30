# E-commerce Microservices Architecture
This project implements a modular e-commerce application using microservices architecture on the .NET 8 platform.

Here's a breakdown of the key components:

# Microservices:

* Catalog: Built with ASP.NET Core Minimal APIs, leverages the latest features of .NET 8 and C# 12. Implements Vertical Slice Architecture and CQRS with MediatR. Utilizes Marten for document database persistence on PostgreSQL and Carter for endpoint definition. Includes cross-cutting concerns like logging, exception handling, and health checks. Containerized with Docker.
* Basket: An ASP.NET 8 Web API following RESTful principles for CRUD operations. Uses Redis as a distributed cache and implements Proxy, Decorator, and Cache-Aside design patterns. Consumes the Discount gRPC service for price calculations and publishes BasketCheckout events to RabbitMQ using MassTransit. Containerized with Docker.
* Discount: A gRPC server application built with ASP.NET enabling high-performance communication with the Basket microservice. Exposes services using Protobuf messages. Utilizes Entity Framework Core with SQLite for data persistence and containerized with Docker.
* Ordering: Implements DDD, CQRS, and Clean Architecture best practices. Uses MediatR, FluentValidation, and Mapster for CQRS implementation. Leverages domain events and integration events. Employs Entity Framework Core with a code-first approach and migrations on a SQL Server database. Consumes the BasketCheckout event queue from RabbitMQ using MassTransit. Containerized with Docker.
* Yarp API Gateway: Implements API gateways with Yarp Reverse Proxy, applying the Gateway Routing Pattern for efficient request routing. Supports configuration options like routes, clusters, paths, transforms, and destinations. Includes rate limiting with FixedWindowLimiter.

## Additional Components:

* RabbitMQ Event Bus: Provides asynchronous communication between microservices using a publish/subscribe topic exchange model. MassTransit facilitates abstraction over RabbitMQ.
* WebUI ShoppingApp: An ASP.NET Core Razor Pages application with Bootstrap 4 for UI development. Consumes Yarp API Gateway APIs using Refit with a generated HttpClientFactory. Utilizes ASP.NET Core Razor features like View Components, partial views, Tag Helpers, and more.

## Project Structure:

* Adheres to Clean Architecture principles, utilizing a layered application architecture with DDD best practices.
* Implements the NLayer Hexagonal architecture (Core, Application, Infrastructure, and Presentation layers).
* Employs Domain-Driven Design concepts like Entities, Repositories, Domain/Application Services, and DTOs.
* Applies SOLID principles for maintainable and extensible code.
* Utilizes dependency injection, logging, validation, exception handling, and other design patterns.

## Containerization:

* All microservices are containerized with Docker for a portable and scalable deployment environment.
* Docker Compose facilitates multi-container orchestration for streamlined development and deployment.
