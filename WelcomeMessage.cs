using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Utils;

namespace WelcomeMessage;

public class WelcomeMessage : BasePlugin
{
    public override string ModuleName => "WelcomeMessage";
    public override string ModuleVersion => "1.0.0";
    public override string ModuleAuthor => "Weezer";
    public override string ModuleDescription =>
        "Welcome messages for Real Ones Combat Surf.";

    private const string DiscordInvite = "discord.gg/RqgE5sPWpD";

    public override void Load(bool hotReload)
    {
        RegisterEventHandler<EventPlayerConnectFull>(OnPlayerConnectFull);
    }

    private HookResult OnPlayerConnectFull(
        EventPlayerConnectFull @event,
        GameEventInfo info)
    {
        var player = @event.Userid;

        if (player == null || !player.IsValid)
            return HookResult.Continue;

        // Don't announce admins joining the server.
        if (AdminManager.GetPlayerAdminData(player) != null)
            return HookResult.Continue;

        // Send the welcome message to every player currently in the server.
        foreach (var target in Utilities.GetPlayers())
        {
            if (!target.IsValid)
                continue;

            target.PrintToChat(
                $" {ChatColors.Green}[Real Ones]{ChatColors.Default} " +
                $"Welcome {ChatColors.Gold}{player.PlayerName}{ChatColors.Default} " +
                $"to the Combat Surf server!"
            );

            target.PrintToChat(
                $" {ChatColors.Green}[Real Ones]{ChatColors.Default} " +
                $"Join our Discord: {ChatColors.Gold}{DiscordInvite}{ChatColors.Default}"
            );
        }

        return HookResult.Continue;
    }
}