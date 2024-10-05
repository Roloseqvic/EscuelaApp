using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;


namespace EscuelaApp.Persistencia.Data;

public partial class Course
{
    [Required(ErrorMessage = "Código de Curso es obligatorio.")]
    [RegularExpression("^\\d+$", ErrorMessage= "Solo se permiten números.")]
    
    public int CourseId { get; set; }

    [Required(ErrorMessage = "Título de Curso es obligatorio.")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Creditos de Curso es obligatorio.")]


    [Range(1, 5, ErrorMessage = "Debe digitar un valor entre 1 y 5.")]
    [RegularExpression("^\\d+$", ErrorMessage = "Solo se permiten números.")]
    public int Credits { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department? Department { get; set; } = null!;

    public virtual OnlineCourse? OnlineCourse { get; set; }

    public virtual OnsiteCourse? OnsiteCourse { get; set; }

    public virtual ICollection<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
