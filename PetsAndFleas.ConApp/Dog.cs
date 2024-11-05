namespace PetsAndFleas.ConApp
{
    public class Dog: Pet
    {
        #region fields
        private int _huntedAnimals = 0;
        private DateTime _lastHuntedTime = DateTime.MinValue;
        #endregion fields

        #region properties
        public int HuntedAnimals
        {
            get
            {
                return _huntedAnimals;
            }
        }
        #endregion properties

        #region methods
        public bool HuntAnimal()
        {
            return DateTime.Now - _lastHuntedTime > TimeSpan.FromSeconds(1) && CanHunt();
        }

        private bool CanHunt()
        {
            _huntedAnimals++;
            _lastHuntedTime = DateTime.Now;

            return true;
        }
        #endregion

    }
}
