# Remind-Me-To-Stand-Up

## Why this project exists

Sitting for long periods without movement can negatively affect health, energy, and focus.  
Many people start work with good intentions, then lose track of time while studying, coding, gaming, or working at a desk.

**Remind-Me-To-Stand-Up** is a simple desktop reminder app built to solve that exact problem: it helps users break long sitting periods by sending clear stand-up reminders at a chosen interval.

---
## Project screenshots 

<img width="629" height="386" alt="Screenshot 2026-06-22 233125" src="https://github.com/user-attachments/assets/61b16969-0046-4f94-b0de-0fd42f6e1667" />
<img width="504" height="199" alt="image" src="https://github.com/user-attachments/assets/3019dd13-2e92-4e2b-8a97-53fdcce4d677" />
<img width="489" height="188" alt="image" src="https://github.com/user-attachments/assets/157485eb-9ff7-4136-b204-db8db7dd8059" />
<img width="516" height="203" alt="image" src="https://github.com/user-attachments/assets/b0fb9c35-78e7-4cda-b509-13723f818d60" />


---

## Project overview

This is a **Windows Forms (.NET Framework 4.8.1)** desktop application.  
The app displays a running `MM:SS` timer, lets the user choose a reminder interval (1–90 minutes), and sends a notification when it is time to stand.

Core user flow:
1. User selects reminder interval in minutes.
2. User presses **Start**.
3. Timer counts up in the UI.
4. When interval is reached, the app shows a stand-up notification.
5. Timer resets and continues for the next cycle.

---

## Features

- **Custom reminder interval** from **1 to 90 minutes** using `NumericUpDown`.
- **Live timer display** with minute and second labels.
- **Start / Reset controls** for session management.
- **Stand-up desktop notification** with reminder text.
- **Minimize-to-tray style behavior**:
  - When minimized, the main form is hidden.
  - A second notification tells the user how to return.
  - Clicking the balloon tip or tray icon restores the app.
- **Info panel** explaining the health motivation behind the app.

---

## Notification-focused explanation

Notifications are the main value of this app.

### 1) Stand-up reminder notification
- Implemented using `notifyIconStandUp`.
- Trigger point: inside `timerMin_Tick` when the selected interval ends.
- Behavior:
  - Shows warning-style balloon tip.
  - Title: **"Stand Up !"**
  - Text includes the selected duration (e.g., `You Have Sat For 30M`).
  - Display duration set to ~15 seconds.

**Benefit to the user:**  
This interrupts passive long sitting, creates a movement habit, and improves awareness of time spent seated.

### 2) Back-to-app notification after minimize
- Implemented using `notifyIconBackToApp`.
- Trigger point: `Form1_Minimized` when window state becomes minimized.
- Behavior:
  - Hides the form from screen clutter.
  - Shows a short balloon tip with guidance to reopen.
  - Supports restore via balloon click and tray icon double-click.

**Benefit to the user:**  
The reminder app can stay non-intrusive while still accessible. This supports continuous use during work without distracting UI presence.

---

## Project structure

### Root files

- **`Program.cs`**
  - Application entry point.
  - Enables WinForms visual styles.
  - Launches `Form1`.

- **`Core.cs`**
  - Contains timing logic abstraction:
    - `ICore` interface
    - `Core` class
  - Tracks `Min` and `Sec`.
  - Provides increment and reset methods (`UpdateMin`, `UpdateSec`, `RestMin`, `RestSec`).
  - Keeps state logic separated from UI event handlers.

- **`Form1.cs`**
  - Main UI behavior and event-driven orchestration.
  - Handles:
    - Timer ticks
    - Button clicks
    - Numeric interval updates
    - Notification creation/display
    - Minimize/restore behavior

- **`Form1.Designer.cs`**
  - Auto-generated WinForms UI layout and control wiring.
  - Defines controls such as labels, timers, buttons, notify icons, and numeric input.
  - Sets timer intervals:
    - `timerMin.Interval = 60000`
    - `timerSec.Interval = 1000`

- **`Form1.resx`**
  - Form resources used by designer-managed controls.

- **`Remind Me To Stand Up.csproj`**
  - Classic .NET Framework project configuration.
  - Targets **.NET Framework 4.8.1**.
  - Includes compile items, embedded resources, and WinForms references.

- **`App.config`**
  - Declares supported runtime for .NET Framework 4.8.1.

### `Properties/` folder

- **`AssemblyInfo.cs`**: assembly metadata (title, version, GUID, etc.).
- **`Resources.resx` + `Resources.Designer.cs`**: strongly typed access to assets (like info image).
- **`Settings.settings` + `Settings.Designer.cs`**: application settings scaffold (currently no custom settings).

### `Resources/` folder

- Includes static assets used by UI (for example information icon and app icon).

### Build output and IDE folders

- **`bin/`** and **`obj/`**: compiled artifacts.
- **`.vs/`**: local Visual Studio workspace/index files.

---

## How the code is designed

The design is intentionally simple and event-driven:

1. **State holder (`Core`)**
   - Minimal class responsible for minute/second counters.
   - No UI dependencies.

2. **Controller-like form logic (`Form1`)**
   - Receives user input and timer events.
   - Calls `Core` methods to update state.
   - Pushes state to labels via `UpdateTimeLabel()`.
   - Triggers notifications when interval completes.

3. **UI definition in designer partial class**
   - Keeps visual setup and component instantiation separate from behavior logic.

This split helps maintain readability: timer state operations live in one class while user interaction and notifications live in the form.

---

## Reminder cycle logic

Main variables:
- `TheEndTime`: remaining reminder minutes in current cycle.
- `UDMin.Value`: user-selected interval.

Cycle behavior:
1. User selects minutes -> `UDMin_ValueChanged` sets `TheEndTime`.
2. Start button enables both timers and locks interval input.
3. Every second:
   - `timerSec_Tick` updates seconds for visible progress.
4. Every minute:
   - `timerMin_Tick` updates minute count and decrements `TheEndTime`.
5. When cycle ends:
   - Stand-up notification is shown.
   - Internal timer is reset.
   - `TheEndTime` is reloaded from selected value for the next cycle.

---

## Why this is useful for users

- Prevents accidental long sitting sessions.
- Builds healthier movement habits with periodic prompts.
- Works passively while users focus on other tasks.
- Minimizes visual disturbance via tray/minimize behavior.
- Gives clear, actionable reminders exactly when needed.

---

## Notes

- The repository currently contains generated build/IDE folders (`bin`, `obj`, `.vs`) alongside source files.
- This project targets Windows desktop and requires a .NET Framework-capable environment to build/run.
