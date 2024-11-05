namespace PetsAndFleas.ConApp
{
    public class Flea
    {
        #region fields
        private Pet? _actualPet = null;
        private int _amountBites = 0;
        #endregion fields

        #region properties
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
        public void JumpOnPet(Pet? petToJumpOn)
        {
            ActualPet = petToJumpOn;
        }

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

        private static void CheckAmount(int amount)
        {
            if (amount <= 0) throw new ArgumentException("BiteAmount can't be 0 or negative.");
        }

        private static void CheckPet(Pet? pet)
        {
            if (pet == null) throw new ArgumentNullException($"There is no Pet.");
        }
        #endregion methods

    }
}
