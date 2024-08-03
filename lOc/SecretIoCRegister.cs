using Content.FireStationServer.GameTickerModify;
using Content.FireStationServer.Roles;
using Content.FireStationServer.Roles.SCP.Science;
using Content.Server.GameTicking;
using Content.Server.Roles;
using Content.Server.Spawners.EntitySystems;
using Robust.Shared.IoC;

namespace Content.FireStationServer.IoC;

public static class SecretIoCRegister
{
    public static void RegisterIoC()
    {
        IoCManager.RegisterInstance<IAntagManager>(new AntagManager());
        IoCManager.RegisterInstance<ISCPStationPointSystem>(new SCPStationPointSystem());
        IoCManager.RegisterInstance<IRevolutionaryMaker>(new RevolutionaryMaker());
        IoCManager.RegisterInstance<IStatusResponseProvider>(new StatusResponseProvider());
    }
}
