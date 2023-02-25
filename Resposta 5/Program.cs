        
string texto = "programação";

              
char[] caracteres = texto.ToCharArray();

int tamanho = caracteres.Length;
for (int i = 0; i < tamanho / 2; i++)
{
    char temp = caracteres[i];
    caracteres[i] = caracteres[tamanho - i - 1];            
    caracteres[tamanho - i - 1] = temp;        
}
        


Console.WriteLine(caracteres);
    