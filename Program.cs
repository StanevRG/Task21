using System;

namespace Task21 {
    class Program
    {
        static void Main(string[] args)
        {
            //  Создаем экземпляр класса шара с инициализацией свойств (параметров): 
            //  * радиуса шара
            //  * радиуса 1 шарового сегмента
            //  * радиуса 2 шарового сегмента
            //  * высоты шарового слоя
            var sphere = new Sphere { Radius = 10, Base1Radius = 0, Base2Radius = 0, HSpereLayer = 20 };
            Console.WriteLine("Если задан радиус сферы равным {0}, тогда:", sphere.Radius);
            Console.WriteLine("площадь шара = {0}", sphere.S);
            Console.WriteLine("объем шара = {0}", sphere.V);
            Console.WriteLine("объем куба, в который вписан шар = {0}", sphere.VCube);
            Console.WriteLine("объем шарового слоя (r1 = {1}; r2 = {2}; H = {3}) = {0}", sphere.VSphereLayer, sphere.Base1Radius, sphere.Base2Radius, sphere.HSpereLayer);
            Console.WriteLine();
            Console.WriteLine("Спасибо! Нажмите кнопку для завершения программы.");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс сфера
    /// </summary>
    public class Sphere {
        /// <summary>
        /// Радиус шара
        /// </summary>
        public double Radius { get; set; }
        /// <summary>
        /// Радиус первого шарового сегмента
        /// </summary>
        public double Base1Radius { get; set; }
        /// <summary>
        /// Радиус второго шарового сегмента
        /// </summary>
        public double Base2Radius { get; set; }
        /// <summary>
        /// Высота шарового слоя
        /// </summary>
        public double HSpereLayer { get; set; }

        /// <summary>
        /// Автосвойство площади поверхности шара
        /// </summary>
        public double S
        {
            get { return 4*Math.PI* Math.Pow(Radius, 2); }
        }

        /// <summary>
        /// Автосвойство объема шара
        /// </summary>
        public double V
        {
            get { return 4f/3f*Math.PI*Math.Pow(Radius, 3); }
        }

        /// <summary>
        /// Автосвойство объема куба, в который вписан шар
        /// </summary>
        public double VCube
        {
            get { return Math.Pow(Radius*2, 3); }
        }

        /// <summary>
        /// Автосвойство объема шарового сегмента, исходя из значений Base1Radius, Base2Radius и HSpereLayer
        /// </summary>
        public double VSphereLayer {
            get { return 1 / 6f * Math.PI * Math.Pow(HSpereLayer, 3) + .5 * Math.PI * (Math.Pow(Base1Radius, 2) + Math.Pow(Base2Radius, 2)) * HSpereLayer; }
        }
    }
}
