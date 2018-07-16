namespace P04.Recharge.Models
{
    using Interfaces;
    class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}
