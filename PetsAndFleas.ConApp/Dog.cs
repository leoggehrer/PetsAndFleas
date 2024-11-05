namespace PetsAndFleas.ConApp
{
    /// <summary>
    /// Represents a Dog which is a type of Pet.
    /// </summary>
    public class Dog : Pet
    {
        #region fields
        private int _huntedAnimals = 0;
        private DateTime _lastHuntedTime = DateTime.MinValue;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets the number of animals hunted by the dog.
        /// </summary>
        public int HuntedAnimals
        {
            get
            {
                return _huntedAnimals;
            }
        }
        #endregion properties

        #region methods
        /// <summary>
        /// Attempts to hunt an animal.
        /// </summary>
        /// <returns>True if the dog can hunt an animal, otherwise false.</returns>
        public bool HuntAnimal()
        {
            return DateTime.Now - _lastHuntedTime > TimeSpan.FromSeconds(1) && CanHunt();
        }

        /// <summary>
        /// Determines if the dog can hunt and updates the hunt status.
        /// </summary>
        /// <returns>Always returns true.</returns>
        private bool CanHunt()
        {
            _huntedAnimals++;
            _lastHuntedTime = DateTime.Now;

            return true;
        }
        #endregion
    }
}
