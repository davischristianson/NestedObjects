using NestedObjects;
using System.ComponentModel.DataAnnotations;

Advisor compSciAdvisor = new Advisor()
{
    Email = "Clarkkent@cptc.edu",
    FullName = "Clark Kent",
    OfficeLocation = "S1 Rm 365"
};

Student stu1 = new Student()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "1234567890",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} as their advisor");