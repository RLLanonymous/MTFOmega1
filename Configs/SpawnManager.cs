using System.ComponentModel;

namespace MTFOmega1.Configs
{ 
    public class SpawnManager
    {

        [Description("How many respawn waves must occur before considering MTFOmega1 to spawn.")]
        public int Respawns { get; private set; } = 1;

        [Description("The maximum number of times MTF Omega 1 can spawn per game.")]
        public int MaxSpawns { get; set; } = 3;

        [Description("Probability of a MTF Omega 1 replacing a MTF spawn")]
        public int Probability { get; private set; } = 50;

        [Description("The maximum size of a MTF Omega 1 Spawn")]
        public int MaxSquad { get; private set; } = 8;

        [Description("MTFOmega1 entrance Cassie Message")]
        public string MTFOmega1AnnouncementCassie { get; private set; } = "MTFUNIT Omega 1 designated {designation} HasEntered AllRemaining AwaitingRecontainment {scpnum}";
        public string MTFOmega1AnnouncmentCassieNoScp { get; private set; } = "MTFUNIT Omega 1 designated {designation} HasEntered AllRemaining NoSCPsLeft";

        [Description("NTF entrance Cassie Message (leave empty to use default NTF cassie entrance)")]
        public string NtfAnnouncementCassie { get; private set; } = "MTFUnit epsilon 11 designated {designation} hasentered AllRemaining AwaitingRecontainment {scpnum}";
        public string NtfAnnouncmentCassieNoScp { get; private set; } = "MTFUnit epsilon 11 designated {designation} hasentered AllRemaining NoSCPsLeft";

        [Description("Cassie Subtitles")]
        public bool Subtitles { get; private set; } = false;
    }
}
