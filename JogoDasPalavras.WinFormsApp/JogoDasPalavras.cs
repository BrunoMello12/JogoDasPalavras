using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasPalavras.WinFormsApp
{
    public class JogoDasPalavras
    {
        private string palavraSecreta;
        public bool jogadorAcertou = false;

        public bool VerificarSeJogadorAcertou(char palpite)
        {
            jogadorAcertou = false;

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palpite == palavraSecreta[i])
                {
                    return jogadorAcertou = true;
                }
            }

            return jogadorAcertou;
        }

        public string ObterPalavraSecreta()
        {
            string[] palavras = new string[]
            {
                "ácido", "adiar", "ímpar", "algar", "amado", "amigo", "anexo", "anuir", "aonde", "apelo",
                "aquém", "argil", "arroz", "assar", "atrás", "ávido", "azeri", "babar", "bagre", "banho",
                "barco", "bicho", "bolor", "brasa", "brava", "brisa", "bruto", "bulir", "caixa", "cansa",
                "chato", "chave", "chefe", "choro", "chulo", "claro", "cobre", "corte", "curar", "deixo",
                "dizer", "dogma", "dores", "duque", "enfim", "estou", "exame", "falar", "fardo", "farto",
                "fatal", "feliz", "ficar", "fogue", "força", "forno", "fraco", "fugir", "fundo", "fúria",
                "gaita", "gasto", "geada", "gelar", "gosto", "grito", "gueto", "honra", "humor", "idade",
                "ideia", "ídolo", "igual", "imune", "índio", "íngua", "irado", "isola", "janta", "jovem",
                "juizo", "largo", "laser", "leite", "lento", "lerdo", "levar", "lidar", "lindo", "lírio",
                "longe", "luzes", "magro", "maior", "malte", "mamar", "manto", "marca", "matar", "meigo",
                "meios", "melão", "mesmo", "metro", "mimos", "moeda", "moita", "molho", "morno", "morro",
                "motim", "muito", "mural", "naipe", "nasci", "natal", "naval", "ninar", "nível", "nobre",
                "noite", "norte", "nuvem", "oeste", "ombro", "ordem", "órgão", "ósseo", "ossos", "outro",
                "ouvir", "palma", "pardo", "passe", "pátio", "peito", "pêlos", "perdo", "períl", "perto",
                "pezar", "piano", "picar", "pilar", "pingo", "pione", "pista", "poder", "porém", "prado",
                "prato", "prazo", "preço", "prima", "primo", "pular", "quero", "quota", "raiva", "rampa",
                "rango", "reais", "reino", "rezar", "risco", "roçar", "rosto", "roubo", "russo", "saber",
                "sacar", "salto", "samba", "santo", "selar", "selos", "senso", "serão", "serra", "servo",
                "sexta", "sinal", "sobra", "sobre", "sócio", "sorte", "subir", "sujei", "sujos", "talão",
                "talha", "tanga", "tarde", "tempo", "tenho", "terço", "terra", "tesão", "tocar", "lacre",
                "laico", "lamba", "lambo", "largo", "larva", "lasca", "laser", "laura", "lavra", "leigo",
                "leite", "leito", "leiva", "lenho", "lento", "leque", "lerdo", "lesão", "lesma", "levar",
                "libra", "limbo", "lindo", "líneo", "lírio", "lisar", "lista", "livro", "logar", "lombo",
                "lotes", "louca", "louco", "louro", "lugar", "luzes", "macio", "maçom", "maior", "malha",
                "malte", "mamar", "mamãe", "manto", "março", "maria", "marra", "marta", "matar", "medir",
                "meigo", "meios", "melão", "menta", "menti", "mesmo", "metro", "miado", "mídia", "mielo",
                "mielo", "milho", "mimos", "minar", "minha", "miolo", "mirar", "missa", "mitos", "moeda",
                "moído", "moita", "molde", "molho", "monar", "monja", "moral", "morar", "morda", "morfo",
                "morte", "mosca", "mosco", "motim", "motor", "mudar", "muito", "mular", "mulas", "múmia",
                "mural", "extra", "falar", "falta", "fardo", "farol", "farto", "fatal", "feixe", "festa",
                "feudo", "fezes", "fiapo", "fibra", "ficha", "fidel", "filão", "filho", "firma", "fisco",
                "fisga", "fluir", "força", "forma", "forte", "fraco", "frade", "friso", "frito", "fugaz",
                "fugir", "fundo", "furor", "furto", "fuzil", "gabar", "gaita", "galho", "ganho", "garoa",
                "garra", "garro", "garvo", "gasto", "gaupe", "gazua", "geada", "gemer", "germe", "gigas",
                "girar", "gizar", "globo", "gosto", "grãos", "graça", "grava", "grito", "grude", "haver",
                "haver", "hiato", "hidra", "hífen", "hímel", "horas", "hotel", "humor", "ideal", "ídolo",
                "igual", "ileso", "imune", "irado", "isola", "jarra", "jaula", "jegue", "jeito", "jogar",
                "jovem", "juíza", "juizo", "julho", "junho", "jurar", "justa"
            };

            Random random = new Random();
            int indiceAleatorio = random.Next(palavras.Length);

            return palavraSecreta = palavras[indiceAleatorio];
        }

        

        public Color AvaliarLetra(char caractere, int posicao)
        {
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (caractere == palavraSecreta[posicao])
                {
                    return Color.Green;
                }
                else if (palavraSecreta.Contains(caractere.ToString()))
                {
                    return Color.Yellow;
                }
                else
                {
                    return Color.Red;
                }
            }

            return Color.White;
        }

        public enum VerificarCor
        {
            Green = 0,
            Yellow = 1,
            Red = 2
        }

        public static class VerificarCorExtensions
        {
            public static VerificarCor FromColor(Color color)
            {
                if (color == Color.Green)
                    return VerificarCor.Green;
                else if (color == Color.Yellow)
                    return VerificarCor.Yellow;
                else if (color == Color.Red)
                    return VerificarCor.Red;
                else
                    throw new ArgumentException("Invalid color value", nameof(color));
            }
        }



    }
}
