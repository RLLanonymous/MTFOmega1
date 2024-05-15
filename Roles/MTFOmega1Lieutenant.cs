using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System.Collections.Generic;

namespace MTFOmega1.Roles
{
    [CustomRole(RoleTypeId.NtfSergeant)]
    public class MTFOmega1Lieutenant : CustomRole
    {
        public override uint Id { get; set; } = 3;
        public override RoleTypeId Role { get; set; } = RoleTypeId.NtfSergeant;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "Lieutenant F.I.M Omega-1";
        public override string Description { get; set; } = "Help Ethics To Be Respected";
        public override string CustomInfo { get; set; } = "Lieutenant F.I.M Omega-1";

        public override List<string> Inventory { get; set; } = new()
        {
            $"{ItemType.KeycardMTFOperative}",
            $"{ItemType.GunCrossvec}",
            $"{ItemType.Medkit}",
            $"{ItemType.Radio}",
            $"{ItemType.GrenadeHE}",
            $"{ItemType.ArmorCombat}"
        };

        public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
        {
            { AmmoType.Nato556, 80 },
            { AmmoType.Nato9, 100 },
        };

        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            RoleSpawnPoints = new List<RoleSpawnPoint>
            {
                new()
                {
                    Role = RoleTypeId.NtfSergeant,
                    Chance = 100
                }
            }
        };
    }
}
