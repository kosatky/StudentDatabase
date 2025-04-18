using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel.DataAnnotations;

namespace StudentDatabase;
[Table(nameof(Course))]

public class Course
{
    public int Id { get; set; }

    [MaxLength(100)]

    public string CourseName { get; set; } = null!;

    public int Credits { get; set; }

    [MaxLength(100)]

    public string Department { get; set; } = null!;

    [MaxLength(100)]

    public string Description { get; set; } = null!;
}