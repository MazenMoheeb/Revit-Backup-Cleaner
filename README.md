# Revit Backup Cleaner

A lightweight Windows utility that automatically finds and removes Autodesk Revit backup files from a selected directory and reports the recovered disk space through a Windows notification.

---

## Features

- Removes Revit backup files recursively.
- Supports:
  - .rvt
  - .rfa
  - .rte
- Calculates recovered storage space.
- Displays a Windows toast notification summary.
- Shows custom developer branding/logo.
- Fast and lightweight.

---

## Technologies Used

- C#
- .NET
- Microsoft.Toolkit.Uwp.Notifications

---

## Requirements

- Windows 10 or newer
- .NET Runtime
- Visual Studio 2022 or newer

---

## Installation

### Clone Repository

```bash
git clone https://github.com/MazenMoheeb/Revit-Backup-Cleaner.git
```

### Open Project

Open:

```text
RevitBackupCleaner.sln
```

using Visual Studio.

### Restore Packages

```bash
dotnet restore
```

### Build

```bash
dotnet build
```

---

## Usage

Run the application:

```bash
dotnet run
```

Enter the directory path when prompted:

```text
Enter a path:
D:\Projects
```

The application will:

1. Scan all subfolders.
2. Find Revit backup files.
3. Delete them.
4. Calculate recovered space.
5. Display a Windows notification.

---

## Example Output

```text
Please, Enter A Path

D:\Projects
```

Notification:

```text
Revit Backup Cleaner

Total Revit Backup Files Number Deleted: (124)
With Size = 2.613 GB
```

---

## Project Structure

```text
src/
docs/
tests/
README.md
LICENSE
```

---

## Screenshots

### Console

<img width="1471" height="703" alt="image" src="https://github.com/user-attachments/assets/c48b6b68-9dad-47d4-a336-404bdb024a0b" />

### Notification

<img width="452" height="236" alt="image" src="https://github.com/user-attachments/assets/e10700ba-6d87-495e-9840-cde16a134ce0" />


---

## Contributing

Contributions are welcome.

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes.
4. Open a Pull Request.

---

## License

This project is licensed under the MIT License.
