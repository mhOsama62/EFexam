using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using examDomin;
using exmDataLayer;
//using Microsoft.IdentityModel.Tokens;

namespace examMainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (examDBContext context = new examDBContext())
            {
                context.Database.EnsureCreated();
                Init();
            }

            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("Hi ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Welcome to my program for car management applet. BTW, it's an assignment for 1000 programming. However, just enjoy!");

            Welcome(name);
        }
        private static void Welcome(string name) {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nWelcome Back ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" what u want to do?\n ");

            Console.Write("**************************************************\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Management Cars\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Management Parts\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n3 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Management Custmors\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Management Sales\n");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Management Suppliers\n");

            Console.Write("**************************************************\n");
            Console.Write("so what u choose: ");
            byte MainOp = byte.Parse(Console.ReadLine());

            switch(MainOp){
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n****************");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Management Cars ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("****************\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Info Cars\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Add Car\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n3 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Remove Car\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n4 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Modify Car\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n0 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": back to Main\n");

                    Console.Write("\nso what u choose: ");


                    byte CarOp = byte.Parse(Console.ReadLine());
                    switch (CarOp)
                    {
                        case 1:
                            infoCars();
                            break;
                        case 2:
                            addCar();
                            break;
                        case 3:
                            Console.Write("\n what the Car ID: ");
                            int carIDUser = int.Parse(Console.ReadLine());
                            removeCar(carIDUser);
                            break;
                        case 4:
                            Console.Write("\n what the Car ID: ");
                            int carIDUser1 = int.Parse(Console.ReadLine());
                            updateCar(carIDUser1);
                            break;
                        case 0:
                            Welcome(name);
                            break;
                    }
                    Welcome(name);

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n****************");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Management Parts ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("****************\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Info Parts\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Add Part\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n3 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Remove Part\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n4 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Modify Part\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n0 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": back to Main\n");

                    Console.Write("\nso what u choose: ");
                    byte PartOp = byte.Parse(Console.ReadLine());
                    switch (PartOp)
                    {
                        case 1:
                            infoParts();
                            break;
                        case 2:
                            addParts();
                            break;
                        case 3:
                            Console.Write("\n what the Part ID: ");
                            int partIDUser = int.Parse(Console.ReadLine());
                            removePart(partIDUser);
                            break;
                        case 4:
                            Console.Write("\n what the Part ID: ");
                            int partIDUser1 = int.Parse(Console.ReadLine());
                            updatePart(partIDUser1);
                            break;
                        case 0:
                            Welcome(name);
                            break;
                    }
                    Welcome(name);

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n****************");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" Management Custmors ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("****************\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Info Custmor\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Add Custmor\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n3 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Remove Custmor\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n4 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Modify Custmor\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n0 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": back to Main\n");

                    Console.Write("\nso what u choose: ");
                    byte custOp = byte.Parse(Console.ReadLine());
                    switch (custOp)
                    {
                        case 1:
                            infoCustomrs();
                            break;
                        case 2:
                            addCustmor();
                            break;
                        case 3:
                            Console.Write("\n what the Custmor ID: ");
                            int cusIDUser = int.Parse(Console.ReadLine());
                            removeCustmor(cusIDUser);
                            break;
                        case 4:
                            Console.Write("\n what the Custmor ID: ");
                            int cusIDUser1 = int.Parse(Console.ReadLine());
                            updateCustmor(cusIDUser1);
                            break;
                        case 0:
                            Welcome(name);
                            break;
                    }
                    Welcome(name);

                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n****************");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(" Management Sales ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("****************\n");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Info Sales\n");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Add Sale\n");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n3 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Remove Sale\n");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n4 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Modify Sale\n");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n0 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": back to Main\n");

                    Console.Write("\nso what u choose: ");
                    byte saleOp = byte.Parse(Console.ReadLine());
                    switch (saleOp)
                    {
                        case 1:
                            infoSales();
                            break;
                        case 2:
                            addSale();
                            break;
                        case 3:
                            Console.Write("\n what the Sale ID:");
                            int saleIDUser = int.Parse(Console.ReadLine());
                            removeSales(saleIDUser);
                            break;
                        case 4:
                            Console.Write("\n what the Sale ID:");
                            int saleIDUser1 = int.Parse(Console.ReadLine());
                            updateSales(saleIDUser1);
                            break;
                        case 0:
                            Welcome(name);
                            break;
                    }
                    Welcome(name);

                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n****************");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" Management Suppliers ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("****************\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Info Suppliers\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Add Supplier\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n3 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Remove Supplier\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n4 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": Modify Supplier\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n0 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": back to Main\n");

                    Console.Write("\nso what u choose: ");
                    byte supOp = byte.Parse(Console.ReadLine());
                    switch (supOp)
                    {
                        case 1:
                            infoSuppliers();

                            break;
                        case 2:
                            addSupplier();
                            break;
                        case 3:
                            Console.Write("\n what the Supplier ID:");
                            int suoIDUser = int.Parse(Console.ReadLine());
                            removeSupplier(suoIDUser);
                            break;
                        case 4:
                            Console.Write("\n what the Supplier ID:");
                            int suoIDUser1 = int.Parse(Console.ReadLine());
                            updateSuppliers(suoIDUser1);
                            break;
                        case 0:
                            Welcome(name);
                            break;
                    }
                    Welcome(name);

                    break;

            }

        }
        static void updateSuppliers( int id)
        {
            using (var context = new examDBContext()) {
                var sup = context.Suppliers.FirstOrDefault(e => e.id == id);

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("New Name");
                Console.ResetColor();
                Console.Write(" For this Suppliers: ");
                string newSupName = Console.ReadLine();

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("New Address");
                Console.ResetColor();
                Console.Write(" For this Suppliers: ");
                string newSupAddtress = Console.ReadLine();

                sup.Name = newSupName;
                sup.Address = newSupAddtress;

                context.Suppliers.Update(sup);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\n CONGRATS SUPPLIER UPDATE DONE!\n");
                Console.ResetColor();




            }

        }
        static void updateSales(int id)
        {
            using (var context = new examDBContext())
            {
                var sale = context.Sales.FirstOrDefault(e => e.id == id);


                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("New Total");
                Console.ResetColor();
                Console.Write(" For this Sale: ");
                int newSaleTotal = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\n[NOTE : make sure u have a car with this ID]\n");
                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("New Car ID");
                Console.ResetColor();
                Console.Write(" For this Sale: ");
                int newSaleCarID = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\n[NOTE : make sure u have a custmor with this ID]\n");
                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("New custmor ID");
                Console.ResetColor();
                Console.Write(" For this Sale: ");
                int newSaleCusID = int.Parse(Console.ReadLine());

                sale.CarID = newSaleCarID;
                sale.CustmorID = newSaleCusID;
                sale.Total = newSaleTotal;
                context.Sales.Update(sale);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\n CONGRATS SALE UPDATE DONE!\n");
                Console.ResetColor();


            }
        }
        static void updatePart(int id)
        {
            using (var context = new examDBContext())
            {
                var part = context.Parts.FirstOrDefault(e => e.id == id);

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("New Name");
                Console.ResetColor();
                Console.Write(" For this Part: ");
                string newPartName = Console.ReadLine();

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("New Price");
                Console.ResetColor();
                Console.Write(" For this Part: ");
                double newPartPrice = double.Parse(Console.ReadLine());

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("New Quantity");
                Console.ResetColor();
                Console.Write(" For this Part: ");
                int newParQua = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n[NOTE : make sure u have a car with this ID]\n");
                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("New Car ID");
                Console.ResetColor();
                Console.Write(" For this Part: ");
                int newParCarID = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n[NOTE : make sure u have a supplier with this ID]\n");
                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("New Supplier ID");
                Console.ResetColor();
                Console.Write(" For this Part: ");
                int newParSuppID = int.Parse(Console.ReadLine());

                part.Name = newPartName;
                part.Price = newPartPrice;
                part.Quantity = newParQua;
                part.SuppliersID = newParSuppID;
                part.Carid = newParCarID;
                context.Parts.Update(part);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n CONGRATS PART UPDATE DONE!\n");
                Console.ResetColor();
            }

        }
        private static void updateCustmor(int id)
        {
            using (var context = new examDBContext())
            {
                var cus = context.Custmor.FirstOrDefault(e => e.id == id);

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("New Name");
                Console.ResetColor();
                Console.Write(" For this Custmor: ");
                string newCusName = Console.ReadLine();

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("New Age");
                Console.ResetColor();
                Console.Write(" For this Custmor: ");
                int newCusAge = int.Parse(Console.ReadLine());

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("New Address");
                Console.ResetColor();
                Console.Write(" For this Custmor: ");
                string newCusAddress = Console.ReadLine();

                cus.Address = newCusAddress;
                cus.Age = newCusAge;
                cus.Name = newCusName;

                context.Custmor.Update(cus);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n CONGRATS CUSTMOR UPDATE DONE!\n");
                Console.ResetColor();



            }
        }
        private static void updateCar(int id)
        {
            using (var context = new examDBContext())
            {
                var car = context.Cars.FirstOrDefault(e => e.id == id);
                
                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("New Model");
                Console.ResetColor();
                Console.Write(" For this Car: ");
                string newCarModel = Console.ReadLine();

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("New Year");
                Console.ResetColor();
                Console.Write(" For this Car: ");
                int newCarYear = int.Parse(Console.ReadLine());

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("New Gear");
                Console.ResetColor();
                Console.Write(" For this Car: ");
                string newCarGear = Console.ReadLine();

                Console.Write("\nEnter ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("New Km");
                Console.ResetColor();
                Console.Write(" For this Car: ");
                string newCarKm = Console.ReadLine();

                car.Model = newCarModel;
                car.Km = newCarKm;
                car.Year = newCarYear;
                car.Gear = newCarGear;

                context.Cars.Update(car);

                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\n CONGRATS CAR UPDATE DONE!\n");
                Console.ResetColor();



            }
        }

        private static void removeSales(int id)
        {
            using (var context = new examDBContext())
            {
                var sale = context.Sales.FirstOrDefault(e => e.id == id);
                context.Sales.Remove(sale);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n CONGRATS SALE REMOVE DONE!\n");
                Console.ResetColor();


            }
        }
        private static void removeCustmor(int id)
        {
            using (var context = new examDBContext())
            {
                var cus = context.Custmor.FirstOrDefault(e => e.id == id);
                context.Custmor.Remove(cus);
                var sale1 = context.Sales.FirstOrDefault(e => e.CustmorID == id);
                context.Sales.Remove(sale1);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n CONGRATS CUSTMOR REMOVE DONE!\n");
                Console.ResetColor();
            }
        }
        private static void removePart(int id)
        {
            using (var context = new examDBContext())
            {
                var part = context.Parts.FirstOrDefault(e => e.id == id);
                context.Parts.Remove(part);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n CONGRATS PART REMOVE DONE!\n");
                Console.ResetColor();
            }
        }
        private static void removeSupplier(int id)
        {
            using (var context = new examDBContext())
            {
                var supplier = context.Suppliers.FirstOrDefault(e => e.id == id);
                context.Suppliers.Remove(supplier);
                var part = context.Parts.FirstOrDefault(e => e.SuppliersID == id);
                context.Parts.Remove(part);

                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n CONGRATS SUPPLIER REMOVE DONE!\n");
                Console.ResetColor();


            }
        }
        private static void removeCar(int id)
        {
            using (var context = new examDBContext())
            {
                var car = context.Cars.FirstOrDefault(e => e.id == id);
                context.Cars.Remove(car);
                var part = context.Parts.FirstOrDefault(e => e.Carid == id);
                context.Parts.Remove(part);
                var sale = context.Sales.FirstOrDefault(e => e.CarID == id);
                context.Sales.Remove(sale);
                context.SaveChanges();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n CONGRATS CAR REMOVE DONE!\n");
                Console.ResetColor();
                infoCars();
            }
        }
        private static void infoSales()
        {
            using (var context = new examDBContext())
            {
                var sales = context.Sales.ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("| ID\t| Total\t| Car ID\t| Custmor ID\t|");
                Console.ForegroundColor = ConsoleColor.Magenta;
                foreach(var sale in sales)
                {
                    Console.WriteLine($"| {sale.id}\t| {sale.Total}\t| {sale.CarID}\t\t| {sale.CustmorID}\t|");

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("----------------------------------------------------");

                }
            }
        }
        private static void infoCustomrs() {
            using (var context = new examDBContext())
            {
                var customrs = context.Custmor.ToList();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("| ID\t| Name\t\t| Age\t\t| Address\t\t|");
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var customr in customrs)
                {
                    Console.WriteLine($"| {customr.id}\t| {customr.Name}\t\t| {customr.Age}\t\t| {customr.Address}\t|");

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("----------------------------------------------------");

                }
            }
        }
        private static void infoParts()
        {
            using (var context = new examDBContext())
            {
                var parts = context.Parts.ToList();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("| ID\t| Car ID\t| Name\t| Price\t| Quantity\t| Supplier ID\t");
                Console.ForegroundColor = ConsoleColor.Red;

                foreach (var part in parts)
                {
                    Console.WriteLine($"| {part.id}\t| {part.Carid}\t| {part.Name}\t| {part.Price}\t| {part.Quantity}\t| {part.SuppliersID}\t");

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("----------------------------------------------------");

                }
            }
        }
        private static void infoSuppliers()
        {
            using (var context = new examDBContext())
            {
                var supplirs = context.Suppliers.ToList();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("| ID\t| Name\t\t| Address\t\t");
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("----------------------------------------------------");

                foreach(var supplier in supplirs)
                {
                    Console.WriteLine($"| {supplier.id}\t| {supplier.Name}\t\t| {supplier.Address}\t\t|");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("----------------------------------------------------");
                }

            }
        }
        private static void infoCars()
        {
            using (var context = new examDBContext())
            {
                var cars = context.Cars.ToList();

                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("| ID\t| Model\t\t| Year\t\t| Km\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("----------------------------------------------------");

                foreach (var car in cars)
                {
                   
                  
                    Console.WriteLine($"| {car.id}\t| {car.Model}\t| {car.Year}\t\t| {car.Km}\t");
                    
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("----------------------------------------------------");
                }

            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        private static void addParts()
        {

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Name");
            Console.ResetColor();
            Console.Write(" For New Part: ");
            string newNamePart = Console.ReadLine();


            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Price");
            Console.ResetColor();
            Console.Write(" For New Part: ");
            float newPricePart = float.Parse(Console.ReadLine());


            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Quantity");
            Console.ResetColor();
            Console.Write(" For New Part: ");
            int newQuaPart = int.Parse(Console.ReadLine());

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Car ID");
            Console.ResetColor();
            Console.Write(" For this Part: ");
            int newCarIDPart = int.Parse(Console.ReadLine());

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Supplier ID");
            Console.ResetColor();
            Console.Write(" For this Part: ");
            int newSupIDPart = int.Parse(Console.ReadLine());

            using (var context = new examDBContext())
            {
                Parts part = new Parts()
                {
                    Name=newNamePart,
                    Price=newPricePart,
                    Quantity=newQuaPart,
                    Carid=newCarIDPart,
                    SuppliersID=newSupIDPart
                };
                context.Parts.Add(part);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n CONGRATS PART ADD DONE!\n");
                Console.ResetColor();
            }
        }
        private static void addSale()
        {
            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Total Price");
            Console.ResetColor();
            Console.Write(" For this sale: ");
            double newTotalSale = double.Parse(Console.ReadLine());

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Car ID");
            Console.ResetColor();
            Console.Write(" For this sale: ");
            int newCarIDSale = int.Parse(Console.ReadLine());

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Custmor ID");
            Console.ResetColor();
            Console.Write(" For this sale: ");
            int newCusIDSale = int.Parse(Console.ReadLine());

            using(var context = new examDBContext())
            {
                Sales sale = new Sales()
                {
                    Total = newTotalSale,
                    CarID=newCarIDSale,
                    CustmorID=newCusIDSale
                };
                context.Sales.Add(sale);
                context.SaveChanges();


                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n CONGRATS SALE ADD DONE!\n");
                Console.ResetColor();
            }


        }
        private static void addCustmor()
        {
            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Name");
            Console.ResetColor();
            Console.Write(" For New Custmor: ");
            string newCusName = Console.ReadLine();

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Age");
            Console.ResetColor();
            Console.Write(" For New Custmor: ");
            int newcusAge = int.Parse(Console.ReadLine());

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Address");
            Console.ResetColor();
            Console.Write(" For New Custmor: ");
            string newCusSddress = Console.ReadLine();

            using(var context = new examDBContext())
            {
                Custmor custmor = new Custmor() {
                Name = newCusName,
                Age = newcusAge,
                Address = newCusSddress
                };
                context.Custmor.Add(custmor);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n CONGRATS CUSTMOR ADD DONE!\n");
                Console.ResetColor();

            }
        }
        private static void addSupplier()
        {

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Name");
            Console.ResetColor();
            Console.Write(" For New Supplier: ");
            string newSupName = Console.ReadLine();

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Address");
            Console.ResetColor();
            Console.Write(" For New Supplier: ");
            string newSupAddress = Console.ReadLine();

            using (var context = new examDBContext())
            {
                Suppliers supplier = new Suppliers()
                {
                    Name = newSupName,
                    Address = newSupAddress
                };
                context.Suppliers.Add(supplier);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\n CONGRATS SUPPLIER ADD DONE!\n");
                Console.ResetColor();


            }

        }

        private static void addCar()

        {
            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Model");
            Console.ResetColor();
            Console.Write(" For New Car: ");
            string newMdel = Console.ReadLine();

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Year");
            Console.ResetColor();
            Console.Write(" For New Car: ");
            int newYear = int.Parse(Console.ReadLine());

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Gear");
            Console.ResetColor();
            Console.Write(" For New Car: ");
            string newGear = Console.ReadLine();

            Console.Write("\nEnter ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Km");
            Console.ResetColor();
            Console.Write(" For New Car: ");
            string newKm = Console.ReadLine();

         




            using (var context = new examDBContext())
            {
                Cars newCar = new Cars()
                {
                    Model = newMdel,
                    Year = newYear,
                    Gear=newGear,
                    Km=newKm,

                };
                context.Cars.Add(newCar);
                context.SaveChanges();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n CONGRATS CAR ADD DONE!\n");
                Console.ResetColor();



            }
        }

        private static void Init()
        {
            using (var context = new examDBContext())
            {
                Suppliers supplier1 = new Suppliers()
                {
                    Name = "RASHAD",
                    Address = "MARE"
                };
                context.Suppliers.Add(supplier1);

                Suppliers supplier2 = new Suppliers()
                {
                    Name = "mohmad",
                    Address = "azaz"
                };
                context.Suppliers.Add(supplier2);

                Cars car1 = new Cars()
                {
                    Gear = "Z",
                    Model = "Model Z",
                    Year = 2023,
                    Km = "Z",
                  
                };
                context.Cars.Add(car1);

                Parts part1 = new Parts()
                {
                    Name = "Motor Z",
                    Price = 250.8,
                    Quantity = 9,
                    SuppliersID = 2,
                    Supplier = supplier1,
                  Carid = 1

                };
                context.Parts.Add(part1);

                Parts part2 = new Parts()
                {
                    Name = "GLASS",
                    Price = 189.69,
                    Quantity = 17,
                    SuppliersID = 2,
                    Supplier = supplier1,
                    Carid = 1
                };
                context.Parts.Add(part2);



                context.SaveChanges();
            }
        }
    }
}
