To make your **README.md** look high-end for your submission, I've fixed the formatting of the folder structure and streamlined the installation steps. I also ensured the **Prerequisites** and **Usage** sections are included so the lecturer knows exactly how to interact with **ShieldBot**.

---

# 🛡️ ShieldBot: Cybersecurity Awareness Assistant

**ShieldBot** is a professional C# console-based educational tool designed to combat the rise of digital threats in South Africa. It provides an interactive, conversational experience to teach citizens about essential online safety topics like Phishing, Password Security, and Multi-Factor Authentication (MFA).

---

## 🚀 Key Features

* **Multimedia Integration:** A synchronized voice greeting plays upon launch using the `System.Media` library.
* **Intelligent Logic:** Uses **parallel arrays** to store and retrieve cybersecurity tips based on user keywords.
* **Conversational UI:** Features a custom typewriter-style animation and a staged "Help" system to guide users.
* **Robust Validation:** Implements strict input validation to handle empty queries and unexpected behavior gracefully.
* **CI/CD Pipeline:** Integrated with **GitHub Actions** to ensure automated build verification on every commit.

---

## 🛠️ Technical Implementation

### **Architecture (Separation of Concerns)**
The project follows a modular structure to ensure maintainability:
* **Program.cs:** The entry point that initializes the application environment.
* **Chatbot.cs:** The "Brain" containing the logic, keyword arrays, and response system.
* **Utils.cs:** The "Visual Engine" handling colors, borders, and animations.

### **Techniques Used**
* **Relative Pathing:** Uses `AppDomain.CurrentDomain.BaseDirectory` to ensure assets (Audio/ASCII) load correctly on any device.
* **Synchronous Audio:** Implements `player.PlaySync()` to maintain a professional flow between audio and visual elements.
* **Defensive Programming:** Wrapped multimedia and file-handling logic in `try-catch` blocks to prevent runtime crashes.

---

## 📂 Folder Structure

```text
CyberSecurityChatbot/
├── .github/
│   └── workflows/
│       └── dotnet-ci.yml    # CI/CD Configuration
├── Assets/
│   ├── greeting.wav         # Voice Greeting Asset
│   └── logo.txt             # ASCII Art Asset
├── src/
│   ├── Chatbot.cs           # Main Logic
│   ├── Utils.cs             # UI Utilities
│   ├── Program.cs           # Entry Point
│   └── Chatbot.csproj       # Project File
└── README.md                # Project Documentation
```

---

## ⚙️ Prerequisites & Installation

### **Prerequisites**
* **.NET 6.0 SDK** or later.
* **Windows OS** (Required for `System.Media.SoundPlayer` compatibility).

### **Installation**
1.  **Clone the repository:**
    ```bash
    git clone https://github.com/Yasheel-Naidoo/CyberSecurityChatbot.git
    ```
2.  **Open the solution** in Visual Studio.
3.  **Configure Assets:** In the Solution Explorer, select the files in the `Assets` folder and set **Copy to Output Directory** to **"Copy if newer"**.
4.  **Build and Run:** Press `F5` or use `dotnet run --project src/Chatbot.csproj`.

---

## 📖 References

### **Academic Journals**
* Pieterse, H., 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. *The African Journal of Information and Communication*, 28, pp. 1-21. doi:10.23962/10539/32213.

### **Technical Documentation**
* Microsoft, 2024. *SoundPlayer Class (System.Media)*. [online] Available at: [https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer](https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer) [Accessed 12 April 2026].
* Microsoft, 2024. *File Class (System.IO)*. [online] Available at: [https://learn.microsoft.com/en-us/dotnet/api/system.io.file](https://learn.microsoft.com/en-us/dotnet/api/system.io.file) [Accessed 12 April 2026].
* GitHub, 2026. *GitHub Actions Documentation*. [online] Available at: [https://docs.github.com/en/actions](https://docs.github.com/en/actions) [Accessed 12 April 2026].

### **Books**
* Troelsen, A. and Japikse, P., 2022. *Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming*. 11th ed. New York: Apress.

---
