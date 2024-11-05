namespace PetsAndFleas.ConApp
{
    public class Cat: Pet
    {
        #region fields
        private bool _isOnTree = false;
        private int _treesClimbed = 0;
        #endregion fields

        #region properties
        public int TreesClimbed
        {
            get
            {
                return _treesClimbed;
            }
            private set
            {
                _treesClimbed = value;
            }
        }
        public bool IsOnTree
        {
            get
            {
                return _isOnTree;
            }
            set
            {
                _isOnTree = value;
            }
        }
        #endregion properties

        #region methods
        public bool ClimbDown()
        {
            bool result = false;

            if (IsOnTree)
            {
                IsOnTree = false;
                result = true;
            }
            return result;
        }

        public bool ClimbOnTree()
        {
            bool result = false;

            if (!IsOnTree)
            {
                TreesClimbed++;
                IsOnTree = true;
                result = true;
            }
            return result;
        }
        #endregion methods
    }
}
