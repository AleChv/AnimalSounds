namespace AnimalSounds
{
    //Această clasă definește un animal abstract care gestionează numele, sunetul și energia, permițând moștenirea, encapsularea și suprascrierea comportamentelor.
    public abstract class Animal : IEmitSound
    {
        private readonly string _name;
        private readonly string _sound;
        private int _energyLevel;

        protected Animal(string name, string sound)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));
            if (string.IsNullOrWhiteSpace(sound))
                throw new ArgumentException("Sound cannot be empty", nameof(sound));

            _name = name;
            _sound = sound;
            _energyLevel = 100;
        }

        protected void DecreaseEnergy(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative", nameof(amount));
            
            _energyLevel = Math.Max(0, _energyLevel - amount);
        }

        protected bool HasEnergy()
        {
            return _energyLevel > 0;
        }

        public virtual string GetSound()
        {
            if (!HasEnergy())
                return "... (too tired to make a sound)";
            
            DecreaseEnergy(10);
            return _sound;
        }

        public string GetName()
        {
            return _name;
        }

        public void Rest()
        {
            _energyLevel = Math.Min(100, _energyLevel + 20);
        }
    }
} 