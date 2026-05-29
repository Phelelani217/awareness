@echo off
REM ============================================================
REM  CyberBot — Git Setup Script
REM  Run this inside your cloned "awareness" repo folder
REM  ST10472498 — Luthuli Phelelani
REM ============================================================

echo [1/9] Initialising / verifying git repo...
git init

echo [2/9] Commit 1 — README
git add README.md
git commit -m "docs: add README with project description, features, and usage instructions"

echo [3/9] Commit 2 — Project file
git add CybersecurityChatbot.csproj
git commit -m "build: add .csproj project configuration for .NET 6 Windows Forms"

echo [4/9] Commit 3 — Entry point
git add Program.cs
git commit -m "feat: add Program.cs entry point to launch Windows Forms application"

echo [5/9] Commit 4 — Memory class
git add UserMemory.cs
git commit -m "feat: add UserMemory class to store name, favourite topic, and topics discussed"

echo [6/9] Commit 5 — Chatbot engine
git add ChatbotEngine.cs
git commit -m "feat: add ChatbotEngine with keyword recognition, random responses, sentiment detection, memory recall, and error handling"

echo [7/9] Commit 6 — GUI form
git add MainForm.cs
git commit -m "feat: add MainForm GUI with dark cyber theme, chat display, input panel, and live memory side panel"

echo [8/9] Tagging v1.0 (Part 1 — console chatbot)...
git tag -a v1.0 HEAD~5 -m "v1.0 - Part 1: Console-based cybersecurity chatbot"

echo [9/9] Tagging v2.0 (Part 2 — GUI chatbot)...
git tag -a v2.0 HEAD -m "v2.0 - Part 2: Full GUI cybersecurity chatbot with keyword recognition, memory, sentiment detection, and OOP architecture"

echo.
echo Pushing to GitHub...
git push origin main --tags

echo.
echo ============================================================
echo  DONE! Check your GitHub repo for 6 commits and 2 releases.
echo ============================================================
pause
