using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface new'lenemez

            /*
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            */


            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    }



    interface IPersonManager
    {   //şablon , imza
        void Add();
        void update();
    }


    //İnherits - class -------------------- implements - interface şu anki durum
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
            
        }

        public void update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }


    class EmployeeManager : IPersonManager
    {
        //Personel ekleme kodları
        public void Add()
        {
            Console.WriteLine("Çalışan Eklendi");
        }

        public void update()
        {

            Console.WriteLine("Çalışan güncellendi");
        }
    }


    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }
        public void update()
        {

            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();

        }
    }








}