
namespace _03___BarrackWars_Factory.Core.Commands_Folder
{
    using _03BarracksFactory.Contracts;
    using Attributes;
    using static _03___BarrackWars_Factory.Attributes.Inject;

    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data) : base(data)
        {

        }
        public override string Execute() => this.repository.Statistics;
    }
}
