// See https://aka.ms/new-console-template for more information


using Template_Method;

TemplateDeImpostoCondicional templateICPP = new ICPP();
TemplateDeImpostoCondicional templateIKCV = new IKCV();
TemplateDeImpostoCondicional templateIHIT = new IHIT();

templateICPP.Next = templateIKCV;
templateIKCV.Next = templateIHIT;

var calulaImposto = templateICPP.CriarImposto("ICPP");

Console.WriteLine(calulaImposto.Calcular(1000));
Console.ReadKey();




