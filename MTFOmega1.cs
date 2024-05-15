using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;

using MapEvent = Exiled.Events.Handlers.Map;
using ServerEvent = Exiled.Events.Handlers.Server;

namespace MTFOmega1
{
    public class MTFOmega1 : Plugin<Configs.Config>
    {

        public override string Name { get; } = "MTF Omega 1";
        public override string Author { get; } = "JesusQC, Michal78900, maintained by Marco15453, Modified By Lanonymous";
        public override string Prefix { get; } = "MTF Omega 1";
        public override Version Version { get; } = new Version(5, 3, 0);
        public override Version RequiredExiledVersion => new Version(7, 1, 0);

        public bool IsSpawnable = false;

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Config.MTFOmega1Soldat.Register();
            Config.MTFOmega1Lieutenant.Register();
            Config.MTFOmega1Colonel.Register();

            eventHandlers = new EventHandlers(this);

            ServerEvent.RoundStarted += eventHandlers.OnRoundStarted;
            ServerEvent.RespawningTeam += eventHandlers.OnRespawningTeam;
            MapEvent.AnnouncingNtfEntrance += eventHandlers.OnAnnouncingNtfEntrance;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            CustomRole.UnregisterRoles();

            ServerEvent.RoundStarted -= eventHandlers.OnRoundStarted;
            ServerEvent.RespawningTeam -= eventHandlers.OnRespawningTeam;
            MapEvent.AnnouncingNtfEntrance -= eventHandlers.OnAnnouncingNtfEntrance;

            eventHandlers = null;
            base.OnDisabled();
        }
    }
}
