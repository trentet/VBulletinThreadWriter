using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI.ViewModels
{
    class SampleViewModel
    {
        public Car SelectedCar { get; set; }
        public IEnumerable<Car> Cars
        {
            get
            {
                var cars = YOUR_DATA_STORE.Cars.ToList();
                SelectedCar = cars.FirstOrDefault(car => car.Model == "VW");
                return cars;
            }
        }
    }
}
