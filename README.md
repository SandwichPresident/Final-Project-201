# Final-Project-201

RIT – Ritchie’s Fast Food Ordering App
Project Overview

Ritchie’s Fast Food is a .NET MAUI tablet-style ordering application inspired by self-service kiosks commonly found in fast-food restaurants. The app allows users to log in or create an account, browse menu items by category, select quantities, review their order, and complete checkout through a simple, event-driven interface.

The goal of this project was to practice object-oriented programming, event-driven UI design, file input/output, error handling, and collaborative development using GitHub.

Core Features
- User login and account creation
- Menu browsing by category (Mains, Drinks, Desserts)
- Quantity selection using steppers
- Checkout page with order confirmation
- Navigation between pages using MAUI Shell

Technologies Used
C#
.NET MAUI
XAML
Visual Studio
Git & GitHub

Object-Oriented Programming
- Custom Item class used to represent menu items
- List<Item> used for menu and checkout data
- Encapsulation of item properties such as name and quantity
- Event-driven methods handle user interactions

Data Structures
- Dictionary<string, string> used for storing user login credentials
- List<Item> used to represent ordered items during checkout

File Input / Output
- Login credentials are read from and written to a text file
- File I/O is used to persist user data between sessions
- File operations are documented and clearly commented in code

Error Handling & Validation
- Input validation for empty username and password fields
- User feedback via alerts for incorrect login attempts
- Defensive coding practices demonstrated with conditional checks
- File I/O usage documented and structured clearly for stability

User Testing
- The application was tested by three users outside the development team.

Summary of Feedback
-Login error messages needed to be clearer
-Checkout flow should be straightforward and easy to understand
-Visual feedback for quantity selection was helpful

Outcome
User feedback was reviewed and used to guide improvements in clarity, validation, and user messaging. Testing documentation can be found in TESTING.md.

Team Roles & Contributions
Work was distributed evenly across the team, with clear leadership in specific areas.
Main Class & GitHub Lead: Sam
Menu Page: Max
Checkout Page: Meghan
Login Page & OOP Practices: Vicky
UI Design & Aesthetics: Kaylah
User Testing, Error Handling, Code Comments: Sadia

Each team member contributed code, testing, and documentation relevant to their assigned role.

Git & Version Control
GitHub used for collaboration and version control
Meaningful commits made throughout development
