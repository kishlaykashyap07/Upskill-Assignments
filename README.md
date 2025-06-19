# Order Processing Application

**Date:** 2025-06-19  
**Author:** kishlaykashyap07

## Assignment Overview

Imagine you're writing an order processing application for a large company. In the past, this company used a fairly random mixture of manual and ad-hoc automated business practices to handle orders; they now want to put all these various ways of handling orders together into one system: your application.

After a full day of workshops, the following set of rules need to be managed by the new system:

### Business Rules

1. **Physical Product**: If the payment is for a physical product, generate a packing slip for shipping.
2. **Book**: If the payment is for a book, create a duplicate packing slip for the royalty department.
3. **Membership**: If the payment is for a membership, activate that membership.
4. **Membership Upgrade**: If the payment is an upgrade to a membership, apply the upgrade.
5. **Membership Notification**: If the payment is for a membership or upgrade, e-mail the owner and inform them of the activation/upgrade.
6. **Video - "Learning to Ski"**: If the payment is for the video "Learning to Ski," add a free "First Aid" video to the packing slip (the result of a court decision in 1997).
7. **Agent Commission**: If the payment is for a physical product or a book, generate a commission payment to the agent.

## Implementation Details

This implementation uses the **Strategy Pattern** to ensure each business rule is encapsulated in its own processor, making the system easy to maintain and extend with new rules.


## Design Patterns & Principles Used

1. **Strategy Pattern**: Each processor implements a strategy for handling a specific type of product or business rule.

2. **SOLID Principles**:
   - **Single Responsibility**: Each processor handles only one type of product
   - **Open/Closed**: System is open for extension (new processors) but closed for modification
   - **Liskov Substitution**: All processors can be used interchangeably through the IOrderProcessor interface
   - **Interface Segregation**: Clean, focused interfaces
   - **Dependency Inversion**: High-level modules depend on abstractions

## Building and Running the Application

### Prerequisites
- .NET SDK 7.0 or higher
- Visual Studio 2022 or Visual Studio Code

## How it works: Using the Application
The application provides an interactive console interface with the following options:

1. **Process a new order - Create a custom order with:**
   - Customer and agent information
   - Multiple products of different types
   - Custom pricing
2. **Process example orders - Run a demo that processes pre-configured orders demonstrating all business rules:**
   - Physical products with packing slips and commission
   - Books with royalty department slips and commission
   - Membership activation with email notification
   - Membership upgrades with email notification
   - "Learning to Ski" video with free First Aid video
   - Mixed orders with multiple product types
   - Exit - Close the application

### Test case:
![image](https://github.com/user-attachments/assets/a826c8a0-bffd-4287-afde-d012fd1645ad)


### Build and Run

```bash
# Clone the repository
git clone https://github.com/kishlaykashyap07/OrderProcessingSystem.git
cd OrderProcessingSystem

# Build the solution
dotnet build

# Run the application
dotnet run --project OrderProcessingSystem/OrderProcessingSystem.csproj



