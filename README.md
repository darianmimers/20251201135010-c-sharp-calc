# Calculator - Vue.js + .NET Core

A modern two-layer calculator application with a **Vue.js frontend** and **.NET Core backend**, communicating via HTTP REST API.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Table of Contents

* [Features](#features)
* [Architecture](#architecture)
* [Prerequisites](#prerequisites)
* [Installation and Setup](#installation-and-setup)
* [Usage](#usage)
* [Project Structure](#project-structure)
* [License](#license)

---

## Features

* **Two-Layer Architecture**: Clean separation between frontend and backend
* **Vue.js Frontend**: Modern reactive UI with Vue 3 and Vite
* **REST API**: HTTP communication with JSON payloads
* **.NET Core Backend**: Robust calculation engine with error handling
* **CORS Enabled**: Secure cross-origin resource sharing
* **Responsive UI**: Adapts to different screen sizes
* **Dark Mode Compatible**: Visible in both light and dark browser themes

---

## Architecture

```
┌─────────────────┐         HTTP POST          ┌─────────────────┐
│   Vue.js        │ ────────────────────────▶  │  .NET Core      │
│   Frontend      │                             │  Web API        │
│   Port 5173     │ ◀────────────────────────  │  Port 5238      │
└─────────────────┘      JSON Response         └─────────────────┘
```

---

## Prerequisites

1. **Node.js** (v16 or higher) and npm
2. **.NET SDK** (v8.0 or higher)
3. Modern web browser (Chrome, Firefox, Edge, Safari)

---

## Installation and Setup

### Step 1: Clone the Repository

```bash
git clone https://github.com/darianmimers/20251201135010-c-sharp-calc.git
cd 20251201135010-c-sharp-calc
```

### Step 2: Start the Backend

```bash
cd backend
dotnet run
```

The backend will start on `http://localhost:5238`

### Step 3: Start the Frontend

Open a new terminal window:

```bash
cd frontend
npm install
npm run dev
```

The frontend will start on `http://localhost:5173`

### Step 4: Open the Application

Navigate to `http://localhost:5173` in your browser.

---

## Usage

| Action | Method | Description |
| :--- | :--- | :--- |
| **Enter Numbers** | Click buttons | Click number buttons or operators |
| **Operations** | Click (+, -, *, /) | Select arithmetic operation |
| **Parentheses** | Click (, ) | Group expressions |
| **Calculate** | Click `=` | Send to backend and display result |
| **Clear** | Click `C` | Reset the calculator |

**Example Workflow:**
1. Click `(`, `3`, `*`, `4`, `)`, `+`, `5`
2. Click `=`
3. Result `17` is displayed

---

## Project Structure

```
20251201135010-c-sharp-calc/
├── backend/                      # .NET Core Web API
│   ├── Controllers/
│   │   └── CalculatorController.cs
│   ├── Program.cs
│   ├── CalculatorBackend.csproj
│   └── Properties/
│       └── launchSettings.json
├── frontend/                     # Vue.js Application
│   ├── src/
│   │   ├── components/
│   │   │   └── Calculator.vue
│   │   ├── App.vue
│   │   └── main.js
│   ├── package.json
│   └── vite.config.js
└── README.md
```

---

## API Endpoint

### POST /api/calculator/calculate

**Request:**
```json
{
  "expression": "2 + 2"
}
```

**Response:**
```json
{
  "result": 4
}
```

**Error Response:**
```
400 Bad Request
"Error calculating expression: ..."
```

---

## License

[MIT](https://opensource.org/licenses/MIT)