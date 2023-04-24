namespace MyMath
{
    public struct CustomVector
    {
        public float x, y, z;
        public static CustomVector operator +(CustomVector s1, CustomVector s2) {
            return new CustomVector { x = s1.x+s2.x, y = s1.y+s2.y, z = s1.z+s2.z };
        }
        public static CustomVector operator -(CustomVector s1, CustomVector s2)
        {
            return new CustomVector { x = s1.x - s2.x, y = s1.y - s2.y, z = s1.z - s2.z };
        }

        public static CustomVector operator*(CustomVector s1, float s2)
        {
            return new CustomVector { x = s1.x*s2, y = s1.y*s2, z = s1.z*s2 };
        }
        public static CustomVector operator /(CustomVector s1, float s2)
        {
            return new CustomVector { x = s1.x / s2, y = s1.y / s2, z = s1.z / s2 };
        }
    }
}