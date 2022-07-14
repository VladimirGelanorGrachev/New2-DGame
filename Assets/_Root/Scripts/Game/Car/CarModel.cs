using Features.Shed.Upgrade;

namespace Game.Car
{
    internal class CarModel: IUpgradable
    {
        public readonly float _defaultSpeed;
        public readonly float _jumpHeight;

        public float Speed { get; set; }


        public CarModel(float speed, float jumpHeight)
        {
            _defaultSpeed = speed;
            Speed = speed;
            _jumpHeight = jumpHeight;
        }

        public void Restore() =>
            Speed = _defaultSpeed;

    }
}
