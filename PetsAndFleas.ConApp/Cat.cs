namespace PetsAndFleas.ConApp
{
    /// <summary>
    /// Represents a Cat that can climb trees.
    /// </summary>
    public class Cat : Pet
    {
        #region fields
        private bool _isOnTree = false;
        private int _treesClimbed = 0;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets the number of trees the Cat has climbed.
        /// </summary>
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

        /// <summary>
        /// Gets or sets a value indicating whether the Cat is currently on a tree.
        /// </summary>
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
        /// <summary>
        /// Makes the Cat climb down from a tree.
        /// </summary>
        /// <returns>True if the Cat successfully climbed down, otherwise false.</returns>
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

        /// <summary>
        /// Makes the Cat climb up a tree.
        /// </summary>
        /// <returns>True if the Cat successfully climbed up, otherwise false.</returns>
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
