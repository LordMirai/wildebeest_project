namespace project
{
    public class Configuration
    {
        /**
         * <summary>Loads a matrix with a predefined configuration. Should work for table initialization</summary>
         *
         * <param name="matrix">Matrix to populate, bi-dimensional</param>
         * <param name="cfgIn">Config enum value to use</param>
         *
         * <returns>The success in loading the configuration. Invalid values return false</returns>
         */
        public bool load_configuration(ref Piece[,] matrix, Config cfgIn = Config.Empty)
        {
            switch (cfgIn)
            {
                case Config.Empty:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            matrix[i, j] = null;
                        }
                    }
                    return true;
                case Config.Default:
                    // to be implemented.
                    return true;
                default:
                    return false;
            }
        }
        
        
    }
}