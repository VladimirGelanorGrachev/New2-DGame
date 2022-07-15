namespace Features.Shed.Upgrade
{
    internal class JumpHeight : IUpgradeHandler
    {
        private readonly float _jumpHeight;

        public JumpHeight(float jumpHeight) =>
            _jumpHeight = jumpHeight;

        public void Upgrade(IUpgradable upgradable) =>
            upgradable.JumpHeight += _jumpHeight;
    }
}
