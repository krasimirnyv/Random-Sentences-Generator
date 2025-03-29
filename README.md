# 🗣️ Random Sentences Generator - Console App

## 💡 Project Title
A C# console application that dynamically generates random and often humorous English sentences by combining data from a structured JSON file. Built as a practical project to explore JSON parsing, randomization, loop logic, string formatting, and user interaction via the terminal.

<p align="center">
  <img src="images/RandomSentencesGenerator.jpg" width="400px" alt="Random Sentences Generator Illustration">
</p>

---

## 🧩 Project Summary

This is a simple sentence generation app written in **C#** that reads pre-defined words from a `data.json` file (names, verbs, nouns, places, etc.) and constructs randomly combined sentences every time the user presses `ENTER`.

Each sentence follows a logical grammatical pattern and is visually highlighted in green to emphasize dynamic output. The project serves as a beginner-friendly way to practice working with external data, file reading, serialization, random selection, and loops.

---

## 📌 Project Goals

The main goal of this project is to:

- Read structured external data (JSON)
- Parse that data into C# objects
- Randomly combine elements to form grammatically correct sentences
- Practice console interaction and feedback

Along the way, the project demonstrates the following core C# skills:

- JSON deserialization using `System.Text.Json`
- Use of `List<string>` and `string[]`
- Loops and input control
- Modular methods (`GetRandomWord`)
- Defensive programming (null checks, empty arrays)

---

## ✅ My Solution

The program loads all sentence components from `data.json` into memory and continuously prints randomly constructed sentences in the form:

```
{Name} from {Place} {Adverb} {Verb} {Noun} {Detail}.
```

### 🔧 Key Features

- JSON deserialization with `PropertyNameCaseInsensitive = true`
- Protected random selection (`GetRandomWord()` handles empty/null lists)
- Infinite generation loop until user stops it
- Highlighted output using `Console.ForegroundColor`
- All sentence parts are externalized for easy updates

---

## 📋 Input and Output

### 🖥️ User Input
- Press `ENTER` to generate a new sentence.
- The program continues endlessly until closed manually.

### 🧠 Internal Logic
- Loads word banks from `data.json`
- Selects one word from each category using `System.Random`
- Assembles a complete sentence and prints it in green

### 🧾 Sample Output

```
Welcome to Random sentences generator!

This is your first random generated sentence:
Emily from Sofia gently writes a book in the park.
Press ENTER/RETURN to generate a new random sentence.
```

---

## 📁 data.json Structure

```json
{
  "names": ["Peter", "Michell", "Jane", ...],
  "places": ["Sofia", "Plovdiv", "Varna", ...],
  "adverbs": ["slowly", "diligently", "warmly", ...],
  "verbs": ["eats", "writes", "reads", ...],
  "nouns": ["apple", "book", "laptop", ...],
  "details": ["near the river", "in the park", ...]
}
```

This file is copied automatically to the output directory using `CopyToOutputDirectory` in `.csproj`.

---

## 💻 Link to the Source Code
You can view the source code for this project here:

[Source Code](RandomSentencesGenerator/RandomSentencesGenerator.cs)

---

## 🚀 Try the Demo
You can test the generator directly in your browser here:

<a href="https://replit.com/@krasimirnyv/Random-Sentences-Generator?v=1" target="_blank">
  <img alt="Try Now Button" src="images/Try logo.png" width="150">
</a>

---

## 🧠 Technologies Used
- C#
- .NET 8 Console
- `System.Text.Json`
- JetBrains Rider
- Git & GitHub

---

## ✍ Author
Created by **Krasimir Naydenov** as part of a personal collection of beginner-friendly console apps.

---

## 📄 License
Licensed under the [MIT License](LICENSE).

