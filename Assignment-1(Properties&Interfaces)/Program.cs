using Assignment_1_Properties_Interfaces_.Interfaces.Assignment1;
using Assignment_1_Properties_Interfaces_.Interfaces.Assignment2;
using Assignment_1_Properties_Interfaces_.Interfaces.Assignment3;
using Assignment_1_Properties_Interfaces_.Interfaces.Assignment4;
using Assignment_1_Properties_Interfaces_.Property;

namespace Assignment_1_Properties_Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment1 (Properties)
            //var bankAccount = new BankAccount(1, "Sherif Ashraf", 500);
            //bankAccount.Withdrawal(250);
            //Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine("---------------------------------------------------------------------");
            //bankAccount.Deposit(-1000);
            //Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine("---------------------------------------------------------------------");
            //bankAccount.Withdrawal(2000);
            #endregion


            #region Assignment2 (Properties)
            //var product = new Product("Egg cartoon", 170, 25);
            ////var product2 = new Product("Egg cartoon", -170, 25);
            ////var product3 = new Product("Egg cartoon", 170, -25);

            //product.UpdateStock(-30);
            //Console.WriteLine("=========================================");
            //product.UpdateStock(30);
            //Console.WriteLine("=========================================");
            //product.UpdateStock(-50);
            //Console.WriteLine($"Is Available : {product.IsStock}");
            //Console.WriteLine("=========================================");
            //product.UpdateStock(-5);
            //Console.WriteLine($"Is Available : {product.IsStock}");
            #endregion


            #region Assignment3 (Properties)

            //var car = new Car("mercedes", "Benz", 2000, 12);
            //car.Drive(50);
            //Console.WriteLine("=================================");
            //car.Drive(-50);
            //Console.WriteLine("=================================");
            //Console.WriteLine($"Age Of The Car : {car.Age} Year");
            #endregion


            #region Assignment1 (Interfaces)
            //Console.WriteLine("Please chose one of these methods to process your payment :)\n1-Paypal.\n2-Bank Transfer.\n3-CreditCard.\n");
            //int method = 0;
            //do
            //{
            //   int.TryParse(Console.ReadLine(), out method);
            //    if (method != 1 && method != 2 && method != 3)
            //    {
            //        Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            //    }
            //}
            //while ((method!=1&& method != 2 && method != 3));
            //IPayable payable = null;
            //switch (method)
            //{
            //    case 1 :
            //        payable = new Paypal();
            //        break;
            //    case 2:
            //        payable = new BankTransfer();
            //        break;
            //    case 3:
            //        payable = new CreditCard();
            //        break;
            //    default:
            //        Console.WriteLine("Your Input is invalid");
            //        break;
            //}

            //payable?.ProcessPayment();
            #endregion


            #region Assignment2 (Interfaces)
            //IEngineVehicle vehicle1 = new Interfaces.Assignment2.Car();
            //IEngineVehicle vehicle2 = new Truck();
            //IEngineVehicle vehicle3 = new Motorcycle();

            //vehicle1.Start();
            //vehicle1.Stop();
            //Console.WriteLine("========================================");
            //vehicle2.Start();
            //vehicle2.Stop();
            //Console.WriteLine("========================================");
            //vehicle3.Start();
            //vehicle3.Stop();
            //Console.WriteLine("========================================");
            #endregion


            #region Assignment3 (Interfaces)
            //var video = new Video();
            //var mediaPlayer1 = new MediaPlayer(video);
            //mediaPlayer1.Play();
            //mediaPlayer1.Stop();
            //Console.WriteLine("=========================================");
            //var audio = new Audio();
            //var mediaPlayer2 = new MediaPlayer(audio);
            //mediaPlayer2.Play();
            //mediaPlayer2.Stop();

            #endregion

            #region Assignment4 (Interfaces)
            var sms = new SMS();
            var email = new Email();
            var notification = new PushNotification();
            Helper.NotifyCustomer(sms);
            Console.WriteLine("====================================");
            Helper.NotifyCustomer(email);
            Console.WriteLine("====================================");
            Helper.NotifyCustomer(notification);

            #endregion

        }
    }
}
