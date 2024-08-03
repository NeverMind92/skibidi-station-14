using Robust.Shared;
using Robust.Shared.Configuration;
using Robust.Shared.Utility;

namespace Content.FireStationServer.SecretCCVars;

[CVarDefs]
public sealed class SecretCCVars : CVars
{
    public static readonly CVarDef<bool> IsFakeNumbersEnabled =
        CVarDef.Create("config.is_fake_numbers_enabled", true, CVar.SERVERONLY);
}
