// See https://aka.ms/new-console-template for more information
using Flyweight;

NotasMusicais notas = new NotasMusicais();

List<INota> doReMiFa = new List<INota>() {
    notas.ObterNota("do"),    
    notas.ObterNota("re"),    
    notas.ObterNota("mi"),    
    notas.ObterNota("fa"),    
    notas.ObterNota("fa"),    
    notas.ObterNota("fa"),    

    notas.ObterNota("do"),    
    notas.ObterNota("re"),    
    notas.ObterNota("do"),    
    notas.ObterNota("re"),    
    notas.ObterNota("re"),    
    notas.ObterNota("re"),

    notas.ObterNota("do"),    
    notas.ObterNota("sol"),    
    notas.ObterNota("fa"),    
    notas.ObterNota("mi"),    
    notas.ObterNota("mi"),    
    notas.ObterNota("mi"),

    notas.ObterNota("do"),    
    notas.ObterNota("re"),    
    notas.ObterNota("mi"),    
    notas.ObterNota("fa"),    
    notas.ObterNota("fa"),    
    notas.ObterNota("fa")
};

Piano piano = new Piano();
piano.Tocar(doReMiFa);
