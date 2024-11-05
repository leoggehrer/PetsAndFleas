namespace PetsAndFleas.ConApp
{
    public class Pet
    {
        #region fields
        private static int _lastPetID = 0;

        private int _petID;
        private int _remainingBites = 100;
        #endregion fields

        #region properties
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
        public int RemainingBites
        {
            get
            {
                return Math.Max(_remainingBites, 0);
            }
        }

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

        public Pet()
        {
            PetID = ++LastPetID;
        }

        #region methods
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

        private static void CheckBiteNumber(int numberOfBites)
        {
            if (numberOfBites <= 0) throw new ArgumentException("Number of Bites can't be 0 or negative!");
        }
        #endregion methods

    }
}
