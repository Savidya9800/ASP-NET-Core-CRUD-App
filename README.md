# 🚀 ASP.NET Core CRUD App

Welcome to the **ASP.NET Core CRUD App**! This project is a simple yet powerful web application built with ASP.NET Core and Entity Framework Core, demonstrating full Create, Read, Update, and Delete (CRUD) operations using a SQLite database.

---

## 🌟 Features

- Modern ASP.NET Core MVC architecture
- Entity Framework Core with SQLite integration
- Responsive UI with Bootstrap
- Full CRUD operations for Products
- Error handling and validation
- Easy to set up and extend

---

## 📸 Screenshots

<p align="center">
  <img src="https://user-images.githubusercontent.com/0000000/your-screenshot1.png" width="600" alt="Home Page" />
  <br>
  <em>Home Page</em>
</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/0000000/your-screenshot2.png" width="600" alt="Product List" />
  <br>
  <em>Product List</em>
</p>

---

## 🚀 Getting Started

### Prerequisites

- [.NET 6.0 SDK or later](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Setup Instructions

1. **Clone the repository:**
	```bash
	git clone https://github.com/Savidya9800/ASP-NET-Core-CRUD-App.git
	cd ASP-NET-Core-CRUD-App
	```
2. **Restore dependencies:**
	```bash
	dotnet restore
	```
3. **Apply migrations & create the database:**
	```bash
	dotnet ef database update
	```
4. **Run the application:**
	```bash
	dotnet run
	```
5. **Open in browser:**
	Navigate to `https://localhost:5001` or the URL shown in the terminal.

---

## 🗂️ Project Structure

```
├── Controllers/         # MVC Controllers
├── Models/              # Data Models
├── Views/               # Razor Views
├── Migrations/          # EF Core Migrations
├── wwwroot/             # Static files (CSS, JS, etc.)
├── appsettings.json     # Configuration
└── Program.cs           # App entry point
```

---

## 🤝 Contributing

Contributions are welcome! Please open issues or submit pull requests for improvements.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

<p align="center">
  <b>⭐️ Star this repo to support the project!</b>
</p>