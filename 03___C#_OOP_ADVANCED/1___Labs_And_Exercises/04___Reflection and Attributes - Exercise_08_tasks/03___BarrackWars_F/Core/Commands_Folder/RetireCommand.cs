
namespace _03___BarrackWars_Factory.Core.Commands_Folder
{
    using _03___BarrackWars_Factory.Attributes;
    using _03BarracksFactory.Contracts;
    using static _03___BarrackWars_Factory.Attributes.Inject;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            this.repository.RemoveUnit(unitType);
            return $"{unitType} retired!";
        }
    }
}
