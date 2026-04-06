# Sprint - Social Media App

A modern social media application built with .NET MAUI, featuring real-time messaging, feed browsing, and user profiles.

## Features

- **Feed**: Browse posts from users you follow
- **Messages**: Real-time messaging with friends
- **Profile**: View and edit your profile information
- **Cross-platform**: Runs on Android, iOS, Windows, and macOS

## Architecture

This app follows the MVVM (Model-View-ViewModel) pattern with:

- **Models**: Data structures (Post, User, Message, etc.)
- **Views**: XAML UI pages
- **ViewModels**: Business logic and data binding
- **Services**: API communication and business services

## Getting Started

### Prerequisites

- .NET 9 SDK
- Visual Studio 2022 (with MAUI workload)
- Android SDK (for Android development)
- Xcode (for iOS development on Mac)

### Installation

1. Clone the repository
2. Open `Sprint.Maui.csproj` in Visual Studio
3. Restore NuGet packages
4. Run the app on your target platform

### Building

```bash
# Restore packages
dotnet restore

# Build for Android
dotnet build -f net9.0-android

# Build for iOS (Mac only)
dotnet build -f net9.0-ios

# Build for Windows
dotnet build -f net9.0-windows
```

### Running

```bash
# Run on Android emulator
dotnet run -f net9.0-android

# Run on Windows
dotnet run -f net9.0-windows
```

## Project Structure

```
Sprint.Maui/
├── Models/           # Data models
├── Views/            # XAML UI pages
├── ViewModels/       # MVVM view models
├── Services/         # Business services
├── Resources/
│   ├── Styles/       # XAML styles and colors
│   └── Converters/   # Value converters
├── Platforms/        # Platform-specific code
├── MauiProgram.cs    # App configuration
├── App.xaml          # App resources
└── AppShell.xaml     # Navigation shell
```

## Technologies Used

- .NET MAUI
- CommunityToolkit.Mvvm
- XAML
- C# 12

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

This project is licensed under the MIT License.