namespace PetsAndFleas.ConApp
{
    /// <summary>
    /// Represents a Flea that can jump on a Pet and bite it.
    /// </summary>
    public class Flea
    {
        #region fields
        private Pet? _actualPet = null;
        private int _amountBites = 0;

        /// <summary>
        /// Gets the Pet that the Flea is currently on.
        /// </summary>
        public Pet? ActualPet
        {
            get
            {
                return _actualPet;
            }
            private set
            {
                _actualPet = value;
            }
        }

        /// <summary>
        /// Gets the total number of bites the Flea has made.
        /// </summary>
        public int AmountBites
        {
            get
            {
                return _amountBites;
            }
            private set
            {
                _amountBites = value;
            }
        }
        #endregion properties

        #region methods
        /// <summary>
        /// Makes the Flea jump on a specified Pet.
        /// </summary>
        /// <param name="petToJumpOn">The Pet to jump on.</param>
        public void JumpOnPet(Pet? petToJumpOn)
        {
            ActualPet = petToJumpOn;
        }

        /// <summary>
        /// Makes the Flea bite the Pet a specified number of times.
        /// </summary>
        /// <param name="amount">The number of times to bite the Pet.</param>
        /// <returns>The actual number of bites made.</returns>
        /// <exception cref="ArgumentException">Thrown when the amount is 0 or negative.</exception>
        public int BitePet(int amount)
        {
            CheckAmount(amount);

            int result = 0;

            if (ActualPet != null)
            {
                result = ActualPet.GetBiten(amount);
                AmountBites += result;
            }

            return result;
        }

        /// <summary>
        /// Checks if the bite amount is valid.
        /// </summary>
        /// <param name="amount">The amount to check.</param>
        /// <exception cref="ArgumentException">Thrown when the amount is 0 or negative.</exception>
        private static void CheckAmount(int amount)
        {
            if (amount <= 0) throw new ArgumentException("BiteAmount can't be 0 or negative.");
        }

        /// <summary>
        /// Checks if the Pet is valid.
        /// </summary>
        /// <param name="pet">The Pet to check.</param>
        /// <exception cref="ArgumentNullException">Thrown when the Pet is null.</exception>
        private static void CheckPet(Pet? pet)
        {
            if (pet == null) throw new ArgumentNullException($"There is no Pet.");
        }
        #endregion methods
    }
}
