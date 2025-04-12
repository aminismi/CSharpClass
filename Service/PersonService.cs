﻿using Model;
using Model.DomainModels;

namespace Service
{
    public class PersonService
    {
        private readonly FinalProjectDbContext _context;


        public PersonService(FinalProjectDbContext context)
        {
            _context = context;
        }

        public bool AddPerson(Person person)
        {
            try
            {
                _context.Person.Add(person);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddPerson: {ex.Message}");
                return false;
            }
        }

     public bool DeletePerson(int id)
        {
            try
            {
                var person = _context.Person.Find(id);
                if (person != null)
                {
                    _context.Person.Remove(person);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeletePerson: {ex.Message}");
                return false;
            }
        }

        public Person GetPersonById(int id)
        {
            return _context.Person.FirstOrDefault(p => p.Id == id);
        }

        public bool UpdatePerson(Person person)
        {
            try
            {
                var existingPerson = _context.Person.Find(person);
                if (existingPerson != null)
                {
                    existingPerson.FirstName = person.FirstName;
                    existingPerson.LastName = person.LastName;


                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdatePerson: {ex.Message}");
                return false;
            }
        }

   
        public List<Person> GetAllPersons()
        {
            return _context.Person.ToList();
        }
    }
}