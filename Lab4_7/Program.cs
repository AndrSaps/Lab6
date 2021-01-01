using DL;
using System;
using DL.Entities;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Lab4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserRepository = new Repository<User>();

            var users = UserRepository.GetAll().ToList();

            foreach(var user in users)
            {
                Console.WriteLine("{0} {1} {2}",user.FirstName,user.LastName,user.Email);
            }

            UserRepository.Create(new User
            {
                Age = 25,
                LastName = "bbbbb",
                FirstName = "aaaaa",
                Email = "a@g.com",
                Sex = "Male"
            });
            Console.WriteLine("\nNew user added");

            users = UserRepository.GetAll().ToList();

            foreach (var user in users)
            {
                Console.WriteLine("{0} {1} {2}", user.FirstName, user.LastName, user.Email);
            }

            var User = UserRepository.GetById(2);
            User.FirstName = "AAAA";
            User.LastName = "BBBB";

            UserRepository.Update(User);

            Console.WriteLine("\nUser updated");

            users = UserRepository.GetAll().ToList();

            foreach (var user in users)
            {
                Console.WriteLine("{0} {1} {2}", user.FirstName, user.LastName, user.Email);
            }

            Console.ReadLine();
        }
    }
}
