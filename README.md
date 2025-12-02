# JS Calculator Utility

A lightweight, web-based JavaScript calculator designed to perform basic arithmetic operations directly in your browser.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This utility provides a simple, clean interface for calculations and can be used as a standalone tool or embedded into other web projects. All logic is contained within standard HTML/JS files for easy deployment and customization.

## Table of Contents

* [JS Calculator Utility](#js-calculator-utility)
    * [Table of Contents](#table-of-contents)
    * [Features](#features)
    * [Prerequisites](#prerequisites)
    * [Installation and Setup](#installation-and-setup)
    * [Configuration](#configuration)
    * [Usage](#usage)
    * [Integrations](#integrations)
        * [Embedding in Websites](#embedding-in-websites)
    * [License](#license)

---

## Features

*   **Zero Dependencies**: Runs entirely in the browser using standard HTML, CSS, and JavaScript.
*   **Portable**: No build steps or server requirements; just open the file and run.
*   **Lightweight**: Minimal file size ensures instant loading times.
*   **Standard Operations**: Supports addition, subtraction, multiplication, and division.
*   **Responsive UI**: Adapts to different screen sizes (desktop and mobile).
*   **Keyboard Support**: Enter numbers and operations using your physical keyboard.

[Back to Top](#table-of-contents)

## Prerequisites

1.  **Web Browser**: Any modern web browser (Chrome, Firefox, Edge, Safari).
2.  **Git (Optional)**: To clone the repository locally.

## Installation and Setup

**Step 1: Clone this Repository**

```bash
git clone https://github.com/darianmimers/20251201135010-js-calc.git
cd 20251201135010-js-calc
```

**Step 2: Launch the Calculator**

Since this is a client-side web application, no installation of libraries is required.

1.  Navigate to the project folder.
2.  Double-click `index.html` to open it in your default web browser.

**Step 3: Organize Files (Optional)**

If you are integrating this into a larger project, you can move the files to your assets directory. Ensure `index.html` maintains the correct relative path to any linked `.js` or `.css` files.

```text
project-root/
├── assets/
│   ├── js-calc/
│   │   ├── index.html
│   │   └── ... (other assets)
└── ...
```

[Back to Top](#table-of-contents)

## Configuration

This project is designed to be "plug and play," but it is easily customizable by editing the source code directly.

*   **UI Styling**: Modify the `<style>` section in `index.html` (or separate `.css` file if applicable) to change colors, fonts, and button sizes.
*   **Logic**: Edit the `<script>` section or `.js` file to add advanced mathematical functions (e.g., square root, percentage).

**Example: Changing Button Colors**
Find the CSS class related to buttons (e.g., `.btn`) and change the `background-color` property:
```css
.btn {
    background-color: #007bff; /* Change to your preferred color */
    color: white;
}
```

[Back to Top](#table-of-contents)

## Usage

Once `index.html` is open in your browser:

| Action | Method | Description |
| :--- | :--- | :--- |
| **Enter Numbers** | Mouse Click / Keyboard | Click the number buttons or type 0-9. |
| **Operations** | Click / Keys (+, -, *, /) | Select the desired arithmetic operation. |
| **Calculate** | Click `=` / Key `Enter` | Computes and displays the result. |
| **Clear** | Click `C` / Key `Esc` | Resets the calculator to zero. |

**Example Workflow:**
1.  Open `index.html`.
2.  Click `1`, `0`, `+`, `5`.
3.  Click `=`.
4.  Result `15` is displayed on the screen.

[Back to Top](#table-of-contents)

## Integrations

### Embedding in Websites

You can easily integrate this calculator into an existing website using an `<iframe>`.

```html
<iframe src="path/to/20251201135010-js-calc/index.html" width="300" height="400" style="border:none;"></iframe>
```

This allows the calculator to function as a widget within your dashboard, educational tool, or utility page without conflicting with your site's existing styles or scripts.

[Back to Top](#table-of-contents)

## License

[MIT](https://opensource.org/licenses/MIT)

[Back to Top](#table-of-contents)