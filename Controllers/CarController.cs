using Models;
using Repositories;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService carService;
        private InsureceService insureceService;

        public CarController()
        {
            carService = new CarService();
            insureceService = new InsureceService();
        }
        public bool Insert(Car car)
        {
             car.insurance.id = insureceService.Insert(car.insurance);
             return carService.Insert(car);
        }

        public bool Update(Car car)
        {
            return carService.Update(car);
        }

        public bool Delete(int id)
        {
            return carService.Delete(id);
        }

        public List<Car> GetAll()
        {
            return carService.GetAll();

        }

        public Car Get(int id)
        {
            return carService.Get(id);

        }

    }
}
