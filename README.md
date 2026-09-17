# WelcomeMessage

A [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp) plugin for CS2 that greets players when they join the **Real Ones Combat Surf** server and points them to the community Discord.

## Features

- Broadcasts a welcome message to the whole server whenever a player fully connects, mentioning them by name.
- Follows up with an invite to the community Discord server.
- Skips the announcement for players with admin privileges, so admins can join quietly.

## Requirements

- A CS2 dedicated server running [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp) (Metamod:Source + CounterStrikeSharp installed).
- .NET 10 SDK, if building from source.

## Installation

1. Download `WelcomeMessage.dll` from the [latest build artifact](../../actions) or build it yourself (see below).
2. Copy `WelcomeMessage.dll` into your server's `game/csgo/addons/counterstrikesharp/plugins/WelcomeMessage/` directory.
3. Restart the server or reload plugins.

## Building from source

```bash
dotnet build WelcomeMessage.csproj --configuration Release
```

The compiled plugin will be at `bin/Release/net10.0/WelcomeMessage.dll`.

## Configuration

The Discord invite link is currently hardcoded in [`WelcomeMessage.cs`](WelcomeMessage.cs) as `DiscordInvite`. Update this constant and rebuild if the invite link changes.

## License

No license specified.
