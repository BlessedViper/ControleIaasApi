namespace ControleIaas.Shared.Convertions
{
    public static class BoolToShort
    {
        public static short ConvertBool(bool teste)
        {
            if (teste == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
