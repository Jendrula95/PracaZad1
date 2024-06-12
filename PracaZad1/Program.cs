

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("student@email.com");
        Kontrahent kontrahent = new Kontrahent("kontrahent@email.com");
        Urzad urzad = new Urzad("urzad@email.com");

        EmailSender emailSender = new EmailSender();

        emailSender.SendEmail(student);
        emailSender.SendEmail(kontrahent);
        emailSender.SendEmail(urzad);

      
    }
}
public interface IEmail
{
    string Email { get; set; }
}

public class Student : IEmail
{
    public string Email { get; set; }

    public Student(string email)
    {
        Email = email;
    }
}

public class Kontrahent : IEmail
{
    public string Email { get; set; }

    public Kontrahent(string email)
    {
        Email = email;
    }
}

public class Urzad : IEmail
{
    public string Email { get; set; }

    public Urzad(string email)
    {
        Email = email;
    }
}
public class EmailSender
{
    public void SendEmail(IEmail contact)
    {
        Console.WriteLine($"Email wysłano do : {contact.Email}");
    }
}



