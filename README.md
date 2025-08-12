# 🎮 Platformer Game (Minimalist Game Framework)

A C#-based minimalist game framework designed for building a simple 2D platformer. Features a player character, blocks, collision management, a map with a customizable background, and a start menu. Built to be easily extendable for additional entities, levels, and mechanics.

---

## 🚀 Features

- 🕹️ **Player movement and loop logic**
- 🧱 Block-based world elements with collision management
- 🌄 Customizable map background color
- 🖋️ Text rendering for player coordinates and UI
- 🏁 Start menu system
- 📦 Extendable architecture for more game objects and mechanics

---

## 🧱 Tech Stack

| Layer     | Technology         |
|-----------|--------------------|
| Language  | C#                 |
| Framework | Custom minimal engine (Engine, Vector2, Color, etc.) |
| Tools     | Visual Studio / .NET |

---

## 🛠️ Setup Instructions (Local Hosting)

### 📦 1. Clone the Repository

```bash
git clone https://github.com/4bh1gn4/PlatformerGame.git
cd PlatformerGame
```

---

### 🧪 2. Install Requirements

```text
- .NET SDK (latest stable version)
- Visual Studio or Visual Studio Code with C# extension
- Required game assets (fonts, textures, etc.) in the correct asset folder
```

---

### ▶️ 3. Run (Visual Studio)

1. Open the project in **Visual Studio**  
2. Ensure all asset files (e.g., `Retro Gaming.ttf`) are located in the correct paths  
3. Set the startup object to the main game entry point  
4. Press **F5** to build and run

---

### ▶️ 4. Run (Command Line)

```bash
dotnet build
dotnet run
```

---

## 📁 Repository Structure

```
PlatformerGame/
├── Game.cs              # Main game loop and initialization
├── Player.cs            # Player entity logic
├── Map.cs               # Map rendering and background color settings
├── Blocks.cs            # Block entity definition and loop updates
├── CollisionManager.cs  # Handles collision detection between player and blocks
├── StartMenu.cs         # Displays and updates start menu
├── TextRenderer.cs      # Displays on-screen text (e.g., coordinates)
├── Assets/
│   └── Retro Gaming.ttf # Font used for UI rendering
└── README.md
```

---

## 🧠 Key Files

| File              | Purpose                                               |
|-------------------|-------------------------------------------------------|
| `Game.cs`         | Main game loop; initializes player, map, blocks, menu |
| `Player.cs`       | Handles player state, movement, and rendering          |
| `Map.cs`          | Sets up map visuals and background color               |
| `Blocks.cs`       | Defines block properties and rendering loop            |
| `CollisionManager.cs` | Registers blocks and detects collisions           |
| `StartMenu.cs`    | Displays and updates the start menu                    |
| `TextRenderer.cs` | Renders text to the game screen                        |
| `Retro Gaming.ttf`| Font used for in-game text                             |

---

## 🔐 Configuration

- **Resolution**: Set in `Game.cs` via `Vector2 Resolution`
- **Font**: Load custom fonts with `Engine.LoadFont`
- **Blocks**: Add blocks via `CollisionManager.addBlock()`
- **Background Color**: Set via `map.setBackgroundColor()`

---

## 🌩️ Future Improvements

- 🚀 Add more levels and block types
- 🎯 Implement enemies and hazards
- 🎨 Add textures and animations
- 🎵 Integrate background music and sound effects

---

## 🙌 Credits

Created by [@4bh1gn4](https://github.com/4bh1gn4), Vaibhav Attre, Anusha Pandey, Tejas Paklapati

---

## 📜 License

MIT License
