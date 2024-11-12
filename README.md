# Student-Project-Management
This ASP.NET MVC web application entails of an institution that provides IT courses to students looking to enhance their skills in modern programming languages. The app enables teachers to manage student projects, including assignment, tracking, and CRUD operations on project data. This application follows the MVC architecture and utilizes the Entity Framework for data access.

## Features

**Student Project Assignment**: Allows teachers to assign projects to students, with each project able to include multiple students. A student can be assigned up to three projects.

**Project and Student Management**: Teachers can view all projects assigned to each student and see which students are involved in each project.

**CRUD Operations**: Teachers can perform Create, Read, Update, and Delete operations on project data.

**Data Validation**: Ensures data integrity by implementing validation rules for fields like FirstName and LastName (limited to 50 characters) to prevent database errors.

**Responsive Design**: Interface adapts to different screen resolutions and devices.

**Authentication and Authorization**: Provides secure access with proper user authentication mechanisms.

## Technologies Used

**ASP.NET MVC**: For creating structured, testable, and maintainable web applications.

**Entity Framework 6.2**: For interacting with the database using an object-oriented approach.

**SQL Server**: Database system for storing student, project, and assignment data.

**Azure**: Used for hosting the application and database.

## Installation

**Database Setup**:
- Create a new SQL Server Database or use Azure SQL Database.
- Execute the provided SQL scripts to create tables (Students, Projects, Assignments) and insert initial data.

**Configure Connection String**:
- Update the Web.config file with your SQL Server connection details.

**Run the Application**:
- Open the project in Visual Studio.
- Build the solution to restore packages and dependencies.
- Start the application (F5) to view in the browser.

## Usage
- **Teacher**: Teachers can assign projects and manage student-project assignments.
- **Project Management**: Access views for adding, editing, and deleting project records, as well as viewing project details and associated students.
- **Student Management**: Access views for listing students, viewing their assigned projects, and managing student information.


## Project Structure
- Models: Contains the data models generated from the database tables.
- Controllers: Handles the logic for students, projects, and assignments.
- Views: Contains Razor views for rendering HTML content and managing data forms.
- Scripts & Styles: Includes JavaScript and CSS for interactive and styled UI.

## Data Validation and Security
The application includes client-side and server-side validation to ensure data accuracy and integrity. Authentication and authorization mechanisms restrict access based on user roles, ensuring only authorized users can perform CRUD operations.
