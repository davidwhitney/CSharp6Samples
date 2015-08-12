namespace ClassLibrary1
{
    public class StringInterpolationBefore
    {
        public StringInterpolationBefore()
        {
            const string name = "David";
            var s = string.Format("{0} is awesome", name);
        }
    }
}