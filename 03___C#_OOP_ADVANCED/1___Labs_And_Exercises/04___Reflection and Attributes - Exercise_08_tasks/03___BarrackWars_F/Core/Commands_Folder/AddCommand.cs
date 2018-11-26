
namespace _03___BarrackWars_Factory.Core.Commands_Folder
{
    using Attributes;
    using _03BarracksFactory.Contracts;
    using static _03___BarrackWars_Factory.Attributes.Inject;

    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
