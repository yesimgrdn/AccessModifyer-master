// See https://aka.ms/new-console-template for more information
using AnaProgram;

Musteri m = new Musteri();
m.SetKKNO("123456789");
m.SetTelno("5302067109");
Console.WriteLine(m.GetKKNO());
Console.WriteLine(m.GetTelno());

KurumsalMusteri k = new KurumsalMusteri();