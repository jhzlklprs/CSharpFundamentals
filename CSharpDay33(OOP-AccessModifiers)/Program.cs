using System.ComponentModel;

namespace CSharpDay33_OOP_AccessModifiers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HonorStudent honorStudent = new HonorStudent("2025011", 80, "Sample", "Honor");
            
            honorStudent.ShowBasicInfo();
            honorStudent.ShowDisciplinaryStatus();
        }
    }
}
