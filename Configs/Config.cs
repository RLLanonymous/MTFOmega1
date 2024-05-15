using System.ComponentModel;
using Exiled.API.Interfaces;
using MTFOmega1.Roles;

namespace MTFOmega1.Configs
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug messages be shown in a server console.")]
        public bool Debug { get; set; } = false;

        [Description("How many seconds before a spawnwave occurs should it calculate the spawn chance")]
        public int SpawnWaveCalculation { get; set; } = 10;

        [Description("Options for Omega 1 To spawn:")]
        public SpawnManager SpawnManager { get; private set; } = new SpawnManager();

        [Description("Options for MTF Omega 1 Colonel :")]
        public MTFOmega1Colonel MTFOmega1Colonel { get; private set; } = new MTFOmega1Colonel();

        [Description("Options for MTF Omega 1 Lieutenant :")]
        public MTFOmega1Lieutenant MTFOmega1Lieutenant { get; private set; } = new MTFOmega1Lieutenant();

        [Description("Options for MTF Omega 1 Soldier :")]
        public MTFOmega1Soldat MTFOmega1Soldat { get; private set; } = new MTFOmega1Soldat();

    }
}