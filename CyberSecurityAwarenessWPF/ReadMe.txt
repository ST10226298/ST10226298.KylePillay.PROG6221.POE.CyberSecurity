# CyberSecurity Awareness Assistant (WPF Application)

## Overview

The **CyberSecurity Awareness Assistant** is a Windows Presentation Foundation (WPF) desktop application developed in C#. Its goal is to educate users about cybersecurity through an interactive chatbot, a quiz system, a task tracker, and an activity logger. It includes user-friendly features like collapsible chat sections and dark mode.

---

## Features

- **Task Manager**: Users can create and manage daily tasks/reminders.
- **Cybersecurity Quiz**: 10-question quiz to test cybersecurity awareness.
- **NLP Chatbot**: Responds to simple cybersecurity queries.
- **Activity Logger**: Logs all major actions like chat messages and quiz interactions.
- **Collapsible Chat Section**: Chat history is collapsible to maintain a clean UI.
- **Dark Mode Toggle**: Seamlessly switch between light and dark themes.

---

## File Structure

- `/Models/` - Data classes like `Task.cs`
- `/Features/` - Core logic for logging, NLP, and quiz management
- `/Views/` - WPF UI files (`MainWindow.xaml`, `QuizWindow.xaml`)
- `/Themes/` - Contains `DarkMode.xaml` for dark theme styling

---

## Technologies Used

- WPF (Windows Presentation Foundation)
- C# (.NET 6.0)
- MVVM structure (lightweight)
- XAML for UI
- Resource Dictionaries for styling

---

## Instructions

### 1. Build & Run
- Open the `.sln` file in Visual Studio 2022 or newer.
- Build solution: `Ctrl + Shift + B`
- Run: `F5`

### 2. Theme Toggle
- Use the **Dark Mode** button to switch the theme dynamically.

---



## References

1. Microsoft Documentation - https://learn.microsoft.com/en-us/dotnet/desktop/wpf/
2. OWASP Foundation - https://owasp.org/
3. Microsoft Learn - https://learn.microsoft.com/en-us/windows/apps/design/controls/
4. Smashing Magazine - https://www.smashingmagazine.com/2020/01/chatbot-user-experience-design/
5. NIST Cybersecurity Tips - https://www.nist.gov/topics/cybersecurity

---

## Author

ST10226298
Kyle Pillay
