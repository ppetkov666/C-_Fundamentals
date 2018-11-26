
namespace _03___BarrackWars_Factory.Core.Commands_Folder
{
    using System;

    public class FightCommand : Command
    {
        public FightCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
