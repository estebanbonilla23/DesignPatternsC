namespace DesignPatternsC.Objects
{
    public class Car
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public bool HasGPS { get; set; }

        public override string ToString()
        {
            return $"Engine: {Engine}, Wheels: {Wheels}, GPS: {(HasGPS ? "Yes" : "No")}";
        }
    }
}