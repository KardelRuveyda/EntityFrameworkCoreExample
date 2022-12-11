// See https://aka.ms/new-console-template for more information
using EntityFrameworkCoreExample.DataContext;
using EntityFrameworkCoreExample.Models;



using (var context = new AppDbContext())
{
    ////INSERT
    //var student = new Student()
    //{
    //    Email = "ruveydakardelcetin@gmail.com",
    //    FirstName = "Kardel",
    //    LastName = "Ruveyda",
    //    Telephone = "5305153061"
    //};

    //context.Students.Add(student);
    //context.SaveChanges();
    //Console.WriteLine("Veri tabanına başarılı bir şekilde eklendi!");
    //Console.ReadLine();

    //Tolist

    //var students = context.Students.ToList();

    //foreach (var item in students)
    //{
    //    Console.WriteLine(String.Join("Öğrenci adı : {0}", item.FirstName));
    //    Console.ReadLine();
    //}

    ////UPDATE
    //var student = context.Students.Where(x => x.Id == 1).FirstOrDefault();

    //if (student != null)
    //{
    //    student.FirstName = "Aynur";
    //    student.LastName = "Katırcıoğlu";

    //    context.Update(student);
    //    context.SaveChanges();

    //    Console.WriteLine("Veri tabanına başarılı bir şekilde güncellendi");
    //    Console.ReadLine();
    //}

    //Delete İşlemi 

    List<int> removeListIds = new List<int>();

    removeListIds.Add(2);
    removeListIds.Add(3);

    bool isRemoved = false;
    string message = "Bir hata oluştu";
    try
    {
        foreach (var item in removeListIds)
        {
            var student = context.Students.Where(x => x.Id == item).FirstOrDefault();
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                isRemoved = true;
                message = "Silme işlemi başarılı.";
            }
        }
    }
    catch (Exception)
    {

        isRemoved = false;
    }


    if (isRemoved)
    {
        var studentNew = context.Students.Where(x => x.Id == 1).FirstOrDefault();

        if (studentNew != null)
        {
            studentNew.FirstName = "Test";
            studentNew.LastName = "Test2";
            studentNew.Email = "test3@gmail.com";
            studentNew.Telephone = "2124444444";

            context.Students.Update(studentNew);
            context.SaveChanges();

            message = "Hem silme hem güncelleme işlemi gerçekleşti.";
            isRemoved = true;
        }
    }
    Console.WriteLine(message);
    Console.ReadLine();
}