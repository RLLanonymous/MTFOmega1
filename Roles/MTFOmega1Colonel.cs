using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System.Collections.Generic;

namespace MTFOmega1.Roles
{
    [CustomRole(RoleTypeId.NtfCaptain)]
    public class MTFOmega1Colonel : CustomRole
    {
        public override uint Id { get; set; } = 21;
        public override RoleTypeId Role { get; set; } = RoleTypeId.NtfCaptain;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "Colonel F.I.M Omega-1 'La Main Gauche De La Loi'";
        public override string Description { get; set; } = "Unité special autre que NTF";
        public override string CustomInfo { get; set; } = "Colonel F.I.M Omega-1 'La Main Gauche De La Loi'";

        public override List<string> Inventory { get; set; } = new()
        {
            $"{ItemType.KeycardMTFCaptain}",
            $"{ItemType.GunFRMG0}",
            $"{ItemType.GunCOM18}",
            $"{ItemType.Medkit}",
            $"{ItemType.Adrenaline}",
            $"{ItemType.Radio}",
            $"{ItemType.GrenadeHE}",
            $"{ItemType.ArmorHeavy}"
        };

        public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
        {
            { AmmoType.Nato556, 200 },
            { AmmoType.Nato9, 100 },
        };

        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            RoleSpawnPoints = new List<RoleSpawnPoint>
            {
                new()
                {
                    Role = RoleTypeId.NtfCaptain,
                    Chance = 100
                }
            }
        };
    }
}
