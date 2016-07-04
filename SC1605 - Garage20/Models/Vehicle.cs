using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SC1605___Garage20.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Owner is required!")]
        public string Owner { get; set; }

        [DisplayName("Registration Number")]
        [Required(ErrorMessage = "A registration number is required")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Color is required!")]
        public string Color { get; set; }

        [DisplayName("Number of wheels")]
        [Required(ErrorMessage = "The number of wheels are required")]
        public int NumberOfWheels { get; set; }

        [DisplayName("Vehicle Type")]
        [Required(ErrorMessage = "The Type is required")]
        public VehicleType VehicleType { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Vehicle parking date")]
        public DateTime? ParkedDate { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Vehicle allowed to park until")]
        public DateTime? EndParkedDate { get; set; }
    }

    public enum VehicleType
    {
        Car,
        Truck,
        Boat,
        MotorCycle
    }
}