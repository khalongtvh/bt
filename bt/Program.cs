using System;

namespace bt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.tam giac!");
            Console.WriteLine("2.tu giac!");
            Console.WriteLine("3.hinh vuong!");
            Console.WriteLine("4.hinh binh hanh!");
            Console.WriteLine("5.hinh chu nhat!");
            Console.Write("nhap mot trong cac hinh : ");
            try
            {
                int a_299 = int.Parse(Console.ReadLine());
                switch (a_299)
                {
                    case 1:
                        tamGiac tg_229 = new tamGiac();
                        tg_229.ThongTin();
                        break;
                    case 2:
                        tuGiac tug_229 = new tuGiac();
                        tug_229.ThongTin();
                        break;
                    case 3:
                        hinhVuong hinhVuong_229 = new hinhVuong();
                        hinhVuong_229.ThongTin();
                        break;
                    case 4:
                        hinhBinhHanh hinhBinhHanh_229 = new hinhBinhHanh();
                        hinhBinhHanh_229.ThongTin();
                        break;
                    case 5:
                        hinhChuNhat hinhChuNhat_229 = new hinhChuNhat();
                        hinhChuNhat_229.ThongTin();
                        break;
                    default:
                        Console.WriteLine("Thoat!");
                        return;
                }
            }
            catch (Exception e) { }
        }
    }
    class daGiac
    {
        public virtual void ThongTin()
        {
            Console.WriteLine("so canh da giac : ");
        }
    }
    class tamGiac : daGiac
    {
        public override void ThongTin()
        {
            Console.WriteLine("so canh tam giac : 3 canh");
        }
    }
    class tuGiac : daGiac
    {
        public override void ThongTin()
        {
            Console.WriteLine("so canh tu giac : 4 canh");
        }
    }
    class hinhVuong : daGiac
    {
        public override void ThongTin()
        {
            Console.WriteLine("so canh hinh vuong : 4 canh");
        }
    }
    class hinhBinhHanh : daGiac
    {
        public override void ThongTin()
        {
            Console.WriteLine("so canh hinh binh Hanh : 4 canh");
        }
    }

    class hinhChuNhat: daGiac
    {
        public override void ThongTin()
        {
            Console.WriteLine("so canh hinh chu nhat : 4 canh");
        }
    }
}
