//Nhập vào thông tin sinh viên bao gồm (Id, Name, Birthday, Mark1, Mark2, Mark3), in ra
//thông tin sinh viên bao gồm cả điểm trung bình của 3 môn.

int d1, d2, d3;
string name = "";
string id;
float dtb;
DateTime birthDay;

Console.Write("Nhap vao id: ");
id = Console.ReadLine();
Console.Write("Nhap vao ten: ");
name = Console.ReadLine();
Console.Write("Nhap vao sinh nhat: ");
birthDay = Convert.ToDateTime(Console.ReadLine());
Console.Write("Nhap vao diem Toan: ");
d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap vao diem Ly: ");
d2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap vao diem Hoa: ");
d3 = Convert.ToInt32(Console.ReadLine());
dtb = (d1 + d2 + d3) / 3;
Console.WriteLine("Diem trung binh: " + dtb);
Console.WriteLine("=========================================");

Console.WriteLine("ID sv: " + id);
Console.WriteLine("Ten sv: " + name);
Console.WriteLine("Sinh nhat sv:{0:dd/MM/yyyy} " , birthDay);
Console.WriteLine("Diem Toan: " + d1);
Console.WriteLine("Diem Ly: " + d2);
Console.WriteLine("Diem Hoa: " + d3);
Console.WriteLine("Diem trung binh: " + dtb);





