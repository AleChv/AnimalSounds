namespace AnimalSounds
{
  //Clasa Lion moștenește Animal, schimbă sunetul pentru un comportament specific și adaugă o metodă Hunt pentru a reduce energia.
    public class Lion : Animal
    {
        private bool _isHungry;

        public Lion() : base("Lion", "Roar")
        {
            _isHungry = true;
        }

        public override string GetSound()
        {
            if (_isHungry)
            {
                DecreaseEnergy(20); // Hungry lions use more energy
                return $"{base.GetSound()} (hungry roar!)";
            }
            
            return base.GetSound();
        }

        public void Hunt()
        {
            if (!HasEnergy())
                throw new InvalidOperationException("Lion is too tired to hunt");
            
            DecreaseEnergy(30);
            _isHungry = false;
        }
    }
} 