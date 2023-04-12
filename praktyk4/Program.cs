namespace ClassEx
{
    class Sphere
    {
        public double surfaceArea, mass, volume, sectionArea;
        public double radius, density;
        public const double pi = Math.PI;
        public Sphere(double radiusInput, double densityInput)
        {
            radius = radiusInput; density = densityInput;
            surfaceArea = AreaEval(); volume = VolumeEval();
            mass = MassEval(); sectionArea = SectionAreaEval();
        }
        public double AreaEval() { return 4 * pi * Math.Pow(radius, 2); }
        public double VolumeEval() { return (4/3) * pi * Math.Pow(radius, 3); }
        public double MassEval() { return volume * density; }
        public double SectionAreaEval() { return pi * Math.Pow(radius, 2); }
    }
    class Program
    {
        static void EvalResult(Sphere sph)
        {
            string Output = "\nСфера має площу поверхні {0:#.##}" +
            " кв. метрів, об'єм - {1:#.##} куб. метрів і" +
            " площу її перетину через центр {2:#.##} кв. метрів за" +
            " довжини радіуса {3:#.##} м; сфера також має масу {4:#.##} кг" +
            " за густини її матеріалу {5:#.##} кг/куб.м.";
            Console.WriteLine(Output, sph.surfaceArea, sph.volume,
            sph.sectionArea, sph.radius, sph.mass, sph.density);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double radiusInput, densityInput;
            while (true)
            {
                try
                {
                    Console.Write("Введіть довжину радіуса сфери (м): ");
                    radiusInput = double.Parse(Console.ReadLine());
                    if (radiusInput > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введено недопустиме значення" +
                            " довжини радіуса. Спробуйте ще раз.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено недопустиме значення" +
                            " довжини радіуса. Спробуйте ще раз.");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Введіть густину матеріалу сфери (кг/куб.м): ");
                    densityInput = double.Parse(Console.ReadLine());
                    if (densityInput > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введено недопустиме значення" +
                            " густини матеріалу сфери. Спробуйте ще раз.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено недопустиме значення" +
                            " довжини радіуса. Спробуйте ще раз.");
                }
            }
            Sphere newSphere = new(radiusInput, densityInput);
            EvalResult(newSphere);
        }
    }
}