using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel.DataAnnotations;


namespace StudentDatabase;
[Table(nameof(Student))]

public class Student
{
    public int Id { get; set; }

    [MaxLength(100)]

    public string FirstName { get; set; } = null!;

    [MaxLength(100)]

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    [MaxLength(100)]

    public string Email { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public DateTime EnrollmentDate { get; set; }

}


