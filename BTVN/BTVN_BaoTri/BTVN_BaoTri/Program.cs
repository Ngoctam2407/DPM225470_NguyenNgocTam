using System;
namespace BTVN_BaoTri;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Nhập dung lượng cho từng file
        Console.WriteLine("Nhập dung lượng cho các file (MB)  LƯU Ý : Nếu viết dạng thập phân thì dùng dấu phẩy nhé .");

        // Tạo file
        var A_cpp = new FileLeaf("A.cpp", Input("A.cpp"));
        var A1_doc = new FileLeaf("A1.doc", Input("A1.doc"));
        var A21_txt = new FileLeaf("A21.txt", Input("A21.txt"));
        var A22_doc = new FileLeaf("A22.doc", Input("A22.doc"));
        var B_txt = new FileLeaf("B.txt", Input("B.txt"));
        var C11_doc = new FileLeaf("C11.doc", Input("C11.doc"));
        var C12_exe = new FileLeaf("C12.exe", Input("C12.exe"));

        // Tạo thư mục
        var A1 = new FolderComposite("A1");
        A1.Add(A1_doc);

        var A2 = new FolderComposite("A2");
        A2.Add(A21_txt);
        A2.Add(A22_doc);

        var A = new FolderComposite("A");
        A.Add(A_cpp);
        A.Add(A1);
        A.Add(A2);

        var B = new FolderComposite("B");
        B.Add(B_txt);

        var C1 = new FolderComposite("C1");
        C1.Add(C11_doc);
        C1.Add(C12_exe);

        var C = new FolderComposite("C");
        C.Add(C1);

        // Gốc C:\
        var root = new FolderComposite("C:\\");
        root.Add(A);
        root.Add(B);
        root.Add(C);

        Console.WriteLine($"\n=> Tổng dung lượng thư mục C:\\ là: {root.GetSize()} MB");
    }

    static double Input(string fileName)
    {
        Console.Write($"- {fileName}: ");
        return double.Parse(Console.ReadLine());
    }
}
