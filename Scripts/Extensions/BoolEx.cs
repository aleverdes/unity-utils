namespace AffenCode.Utils
{
    public static class BoolEx
    {
        public static int ToInt(this bool value)
        {
            return value ? 1 : 0;
        }

        public static int ToSign(this bool value)
        {
            return value ? 1 : -1;
        }
    }
}