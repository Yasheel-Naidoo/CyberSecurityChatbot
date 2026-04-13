🛡️ ShieldBot: Cybersecurity Awareness Assistant
ShieldBot is a professional C# console-based educational tool designed to combat the rise of digital threats in South Africa. It provides an interactive, conversational experience to teach citizens about essential online safety topics like Phishing, Password Security, and Multi-Factor Authentication (MFA).

🚀 Key Features
Multimedia Integration: A synchronized voice greeting plays upon launch using the System.Media library.

Intelligent Logic: Uses parallel arrays to store and retrieve cybersecurity tips based on user keywords.

Conversational UI: Features a custom typewriter-style animation and a staged "Help" system to guide users through learning.

Robust Validation: Implements strict input validation to handle empty queries and unexpected user behavior gracefully.

CI/CD Pipeline: Integrated with GitHub Actions to ensure automated build verification on every commit.

🛠️ Technical Implementation
Architecture (Separation of Concerns)
The project follows a modular structure to ensure maintainability:

Program.cs: The entry point that initializes the application environment.

Chatbot.cs: The "Brain" containing the logic, keyword arrays, and response system.

Utils.cs: The "Visual Engine" handling colors, borders, and animations.

Techniques Used
Relative Pathing: Uses AppDomain.CurrentDomain.BaseDirectory to ensure assets (Audio/ASCII) load correctly on any device.

Synchronous Audio: Implements player.PlaySync() to maintain a professional flow between audio and visual elements.

Defensive Programming: Wrapped multimedia and file-handling logic in try-catch blocks to prevent runtime crashes.

📂 Folder Structure
Plaintext
CyberSecurityChatbot/
├── .github/workflows/    # CI/CD Configuration (GitHub Actions)
├── Assets/               # Project Assets (greeting.wav, logo.txt)
├── src/                  # Source Code (.cs files and .csproj)
└── README.md             # Project Documentation
📖 References
Academic Journals
Pieterse, H., 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. The African Journal of Information and Communication, 28, pp. 1-21. doi:10.23962/10539/32213.

Technical Documentation
Microsoft, 2024. SoundPlayer Class (System.Media). [online] Available at: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer [Accessed 12 April 2026].

Microsoft, 2024. File Class (System.IO). [online] Available at: https://learn.microsoft.com/en-us/dotnet/api/system.io.file [Accessed 12 April 2026].

GitHub, 2026. GitHub Actions Documentation. [online] Available at: https://docs.github.com/en/actions [Accessed 12 April 2026].

Books
Troelsen, A. and Japikse, P., 2022. Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming. 11th ed. New York: Apress.

How to Run
Clone the repository.

Open the solution in Visual Studio.

Ensure the files in the Assets folder are set to "Copy to Output Directory: Copy if newer".

Build and Run.