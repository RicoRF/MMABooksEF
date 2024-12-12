# MMABooksEF Project

## Project Overview
The MMABooksEF project is a Windows desktop application designed for managing product maintenance in a simulated bookstore inventory system. Built using Entity Framework (EF) with a focus on object-relational mapping (ORM), the application adheres to clean architecture principles and provides a user-friendly interface for managing product data.

The project allows users to perform CRUD (Create, Read, Update, Delete) operations on products within a SQL database. All product-related data is retrieved, updated, and manipulated using Entity Framework, ensuring seamless database interactions.

---

## Features
1. **Product Management**:
   - **Add Products**: Add new products to the database.
   - **Modify Products**: Update product details like description, unit price, and quantity on hand.
   - **Delete Products**: Remove products from the inventory.
   - **Search Products**: Search for products by their product code.

2. **Forms**:
   - **Main Form**:
     - Displays product details.
     - Includes options for adding, modifying, and deleting products.
     - "Get Product" button for searching products by their code.
   - **Add/Modify Form**:
     - Used to add or edit product information.
     - Includes input validation to ensure data consistency.

3. **Data Validation**:
   - Input validation ensures all fields are correctly formatted and required data is entered before submission.

4. **Entity Framework Integration**:
   - Uses EF to manage database interactions, ensuring clean separation of concerns.

---

## Database Schema
The application interacts with the `MMABook` database, which includes the following tables:

- **Products**:
  - ProductCode (Primary Key)
  - Description
  - UnitPrice
  - OnHandQuantity

- **Customers, Invoices, and Related Tables** (part of the extended database schema):
  - These tables simulate a real-world inventory and customer management system but are not directly modified in this application.

---

## Technical Specifications
- **Framework**: .NET Framework
- **Programming Language**: C#
- **Database**: SQL Server
- **ORM**: Entity Framework
- **Architecture**:
  - Separation of UI and data layers to promote clean architecture.

---

## Requirements
- **Main Form**:
  - Launches first upon application startup.
  - Displays product details and action buttons for CRUD operations.
  - Text fields, except for the product code field, are read-only by default.

- **Add/Modify Form**:
  - Opens as a modal form.
  - Provides input fields for all product attributes.

- **Validation**:
  - Validates user input for correctness and completeness.
  - Ensures no invalid data is submitted to the database.

- **Database Operations**:
  - CRUD operations are implemented via Entity Framework, adhering to best practices for ORM.

---

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/RicoRF/MMABooksEF.git
   ```

2. Open the solution in Visual Studio.

3. Set up the database connection:
   - Update the connection string in `app.config` to point to your SQL Server instance.

4. Restore NuGet packages:
   ```bash
   nuget restore
   ```

5. Run the application:
   - Press `F5` or click `Start` in Visual Studio.

---

## Lessons Learned
This project provided hands-on experience with:
- Designing and implementing a Windows Forms application using .NET.
- Leveraging Entity Framework for database interactions.
- Structuring and validating user input in desktop applications.
- Using modal forms for clean, user-focused workflows.

---

## Future Enhancements
- Implement user authentication and role-based access control.
- Add logging for database operations.
- Extend functionality to support customer and invoice management.
- Refactor to use a more modern UI framework like WPF.

---

## Author
**Federico Ferrante**  
Passionate full-stack developer with experience in designing and implementing scalable, user-friendly applications.

Feel free to reach out with questions or suggestions via [GitHub](https://github.com/RicoRF) or [LinkedIn](https://linkedin.com/in/ferranterico).

---

## License
This project is licensed under the MIT License. See the LICENSE file for details.
