🛡️ ShieldBot: Cybersecurity Awareness Assistant
ShieldBot is a professional C# console-based educational tool designed to combat the rise of digital threats in South Africa. It provides an interactive, conversational experience to teach citizens about essential online safety topics like Phishing, Password Security, and Multi-Factor Authentication (MFA).

🚀 Key Features
Multimedia Integration: A synchronized voice greeting plays upon launch using the System.Media library.

Intelligent Logic: Uses parallel arrays to store and retrieve cybersecurity tips based on user keywords.

Conversational UI: Features a custom typewriter-style animation and a staged "Help" system to guide users.

Robust Validation: Implements strict input validation using string.IsNullOrWhiteSpace to handle unexpected behavior.

CI/CD Pipeline: Integrated with GitHub Actions for automated build verification on every commit.

🛠️ Technical Implementation
Architecture (Separation of Concerns)
The project follows a modular structure to ensure maintainability:

Program.cs: The entry point that initializes the application environment.

Chatbot.cs: The "Brain" containing the logic, keyword arrays, and response system.

Utils.cs: The "Visual Engine" handling colors, borders, and animations.

Techniques Used
Relative Pathing: Uses AppDomain.CurrentDomain.BaseDirectory to ensure assets load correctly on any device.

Synchronous Audio: Implements player.PlaySync() to maintain a professional flow.

Defensive Programming: Wrapped file-handling logic in try-catch blocks to prevent runtime crashes.

📂 Folder Structure
Plaintext
CyberSecurityChatbot/
├── .github/workflows/    # CI/CD Configuration (GitHub Actions)
├── Assets/               # Project Assets (greeting.wav, logo.txt)
├── src/                  # Source Code (.cs files and .csproj)
└── README.md             # Project Documentation
⚙️ Prerequisites & Installation
Prerequisites
.NET 9.0 SDK or later.

Windows OS (required for System.Media.SoundPlayer compatibility).

Installation & Setup
Clone the repository:

Bash
git clone https://github.com/Yasheel-Naidoo/CyberSecurityChatbot.git
cd CyberSecurityChatbot
Open the project in Visual Studio.

Asset Configuration: In the Solution Explorer, select the files in the Assets folder and set Copy to Output Directory to "Copy if newer".

Build the project:

Bash
dotnet build
🎮 Usage
Run the application via Visual Studio or the terminal:

Bash
dotnet run --project src/Chatbot.csproj
Interact with ShieldBot:

The app starts with a Voice Greeting and ASCII Logo.

Enter your name when prompted to personalize the session.

Ask specific questions: * "Tell me about password safety"

"How do I detect phishing?"

"What is MFA?"

Type "Help" at any time to see the full list of available prompts.

Type "Exit" or "Bye" to close the program.

📖 References
Academic Journals
Pieterse, H., 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. The African Journal of Information and Communication, 28, pp. 1-21. doi:10.23962/10539/32213.

Technical Documentation
Microsoft, 2024. SoundPlayer Class (System.Media). [online] Available at: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer [Accessed 12 April 2026].

Microsoft, 2024. File Class (System.IO). [online] Available at: https://learn.microsoft.com/en-us/dotnet/api/system.io.file [Accessed 12 April 2026].

Books
Troelsen, A. and Japikse, P., 2022. Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming. 11th ed. New York: Apress.
