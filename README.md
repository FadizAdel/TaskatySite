# Taskaty - Task Management Application

A modern, beautiful task management web application built with ASP.NET Core MVC.

## Features

- ✨ **Modern UI/UX** - Beautiful gradient design with smooth animations
- 📝 **Task Management** - Create, edit, delete, and complete tasks
- 🔍 **Search & Filter** - Find tasks quickly with search and filter options
- 📊 **Statistics Dashboard** - View real-time task statistics on home page
- 📅 **Due Date Tracking** - Set deadlines and get overdue alerts
- 🎨 **Responsive Design** - Works seamlessly on desktop, tablet, and mobile

## Technologies Used

- **ASP.NET Core 9.0** - MVC Framework
- **Entity Framework Core** - ORM for database operations
- **SQL Server LocalDB** - Database
- **Bootstrap 5** - UI Framework
- **Bootstrap Icons** - Icon library
- **Custom CSS** - Modern gradient styling

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- SQL Server LocalDB (included with Visual Studio)

### Installation

1. Clone the repository
```bash
git clone https://github.com/FadizAdel/TaskatySite.git
cd TaskatySite
```

2. Restore dependencies
```bash
dotnet restore
```

3. Update database
```bash
dotnet ef database update
```

4. Run the application
```bash
dotnet run
```

5. Open your browser and navigate to `http://localhost:5250`

## Project Structure

```
MyMvcApp/
├── Controllers/        # MVC Controllers
├── Models/            # Data models
├── Views/             # Razor views
├── Data/              # Database context
├── wwwroot/           # Static files (CSS, JS, images)
├── Migrations/        # EF Core migrations
└── Program.cs         # Application entry point
```

## Features in Detail

### Task Management
- Create tasks with title, description, and due date
- Mark tasks as complete/incomplete
- Edit existing tasks
- Delete tasks with confirmation

### Search & Filter
- Search tasks by title or description
- Filter by status: All, Pending, Completed, Overdue
- Clear filters easily

### Statistics
- Total tasks count
- Pending tasks count
- Completed tasks count
- Overdue tasks count

## Screenshots

### Home Page
Beautiful landing page with statistics dashboard

### Task List
Modern card-based task list with status indicators

### Create/Edit Task
Clean, intuitive forms for task management

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is open source and available under the MIT License.

## Author

Created with ❤️ by FadizAdel
