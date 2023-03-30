namespace project
{
    public class Configuration
    {
        public bool load_configuration(int[,] matrix, Config cfgIn = Config.Empty)
        {
            switch (cfgIn)
            {
                case Config.Empty:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                    return true;
                default:
                    return false;
            }
        }
        
        
    }
}