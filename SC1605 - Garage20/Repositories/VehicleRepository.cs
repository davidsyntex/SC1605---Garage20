using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using SC1605___Garage20.DataAccessLayer;
using SC1605___Garage20.Models;

namespace SC1605___Garage20.Repositories
{
    public class VehicleRepository
    {
        private readonly VehicleContext _db = new VehicleContext();

        public IEnumerable<Vehicle> GetAll()
        {
            return _db.Vehicles.OrderBy(v => v.VehicleType).ThenBy(v => v.ParkedDate).ToList();
        }

        public bool Add(Vehicle vehicle)
        {
            try
            {
                _db.Vehicles.Add(vehicle);
                _db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public Vehicle Get(int? id)
        {
            try
            {
                return _db.Vehicles.Find(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }

        public bool Edit(Vehicle vehicle)
        {
            try
            {
                _db.Entry(vehicle).State = EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _db.Vehicles.Remove(Get(id));
                _db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<Vehicle> Find(string searchTerm)
        {
           return _db.Vehicles.Where(v => v.RegistrationNumber.Contains(searchTerm) || v.VehicleType.ToString().Contains(searchTerm) || v.Owner.Contains(searchTerm)) ;
        }
    }
}