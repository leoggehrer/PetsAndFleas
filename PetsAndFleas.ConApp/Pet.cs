namespace PetsAndFleas.ConApp
{
    /// <summary>
    /// Represents a pet with a unique ID and a limited number of bites.
    /// </summary>
    public class Pet
    {
        #region fields
        private static int _lastPetID = 0;

        private int _petID;
        private int _remainingBites = 100;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets the unique ID of the pet.
        /// </summary>
        public int PetID
        {
            get
            {
                return _petID;
            }
            private set
            {
                _petID = value;
            }
        }

        /// <summary>
        /// Gets the remaining number of bites the pet can take.
        /// </summary>
        public int RemainingBites
        {
            get
            {
                return Math.Max(_remainingBites, 0);
            }
        }

        /// <summary>
        /// Gets the last assigned pet ID.
        /// </summary>
        public static int LastPetID
        {
            get
            {
                return _lastPetID;
            }
            private set
            {
                _lastPetID = value;
            }
        }
        #endregion properties

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        public Pet()
        {
            PetID = ++LastPetID;
        }

        #region methods
        /// <summary>
        /// Reduces the remaining bites by the specified number of bites.
        /// </summary>
        /// <param name="numberOfBites">The number of bites to reduce.</param>
        /// <returns>The actual number of bites taken.</returns>
        /// <exception cref="ArgumentException">Thrown when the number of bites is less than or equal to zero.</exception>
        public int GetBiten(int numberOfBites)
        {
            CheckBiteNumber(numberOfBites);

            int result = 0;

            if (numberOfBites > RemainingBites)
                result = RemainingBites;
            else
                result = numberOfBites;

            _remainingBites -= result;

            return result;
        }

        /// <summary>
        /// Checks if the number of bites is valid.
        /// </summary>
        /// <param name="numberOfBites">The number of bites to check.</param>
        /// <exception cref="ArgumentException">Thrown when the number of bites is less than or equal to zero.</exception>
        private static void CheckBiteNumber(int numberOfBites)
        {
            if (numberOfBites <= 0) throw new ArgumentException("Number of Bites can't be 0 or negative!");
        }
        #endregion methods
    }
}
