using NestedObjects;

Advisor comSciAdvisor = new ()
{
    Email = "mattchoque115@cptc.edu",
    FullName = "Matthew Choque",
    OfficeLocation = "B17 Rm 150"
};

Student Stu1 = new()
{
    FirstName = "Jake",
    LastName = "Brown",
    DateOfBirth = new DateOnly(2000, 5, 6),
    AssignedAdvisor = comSciAdvisor,
    PhoneNumber = "3608911348",
    SchoolEmail = "jakebrown891@students.cptc.edu"
};

Console.WriteLine($"Student: {Stu1.FirstName} has {Stu1.AssignedAdvisor.FullName}");