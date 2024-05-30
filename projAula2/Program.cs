// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

CarController carController = new CarController();

Car car = new Car
{
    id = 1,
     name = "Caronete",
    color = "red",
    year = 2020
};

/*for(int i = 0; i < 10000; i++)
{
    car.name = "Teste - " + i.ToString();
    Console.WriteLine(new CarController().Insert(car) ? "Registro inserido - " +car.name : "Erro ao inserir");

}*/
//Console.WriteLine(car);


//Console.WriteLine(carController.Update(car) ? "Update Inserido" : "Erro ao Update");

foreach (var item in new CarController().GetAll().Where( x => x.id > 990).ToList().Take(10))
{
    Console.WriteLine(item);

}
/*foreach (var item in new CarController().GetAll())
{
    Console.WriteLine(item);
}

Console.WriteLine("\n");*/

//Console.WriteLine(new CarController().Get(3));

